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
    public partial class FRM_suppliers_manager : Form
    {
        public FRM_suppliers_manager()
        {
            InitializeComponent();
        }
        classes.CLS_suppliers cs = new classes.CLS_suppliers();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// زر الاظافة 
        {

            cs.add_supplier(txt_name.Text, txt_phone.Text, txt_address.Text, txt_email.Text);
            txt_name.Clear();
            txt_phone.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_name.Focus();

            dataGridView1.DataSource = cs.show_suppliers();

        }

        private void FRM_suppliers_manager_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cs.show_suppliers();
        }

        private void button2_Click(object sender, EventArgs e)// زر التعديل
        {

            cs.edit_supplier(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), txt_name.Text, txt_phone.Text, txt_address.Text, txt_email.Text);
            dataGridView1.DataSource = cs.show_suppliers();
        }

        private void button3_Click(object sender, EventArgs e)//  زر الحذف
        {

            if (MessageBox.Show("هل متاكد من حذف هذا المورد", "تحذير !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cs.delete_supplier(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                dataGridView1.DataSource = cs.show_suppliers();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
