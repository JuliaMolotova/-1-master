namespace РосБизнесСофт
{
    partial class FormService
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelVariety = new System.Windows.Forms.Label();
            this.labelSpectrum = new System.Windows.Forms.Label();
            this.labelLevel3 = new System.Windows.Forms.Label();
            this.labelSoftware = new System.Windows.Forms.Label();
            this.listView1C = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxVariety = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewPO = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewAvt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxLevel3 = new System.Windows.Forms.TextBox();
            this.textBoxSoftware = new System.Windows.Forms.TextBox();
            this.textBoxSpectrum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAdd.Location = new System.Drawing.Point(439, 326);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 25);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEdit.Location = new System.Drawing.Point(542, 326);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 25);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDel.Location = new System.Drawing.Point(658, 326);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 25);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelVariety
            // 
            this.labelVariety.AutoSize = true;
            this.labelVariety.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelVariety.Location = new System.Drawing.Point(39, 62);
            this.labelVariety.Name = "labelVariety";
            this.labelVariety.Size = new System.Drawing.Size(63, 14);
            this.labelVariety.TabIndex = 4;
            this.labelVariety.Text = "Вид услуги";
            // 
            // labelSpectrum
            // 
            this.labelSpectrum.AutoSize = true;
            this.labelSpectrum.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSpectrum.Location = new System.Drawing.Point(187, 67);
            this.labelSpectrum.Name = "labelSpectrum";
            this.labelSpectrum.Size = new System.Drawing.Size(57, 14);
            this.labelSpectrum.TabIndex = 8;
            this.labelSpectrum.Text = "Услуги 1С";
            // 
            // labelLevel3
            // 
            this.labelLevel3.AutoSize = true;
            this.labelLevel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelLevel3.Location = new System.Drawing.Point(421, 67);
            this.labelLevel3.Name = "labelLevel3";
            this.labelLevel3.Size = new System.Drawing.Size(51, 14);
            this.labelLevel3.TabIndex = 9;
            this.labelLevel3.Text = "Уровень";
            // 
            // labelSoftware
            // 
            this.labelSoftware.AutoSize = true;
            this.labelSoftware.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelSoftware.Location = new System.Drawing.Point(304, 67);
            this.labelSoftware.Name = "labelSoftware";
            this.labelSoftware.Size = new System.Drawing.Size(44, 14);
            this.labelSoftware.TabIndex = 10;
            this.labelSoftware.Text = "Вид ПО";
            // 
            // listView1C
            // 
            this.listView1C.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1C.FullRowSelect = true;
            this.listView1C.GridLines = true;
            this.listView1C.HideSelection = false;
            this.listView1C.Location = new System.Drawing.Point(38, 154);
            this.listView1C.MultiSelect = false;
            this.listView1C.Name = "listView1C";
            this.listView1C.Size = new System.Drawing.Size(195, 129);
            this.listView1C.TabIndex = 18;
            this.listView1C.UseCompatibleStateImageBehavior = false;
            this.listView1C.View = System.Windows.Forms.View.Details;
            this.listView1C.SelectedIndexChanged += new System.EventHandler(this.listView1C_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Услуги 1С";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Цена";
            // 
            // comboBoxVariety
            // 
            this.comboBoxVariety.FormattingEnabled = true;
            this.comboBoxVariety.Items.AddRange(new object[] {
            "1С: Предприятие 8",
            "Деловое ПО",
            "Комплексаная автоматизация"});
            this.comboBoxVariety.Location = new System.Drawing.Point(25, 99);
            this.comboBoxVariety.Name = "comboBoxVariety";
            this.comboBoxVariety.Size = new System.Drawing.Size(121, 22);
            this.comboBoxVariety.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::РосБизнесСофт.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(510, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listViewPO
            // 
            this.listViewPO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listViewPO.FullRowSelect = true;
            this.listViewPO.GridLines = true;
            this.listViewPO.HideSelection = false;
            this.listViewPO.Location = new System.Drawing.Point(272, 154);
            this.listViewPO.MultiSelect = false;
            this.listViewPO.Name = "listViewPO";
            this.listViewPO.Size = new System.Drawing.Size(200, 129);
            this.listViewPO.TabIndex = 24;
            this.listViewPO.UseCompatibleStateImageBehavior = false;
            this.listViewPO.View = System.Windows.Forms.View.Details;
            this.listViewPO.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Вид ПО";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Цена";
            // 
            // listViewAvt
            // 
            this.listViewAvt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listViewAvt.FullRowSelect = true;
            this.listViewAvt.GridLines = true;
            this.listViewAvt.HideSelection = false;
            this.listViewAvt.Location = new System.Drawing.Point(510, 154);
            this.listViewAvt.MultiSelect = false;
            this.listViewAvt.Name = "listViewAvt";
            this.listViewAvt.Size = new System.Drawing.Size(184, 129);
            this.listViewAvt.TabIndex = 25;
            this.listViewAvt.UseCompatibleStateImageBehavior = false;
            this.listViewAvt.View = System.Windows.Forms.View.Details;
            this.listViewAvt.SelectedIndexChanged += new System.EventHandler(this.listViewAvt_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Уровень";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Цена";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.labelPrice.Location = new System.Drawing.Point(543, 67);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(32, 14);
            this.labelPrice.TabIndex = 26;
            this.labelPrice.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(546, 99);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 27;
            // 
            // textBoxLevel3
            // 
            this.textBoxLevel3.Location = new System.Drawing.Point(424, 99);
            this.textBoxLevel3.Name = "textBoxLevel3";
            this.textBoxLevel3.Size = new System.Drawing.Size(100, 20);
            this.textBoxLevel3.TabIndex = 28;
            // 
            // textBoxSoftware
            // 
            this.textBoxSoftware.Location = new System.Drawing.Point(307, 101);
            this.textBoxSoftware.Name = "textBoxSoftware";
            this.textBoxSoftware.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoftware.TabIndex = 29;
            // 
            // textBoxSpectrum
            // 
            this.textBoxSpectrum.Location = new System.Drawing.Point(170, 101);
            this.textBoxSpectrum.Name = "textBoxSpectrum";
            this.textBoxSpectrum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpectrum.TabIndex = 30;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(758, 363);
            this.Controls.Add(this.textBoxSpectrum);
            this.Controls.Add(this.textBoxSoftware);
            this.Controls.Add(this.textBoxLevel3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.listViewAvt);
            this.Controls.Add(this.listViewPO);
            this.Controls.Add(this.comboBoxVariety);
            this.Controls.Add(this.listView1C);
            this.Controls.Add(this.labelSoftware);
            this.Controls.Add(this.labelLevel3);
            this.Controls.Add(this.labelSpectrum);
            this.Controls.Add(this.labelVariety);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormService";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVariety;
        private System.Windows.Forms.Label labelSpectrum;
        private System.Windows.Forms.Label labelLevel3;
        private System.Windows.Forms.Label labelSoftware;
        private System.Windows.Forms.ListView listView1C;
        private System.Windows.Forms.ComboBox comboBoxVariety;
        private System.Windows.Forms.ListView listViewPO;
        private System.Windows.Forms.ListView listViewAvt;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBoxLevel3;
        private System.Windows.Forms.TextBox textBoxSoftware;
        private System.Windows.Forms.TextBox textBoxSpectrum;
    }
}