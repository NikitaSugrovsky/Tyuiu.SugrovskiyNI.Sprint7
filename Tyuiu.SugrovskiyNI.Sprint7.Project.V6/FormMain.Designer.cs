
namespace Tyuiu.SugrovskiyNI.Sprint7.Project.V6
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHelp_SNI_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView_SNI = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonHelp_SNI_Click);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какой именно врач вас интересует";
            // 
            // buttonHelp_SNI_Click
            // 
            this.buttonHelp_SNI_Click.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonHelp_SNI_Click.Location = new System.Drawing.Point(1178, 3);
            this.buttonHelp_SNI_Click.Name = "buttonHelp_SNI_Click";
            this.buttonHelp_SNI_Click.Size = new System.Drawing.Size(126, 28);
            this.buttonHelp_SNI_Click.TabIndex = 1;
            this.buttonHelp_SNI_Click.Text = "Справка ";
            this.buttonHelp_SNI_Click.UseVisualStyleBackColor = false;
            this.buttonHelp_SNI_Click.Click += new System.EventHandler(this.buttonHelp_SNI_Click_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Location = new System.Drawing.Point(1033, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Подсказка";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView_SNI
            // 
            this.dataGridView_SNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SNI.Location = new System.Drawing.Point(681, 65);
            this.dataGridView_SNI.Name = "dataGridView_SNI";
            this.dataGridView_SNI.RowHeadersWidth = 51;
            this.dataGridView_SNI.RowTemplate.Height = 24;
            this.dataGridView_SNI.Size = new System.Drawing.Size(613, 445);
            this.dataGridView_SNI.TabIndex = 1;
            this.dataGridView_SNI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SNI_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сиряк Данил Сергеевич";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 614);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView_SNI);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Справочная поликлиники ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHelp_SNI_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_SNI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

