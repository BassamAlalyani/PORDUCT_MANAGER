using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORDUCT_MANAGER
{

    public partial class FRM_POS : Form
    {


        classes.CLS_Sales cs = new classes.CLS_Sales();
        classes.CLS_product cs_product = new classes.CLS_product();

        DataTable cart = new DataTable();
        decimal total_invoice = 0;
        private readonly int order_id;

        public FRM_POS()
        {
            InitializeComponent();
        }

        private void FRM_POS_Load(object sender, EventArgs e)
        {


            // **الحل: لا تستخدم DataSource، أضف الأعمدة يدوياً**

            // تأكد من أن DataGridView فارغ وغير مربوط
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // أضف الأعمدة يدوياً
            dataGridView1.Columns.Add("Column1", "رقم المنتج");
            dataGridView1.Columns.Add("Column2", "اسم المنتج");
            dataGridView1.Columns.Add("Column3", "الكمية");
            dataGridView1.Columns.Add("Column4", "السعر");
            dataGridView1.Columns.Add("Column5", "الإجمالي");

            // تحديد عرض الأعمدة
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 100;

            // إعدادات مهمة
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // تعبئة بيانات الفاتورة
            txt_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txt_invoice_num.Text = "سيتم توليده تلقائياً";

            txt_search.Focus();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                DataTable dt = cs.Search_product_for_sale(txt_search.Text);
                if (dt.Rows.Count > 0)
                {
                    txt_id.Text = dt.Rows[0]["معرف المنتج"].ToString();
                    txt_name.Text = dt.Rows[0]["اسم المنتج"].ToString();
                    txt_price.Text = dt.Rows[0]["سعر البيع"].ToString();

                    // عرض الكمية المتاحة
                    int availableQte = Convert.ToInt32(dt.Rows[0]["الكمية المتاحة"]);
                    numeric_qte.Maximum = availableQte;
                    numeric_qte.Value = 1;

                    numeric_qte.Focus();
                }
                else
                {
                    MessageBox.Show("المنتج غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)/// هذا زر الاظافة
        {


            // تحقق من البيانات
            if (string.IsNullOrWhiteSpace(txt_id.Text) || numeric_qte.Value <= 0)
            {
                MessageBox.Show("الرجاء اختيار منتج وإدخال الكمية", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int qte = (int)numeric_qte.Value;
            

            int price = 0;
            if (!int.TryParse(txt_price.Text, out price))
            {
                // إذا كان فيه فاصلة عشرية (مثل 200.00)
                string cleanPrice = txt_price.Text.Replace(".", "").Split(',')[0];
                int.TryParse(cleanPrice, out price);
            }
            int total = qte * price;

            // التحقق من توفر الكمية
            DataTable dt = cs.Search_product_for_sale(txt_id.Text);
            if (dt.Rows.Count > 0)
            {
                int availableQte = Convert.ToInt32(dt.Rows[0]["الكمية المتاحة"]);
                if (qte > availableQte)
                {
                    MessageBox.Show($"الكمية المتاحة: {availableQte} فقط", "كمية غير متوفرة", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // **الحل: أضف الصف مباشرة لـ DataGridView**
            // لا تستخدم DataSource، استخدم Rows.Add مباشرة
            dataGridView1.Rows.Add(txt_id.Text, txt_name.Text, qte, price.ToString(), total.ToString());

            // تحديث الإجمالي
            total_invoice += total;
            txt_total.Text = total_invoice.ToString();

            ClearFields();


            void ClearFields()
            {
                txt_search.Clear();
                txt_id.Clear();
                txt_name.Clear();
                txt_price.Clear();
                numeric_qte.Value = 1;
                txt_search.Focus();
            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && !row.IsNewRow)
                {
                    string product_id = row.Cells[0].Value.ToString();
                    int qte = SafeConvertToInt(row.Cells[2].Value);
                    int price = SafeConvertToInt(row.Cells[3].Value);
                    int total = SafeConvertToInt(row.Cells[4].Value);
                    MessageBox.Show("جاري حفظ الفاتورة...", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cs.add_sale_order("نقطة بيع", 0, txt_notes.Text);
                    MessageBox.Show("تمت إضافة الفاتورة الرئيسية", "معلومة", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cs.add_sale_detail(product_id, order_id, qte, price, total);
                    cs.update_product_qte_after_sale(product_id, qte);
                }
            }


        }



        private void button_cancel_Click(object sender, EventArgs e)
        {


            if (cart.Rows.Count > 0)
            {
                if (MessageBox.Show("هل تريد إلغاء الفاتورة الحالية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                }
            }
            else
            {
                this.Close();

            }
        }

        private void ClearFields()
        {
            txt_search.Clear();
            txt_id.Clear();
            txt_name.Clear();
            txt_price.Clear();
            numeric_qte.Value = 1;
            txt_search.Focus();
        } 
    
        //  void ClearAll()
        //{
        //    cart.Clear();
        //    total_invoice = 0;
        //    txt_total.Clear();
        //    txt_notes.Clear();
        //    txt_customer.Clear();
        //    txt_invoice_num.Text = "سيتم توليده تلقائياً";
        //    ClearFields();
       // }
    
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)// الدخول بنقر enter
        {
            if (e.KeyChar == (char)13) // زر Enter
            {
                btn_search.PerformClick();
                e.Handled = true;
            }
        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)// حذف 
        {
            // حذف منتج من عربة التسوق عند النقر المزدوج
            if (e.RowIndex >= 0 && cart.Rows.Count > 0)
            {
                int itemTotal = Convert.ToInt32(cart.Rows[e.RowIndex]);
                total_invoice -= itemTotal;
                txt_total.Text = total_invoice.ToString();

                cart.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private int SafeConvertToInt(object value)
        {
            if (value == null) return 0;

            string str = value.ToString();
            str = str.Replace(",", "").Replace(".", "");

            int result;
            if (int.TryParse(str, out result))
                return result;

            return 0;
        }
    }
}

