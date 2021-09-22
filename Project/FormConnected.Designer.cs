namespace Project
{
    partial class FormConnected
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_id = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.category = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.sup_id = new System.Windows.Forms.TextBox();
            this.prodname = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb2_id = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cat = new System.Windows.Forms.TextBox();
            this.st = new System.Windows.Forms.TextBox();
            this.pr = new System.Windows.Forms.TextBox();
            this.sup = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.stocktxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.suptxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "SupplierID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price";
            // 
            // cmb_id
            // 
            this.cmb_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id.FormattingEnabled = true;
            this.cmb_id.Location = new System.Drawing.Point(123, 40);
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(100, 24);
            this.cmb_id.TabIndex = 7;
            this.cmb_id.SelectedIndexChanged += new System.EventHandler(this.cmb_id_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.category);
            this.tabPage1.Controls.Add(this.stock);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.sup_id);
            this.tabPage1.Controls.Add(this.prodname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmb_id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SelectWithBind";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(123, 120);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(100, 22);
            this.category.TabIndex = 12;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(123, 164);
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Size = new System.Drawing.Size(100, 22);
            this.stock.TabIndex = 11;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(123, 210);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 10;
            // 
            // sup_id
            // 
            this.sup_id.Location = new System.Drawing.Point(123, 252);
            this.sup_id.Name = "sup_id";
            this.sup_id.ReadOnly = true;
            this.sup_id.Size = new System.Drawing.Size(100, 22);
            this.sup_id.TabIndex = 9;
            // 
            // prodname
            // 
            this.prodname.Location = new System.Drawing.Point(123, 80);
            this.prodname.Name = "prodname";
            this.prodname.ReadOnly = true;
            this.prodname.Size = new System.Drawing.Size(100, 22);
            this.prodname.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cmb2_id);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cat);
            this.tabPage2.Controls.Add(this.st);
            this.tabPage2.Controls.Add(this.pr);
            this.tabPage2.Controls.Add(this.sup);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 39);
            this.button2.TabIndex = 28;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb2_id
            // 
            this.cmb2_id.FormattingEnabled = true;
            this.cmb2_id.Location = new System.Drawing.Point(129, 41);
            this.cmb2_id.Name = "cmb2_id";
            this.cmb2_id.Size = new System.Drawing.Size(100, 24);
            this.cmb2_id.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 25;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cat
            // 
            this.cat.Location = new System.Drawing.Point(129, 125);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(100, 22);
            this.cat.TabIndex = 24;
            // 
            // st
            // 
            this.st.Location = new System.Drawing.Point(129, 169);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(100, 22);
            this.st.TabIndex = 23;
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(129, 215);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(100, 22);
            this.pr.TabIndex = 22;
            // 
            // sup
            // 
            this.sup.Location = new System.Drawing.Point(129, 257);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(100, 22);
            this.sup.TabIndex = 21;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 85);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 20;
            this.name.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "SupplierID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Stock";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Category";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.idtxt);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.stocktxt);
            this.tabPage3.Controls.Add(this.pricetxt);
            this.tabPage3.Controls.Add(this.suptxt);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OneRowSelectWithProc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 48);
            this.button3.TabIndex = 40;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(133, 118);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 22);
            this.idtxt.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "ID";
            // 
            // stocktxt
            // 
            this.stocktxt.Location = new System.Drawing.Point(133, 162);
            this.stocktxt.Name = "stocktxt";
            this.stocktxt.ReadOnly = true;
            this.stocktxt.Size = new System.Drawing.Size(100, 22);
            this.stocktxt.TabIndex = 36;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(133, 208);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(100, 22);
            this.pricetxt.TabIndex = 35;
            // 
            // suptxt
            // 
            this.suptxt.Location = new System.Drawing.Point(133, 250);
            this.suptxt.Name = "suptxt";
            this.suptxt.ReadOnly = true;
            this.suptxt.Size = new System.Drawing.Size(100, 22);
            this.suptxt.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 255);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "SupplierID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(18, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 32;
            this.label16.Text = "Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Enter the ID of the product ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Stock";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "MultipleRowSelectProc";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 48);
            this.button4.TabIndex = 41;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(762, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormConnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Name = "FormConnected";
            this.Text = "FormConnected";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnected_FormClosing);
            this.Load += new System.EventHandler(this.FormConnected_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_id;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox sup_id;
        private System.Windows.Forms.TextBox prodname;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.TextBox st;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.TextBox sup;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb2_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox stocktxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox suptxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}