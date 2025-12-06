using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PORDUCT_MANAGER
{
    public partial class FRM_ADD_PURCHASE : Form
    {
        classes.CLS_orders cs = new classes.CLS_orders();
        classes.CLS_product cs_product = new classes.CLS_product();

        DataTable cart = new DataTable();
        int total_invoice = 0;
        public FRM_ADD_PURCHASE()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ADD_PURCHASE_Load(object sender, EventArgs e)
        {

        
            // إنشاء عربة التسوق
          cart.Columns.Add("رقم المنتج");
            cart.Columns.Add("اسم المنتج");
            cart.Columns.Add("الكمية");
            cart.Columns.Add("سعر الشراء");
            cart.Columns.Add("الإجمالي");

            dataGridView1.DataSource = cart;

            // تعبئة بيانات الفاتورة تلقائياً
            txt_date.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txt_invoice_num.Text = "سيتم توليده تلقائياً";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
                  if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                DataTable dt = cs_product.Search_product(txt_search.Text);
                if (dt.Rows.Count > 0)
                {
                    txt_id.Text = dt.Rows[0]["معرف المنتج"].ToString();
                    txt_name.Text = dt.Rows[0]["اسم المنتج"].ToString();
                    txt_price.Text = dt.Rows[0]["سعر الشراء"].ToString();
                    numeric_qte.Focus();
                }
                else
                {
                    MessageBox.Show("المنتج غير موجود");
                }
           }
        
    }

        private void button_add_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrWhiteSpace(txt_id.Text) || numeric_qte.Value <= 0)
            {
                MessageBox.Show("الرجاء اختيار منتج وإدخال الكمية");
                return;
            }

            int qte = (int)numeric_qte.Value;
            int price = int.Parse(txt_price.Text);
            int total = qte * price;

            // إضافة للمشتريات
            DataRow row = cart.NewRow();
            row["رقم المنتج"] = txt_id.Text;
            row["اسم المنتج"] = txt_name.Text;
            row["الكمية"] = qte;
            row["سعر الشراء"] = price;
            row["الإجمالي"] = total;
            cart.Rows.Add(row);

            // تحديث الإجمالي
            total_invoice += total;
            txt_total.Text = total_invoice.ToString();

            ClearFields();
        
    }

        private void button_save_Click(object sender, EventArgs e)
        { 
            if (cart.Rows.Count == 0)
            {
                MessageBox.Show("الرجاء إضافة منتجات للفاتورة");
                return;
            }

            try
            {
                // إضافة الفاتورة الرئيسية
                cs.add_purchase_order("مشتريات", 0, txt_notes.Text);

                // الحصول على آخر فاتورة
                DataTable last_order = cs.get_last_order();
                int order_id = Convert.ToInt32(last_order.Rows[0]["ID_order"]);

                // تحديث رقم الفاتورة في الواجهة
                txt_invoice_num.Text = order_id.ToString();

                // إضافة التفاصيل وتحديث الكميات
                foreach (DataRow row in cart.Rows)
                {
                    string product_id = row["رقم المنتج"].ToString();
                    int qte = Convert.ToInt32(row["الكمية"]);
                    int price = Convert.ToInt32(row["سعر الشراء"]);
                    int total = Convert.ToInt32(row["الإجمالي"]);

                    cs.add_order_detail(product_id, order_id, qte, price, total);
                    cs.update_product_qte(product_id, qte);
                }

                MessageBox.Show("تم حفظ فاتورة الشراء بنجاح - رقم الفاتورة: " + order_id);
                ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في حفظ الفاتورة: " + ex.Message);
            }
              }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ClearFields()
        {
            if (txt_search != null) txt_search.Clear();
            if (txt_id != null) txt_id.Clear();
            if (txt_name != null) txt_name.Clear();
            if (txt_price != null) txt_price.Clear();
            if (numeric_qte != null) numeric_qte.Value = 1;
            if (txt_search != null) txt_search.Focus();
        }

        private void ClearAll()
        {
            if (cart != null) cart.Clear();
            total_invoice = 0;
            if (txt_total != null) txt_total.Clear();
            if (txt_notes != null) txt_notes.Clear();
            if (txt_invoice_num != null) txt_invoice_num.Text = "سيتم توليده تلقائياً";
            ClearFields();
        }
    }
}
