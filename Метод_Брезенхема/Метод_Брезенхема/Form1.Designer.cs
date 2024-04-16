namespace Метод_Брезенхема
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(518, 27);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 22);
            this.textBoxX1.TabIndex = 0;
            this.textBoxX1.Text = "0";
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(671, 27);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 22);
            this.textBoxY1.TabIndex = 1;
            this.textBoxY1.Text = "0";
            this.textBoxY1.TextChanged += new System.EventHandler(this.textBoxY1_TextChanged);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(518, 72);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 22);
            this.textBoxX2.TabIndex = 2;
            this.textBoxX2.Text = "0";
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBoxX2_TextChanged);
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(671, 75);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 22);
            this.textBoxY2.TabIndex = 3;
            this.textBoxY2.Text = "0";
            this.textBoxY2.TextChanged += new System.EventHandler(this.textBoxY2_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(490, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(22, 16);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "X1";
            this.labelX1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(642, 30);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(23, 16);
            this.labelY1.TabIndex = 5;
            this.labelY1.Text = "Y1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(490, 75);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(22, 16);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "X2";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(642, 75);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(23, 16);
            this.labelY2.TabIndex = 7;
            this.labelY2.Text = "Y2";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(580, 121);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(105, 52);
            this.buttonColor.TabIndex = 9;
            this.buttonColor.Text = "Выбрать цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 426);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

