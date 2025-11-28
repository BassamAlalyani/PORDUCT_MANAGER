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
    public partial class FRM_product_manager : Form
    {
        public FRM_product_manager()
        {
            InitializeComponent();
        }
        classes.CLS_product cs = new classes.CLS_product(); //لازم استدعي هذا الكلاس عشان ابرمج واجهة  ادارة المنتجات 
        private void FRM_product_manager_Load(object sender, EventArgs e)//  
        {
            dataGridView1.DataSource = cs.Get_All_Product(); // البيانات هنا من  get_all...
        }

        private void FRM_product_manager_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)// هذا حدث جديد اسمه TextChanged 
        {
            dataGridView1.DataSource = cs.Search_product(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)// برمجة اظافة منتج جديد
        {
            // لقد قمنا ببرمجته سابقا الان سوف نعرض الفورم الخاص به فقط
            Form f = new FRM_ADD_PRODUCT();
            f.ShowDialog();
            dataGridView1.DataSource = cs.Get_All_Product(); // بعد الاظافة يجب تحديث  العرض لق
        }

        private void button3_Click(object sender, EventArgs e)//نبرمج زر الحذف 
        {
            if(MessageBox.Show("هل انت متاكد من الحذف ", "انتبه" , MessageBoxButtons.YesNo ,MessageBoxIcon.Question) ==DialogResult.Yes)

            cs.delete_product(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView1.DataSource = cs.Get_All_Product(); // تحديث قاعدة البيانات 


        }
    }
}
