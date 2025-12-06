using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using PORDUCT_MANAGER.classes;
namespace PORDUCT_MANAGER
{
    public partial class FRM_ADD_PRODUCT : Form // هذا الكلاس لاظافة المنتجات 
    {
        classes.category_manager csca = new classes.category_manager();//استدعيت كلاس ادارة الاصناف هنا لتعبية الكومبكس بالاصناف 
        public FRM_ADD_PRODUCT()
        {
            InitializeComponent();
            comboBox1.DataSource = csca.show_categories(); //اعرض لي الاصناف في combobox1
            comboBox1.DisplayMember = "category_name";// اعرض لي اسماء الاصناف فيها
           comboBox1.ValueMember = "ID_CATEGORES"; //اعرض قيمها 
        }

        private void button3_Click(object sender, EventArgs e)// هذا زر الاستعراض 
        {
            OpenFileDialog opd = new OpenFileDialog();
            opd.Filter = "images only | *.jpg; *.png ";
            if(opd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opd.FileName);
            }
        }

        //classes.CLS_product cs = new classes.CLS_product();// استدعينا هذا الكلاس 
        private void button2_Click(object sender, EventArgs e)// برمجة زر الغاء  في قايمة اظافة منتج جديد
        {
            this.Close();
        }

        classes.CLS_product cs = new classes.CLS_product();
        private void button1_Click(object sender, EventArgs e) // هذا زر الاظافة 
        {
            MemoryStream ms = new MemoryStream();// هذه جاهز وتعمل 
           pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            cs.add_product(txt_id.Text, txt_name.Text, int.Parse(numericUpDown1.Value.ToString()), int.Parse(txt_buy.Text), int.Parse(txt_sale.Text), img, int.Parse(comboBox1.SelectedValue.ToString()) );
            txt_sale.Clear(); // لافراغ الحقول 
            txt_name.Clear();
            txt_id.Clear();
            txt_buy.Clear();
           numericUpDown1.Value = 0;
            txt_id.Focus(); // لوضع الموشر في اول حقل 

        }

        private void FRM_ADD_PRODUCT_Load(object sender, EventArgs e)
        {

        }
    }
}