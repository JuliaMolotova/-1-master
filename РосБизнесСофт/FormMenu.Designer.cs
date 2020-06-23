namespace РосБизнесСофт
{
    partial class FormMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonConsultation = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonClients.Location = new System.Drawing.Point(12, 87);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(312, 62);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonAgents.Location = new System.Drawing.Point(12, 156);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(312, 62);
            this.buttonAgents.TabIndex = 2;
            this.buttonAgents.Text = "Сотрудники";
            this.buttonAgents.UseVisualStyleBackColor = false;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonService.Location = new System.Drawing.Point(12, 225);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(312, 62);
            this.buttonService.TabIndex = 3;
            this.buttonService.Text = "Услуги";
            this.buttonService.UseVisualStyleBackColor = false;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonOrders.Location = new System.Drawing.Point(12, 294);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(312, 62);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Сделки";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonConsultation
            // 
            this.buttonConsultation.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonConsultation.Location = new System.Drawing.Point(12, 363);
            this.buttonConsultation.Name = "buttonConsultation";
            this.buttonConsultation.Size = new System.Drawing.Size(312, 62);
            this.buttonConsultation.TabIndex = 5;
            this.buttonConsultation.Text = "Связаться";
            this.buttonConsultation.UseVisualStyleBackColor = false;
            this.buttonConsultation.Click += new System.EventHandler(this.buttonConsultation_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonInformation.Location = new System.Drawing.Point(12, 432);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(312, 62);
            this.buttonInformation.TabIndex = 6;
            this.buttonInformation.Text = "Информация";
            this.buttonInformation.UseVisualStyleBackColor = false;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::РосБизнесСофт.Properties.Resources._201701151112201369185589;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(336, 507);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonConsultation);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormMenu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonConsultation;
        private System.Windows.Forms.Button buttonInformation;
    }
}

