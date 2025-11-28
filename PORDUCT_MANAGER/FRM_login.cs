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
    public partial class FRM_login : Form // هذا الكلاس وظيفته 
    {
        public FRM_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            classes.CS_LOGin cs_LO = new classes.CS_LOGin();
            dt =  cs_LO.login( textBox1.Text ,textBox2.Text );
            if( dt.Rows.Count > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("تسجيل  الدخول خاطي ");
            }

            Form1 f = Application.OpenForms["Form1"] as Form1;
           f.button1.Enabled = true;
            f.button2.Enabled = false;
            f.button3.Enabled = true;
            f.button4.Enabled = true;
           // f.menuStrip2.Enabled = true;
          
         




        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
