
namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    partial class FormDoctor_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_SNI_INFO_1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SNI_INFO_1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 196);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Дьяков Лаврентий Алексеевич, Тюмень: врач узи, малоинвазивный хирург, \r\nсосудисты" +
    "й хирург, флеболог, 28 отзывов пациентов, места работы, высшая категория, \r\nстаж" +
    " 20 лет";
            // 
            // button_SNI_INFO_1
            // 
            this.button_SNI_INFO_1.BackColor = System.Drawing.Color.Lime;
            this.button_SNI_INFO_1.Location = new System.Drawing.Point(454, 223);
            this.button_SNI_INFO_1.Name = "button_SNI_INFO_1";
            this.button_SNI_INFO_1.Size = new System.Drawing.Size(75, 32);
            this.button_SNI_INFO_1.TabIndex = 3;
            this.button_SNI_INFO_1.Text = "OK";
            this.button_SNI_INFO_1.UseVisualStyleBackColor = false;
            this.button_SNI_INFO_1.Click += new System.EventHandler(this.button_SNI_INFO_1_Click);
            // 
            // FormDoctor_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 285);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoctor_1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_SNI_INFO_1;
        private System.Windows.Forms.TextBox textBox1;
    }
}