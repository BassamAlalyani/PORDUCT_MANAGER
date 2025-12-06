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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            تسجيلالدخولToolStripMenuItem.PerformClick();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            نقطةبيعToolStripMenuItem.PerformClick();

   
            FRM_POS f = new FRM_POS();
            f.ShowDialog();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            اظافةفاتورةشراءToolStripMenuItem.PerformClick();
            FRM_ADD_PURCHASE  n = new FRM_ADD_PURCHASE();
            n.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ادخالمنتججديدToolStripMenuItem.PerformClick();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e) // نافذة تسجيل الدخول 
        {
            FRM_login fRM_ = new FRM_login();
            fRM_.ShowDialog(); //  هذه دالة جاهزة لفتح الفورم حق تسجيل الدخول 
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)// تفعل كل الازرار  لماذا 
        {
            تسجيلالدخولToolStripMenuItem.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            الحساباتToolStripMenuItem.Enabled = false;
            الموردينToolStripMenuItem.Enabled = false;
            العملاءToolStripMenuItem.Enabled = false;
            المنتجاتToolStripMenuItem.Enabled = false;
            المستودعToolStripMenuItem.Enabled = false;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // اعطيته امر الخروج من البرنامج بشكل شامل 
        }

        private void ادارةالاصنافToolStripMenuItem_Click(object sender, EventArgs e) // فتح فورم ادارة الاصناف 
        {
            Category_manager f = new Category_manager();
            f.ShowDialog();
        }

        private void ادخالمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f =  new FRM_ADD_PRODUCT(); // ليش مش FRM_ADD_PRODUCT  f = new FRM_ADD_PRODUCT();
            f.ShowDialog(); // دالة لفتح  فورم اظافة منتج جديد تكتبها في الفورم الرايسي
        }

        private void ادارةالمنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FRM_product_manager();
            f.ShowDialog();
        }

        private void اظافةموردجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_suppliers_manager f = new FRM_suppliers_manager();
            f.ShowDialog();
        }

        private void اظافةفاتورةشراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PURCHASE f = new FRM_ADD_PURCHASE();
            f.ShowDialog();
        }

        private void نقطةبيعToolStripMenuItem_Click(object sender, EventArgs e)
        {

        
            FRM_POS f = new FRM_POS();
            f.ShowDialog();
        
    }
    }
}
