namespace PORDUCT_MANAGER
{
    partial class FRM_INVENTORY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_export_excel = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_products_title = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_qty_title = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_value_title = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_out_title = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(287, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "ادارة الجرد والمخزون";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_print);
            this.groupBox1.Controls.Add(this.btn_export_excel);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث سريع";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(641, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخل للبحث";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(442, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(184, 26);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(349, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "بحث";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(256, 14);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 33);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "تحديث";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_export_excel
            // 
            this.btn_export_excel.Location = new System.Drawing.Point(139, 16);
            this.btn_export_excel.Name = "btn_export_excel";
            this.btn_export_excel.Size = new System.Drawing.Size(98, 33);
            this.btn_export_excel.TabIndex = 3;
            this.btn_export_excel.Text = "تصدير لاكسل";
            this.btn_export_excel.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(41, 17);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 33);
            this.btn_print.TabIndex = 3;
            this.btn_print.Text = "طباعة";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.lbl_out_title);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lbl_value_title);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lbl_qty_title);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lbl_products_title);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "احصايىات المخزون";
            // 
            // lbl_products_title
            // 
            this.lbl_products_title.AutoSize = true;
            this.lbl_products_title.Location = new System.Drawing.Point(682, 34);
            this.lbl_products_title.Name = "lbl_products_title";
            this.lbl_products_title.Size = new System.Drawing.Size(83, 20);
            this.lbl_products_title.TabIndex = 0;
            this.lbl_products_title.Text = "عدد المنتجات";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_qty_title
            // 
            this.lbl_qty_title.AutoSize = true;
            this.lbl_qty_title.Location = new System.Drawing.Point(431, 37);
            this.lbl_qty_title.Name = "lbl_qty_title";
            this.lbl_qty_title.Size = new System.Drawing.Size(84, 20);
            this.lbl_qty_title.TabIndex = 3;
            this.lbl_qty_title.Text = "اجمالي الكمية";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 4;
            // 
            // lbl_value_title
            // 
            this.lbl_value_title.AutoSize = true;
            this.lbl_value_title.Location = new System.Drawing.Point(176, 37);
            this.lbl_value_title.Name = "lbl_value_title";
            this.lbl_value_title.Size = new System.Drawing.Size(90, 20);
            this.lbl_value_title.TabIndex = 3;
            this.lbl_value_title.Text = "القيمة الاجمالية";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 26);
            this.textBox3.TabIndex = 3;
            // 
            // lbl_out_title
            // 
            this.lbl_out_title.AutoSize = true;
            this.lbl_out_title.Location = new System.Drawing.Point(503, 90);
            this.lbl_out_title.Name = "lbl_out_title";
            this.lbl_out_title.Size = new System.Drawing.Size(102, 20);
            this.lbl_out_title.TabIndex = 3;
            this.lbl_out_title.Text = "المنتجات المنتهية";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(324, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(163, 26);
            this.textBox4.TabIndex = 5;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(196, 94);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(92, 20);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "المنتجات القليلة";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 92);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 26);
            this.textBox5.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 164);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox3.Location = new System.Drawing.Point(2, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "اوامر سريعة";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(462, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 54);
            this.button2.TabIndex = 5;
            this.button2.Text = "عرض المنتجات القليلة";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button3.Location = new System.Drawing.Point(332, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 54);
            this.button3.TabIndex = 6;
            this.button3.Text = "طباعة التقرير";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button4.Location = new System.Drawing.Point(187, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 54);
            this.button4.TabIndex = 7;
            this.button4.Text = "تصدير لاكسل";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button5.Location = new System.Drawing.Point(83, 8);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 54);
            this.button5.TabIndex = 8;
            this.button5.Text = "اغلاق";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FRM_INVENTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FRM_INVENTORY";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الجرد والمخزون";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_export_excel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_qty_title;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_products_title;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_out_title;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_value_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}