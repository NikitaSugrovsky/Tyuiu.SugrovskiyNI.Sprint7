
namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    partial class FormDoctor_4
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
            this.button_SNI_INFO_4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_SNI_INFO_4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 261);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // button_SNI_INFO_4
            // 
            this.button_SNI_INFO_4.BackColor = System.Drawing.Color.Lime;
            this.button_SNI_INFO_4.Location = new System.Drawing.Point(454, 223);
            this.button_SNI_INFO_4.Name = "button_SNI_INFO_4";
            this.button_SNI_INFO_4.Size = new System.Drawing.Size(75, 32);
            this.button_SNI_INFO_4.TabIndex = 3;
            this.button_SNI_INFO_4.Text = "OK";
            this.button_SNI_INFO_4.UseVisualStyleBackColor = false;
            this.button_SNI_INFO_4.Click += new System.EventHandler(this.button_SNI_INFO_4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(380, 196);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Сагитов Рашид Шайхуллович, \r\nАхметьянов Рафис Фагимович, Тюмень: ортопед, травмат" +
    "олог, \r\n17 отзывов пациентов, места работы, доктор наук,\r\n стаж 42 года, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources._4;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormDoctor_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 279);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDoctor_4";
            this.Text = "Информация о враче";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_SNI_INFO_4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}