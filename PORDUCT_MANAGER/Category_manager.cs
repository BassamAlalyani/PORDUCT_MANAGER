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
    public partial class Category_manager : Form
    {
        public Category_manager()
        {
            InitializeComponent();
        }


        classes.category_manager cs = new classes.category_manager();// استدعي الكلاس تبعه كاس ادارة المنتجات 
        private void Category_manager_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource =  cs.show_categories(); // لعرض  بيانات الصنف اللي ادخلتها في datagridView
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //   زر الاظافة  او يسمى ادخال 
        {
           // classes.category_manager cs = new classes.category_manager();
            cs.add_category(textBox1.Text); // اضف صنف جديد لنفس التيكست المذكور 
            textBox1.Clear();// حذف البيانات من تكست وان بعد الادخال 
            textBox1.Focus(); // نفسه 

            dataGridView1.DataSource = cs.show_categories();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e) // حدث لعرض الاصناف المدخلة في قايمة العرض 
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e) // زر تعديل عنصر محدد من قايمة الاصناف 
        {
            cs.edit_category( Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value) , textBox2.Text);
            dataGridView1.DataSource = cs.show_categories(); // تحديث عرض الجدول بعد التعديل 
        }

        private void button3_Click(object sender, EventArgs e) //زر حذف عنصر محدد من قايمة الاصناف 
        {
            if(MessageBox.Show("هل متاكد من حذف هذا العنصر", "تحذير !" , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cs.delete_category(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = cs.show_categories(); // تحديث عرض الجدول بعد الحذف 
            }
        }
    }
}
