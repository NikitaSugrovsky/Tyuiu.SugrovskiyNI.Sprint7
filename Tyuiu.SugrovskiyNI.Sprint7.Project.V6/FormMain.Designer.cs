
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_SNI = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_doctor_SNI = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_doctor1_SNI = new System.Windows.Forms.Button();
            this.button_doctor_2_SNI = new System.Windows.Forms.Button();
            this.button_doctor_3_SNI = new System.Windows.Forms.Button();
            this.button_doctor_4_SNI = new System.Windows.Forms.Button();
            this.comboBox_SNI = new System.Windows.Forms.ComboBox();
            this.button_Search_SNI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxSearch_SNI = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_INFO_DOCTOR_1_SNI = new System.Windows.Forms.Button();
            this.button_updatе_SNI = new System.Windows.Forms.Button();
            this.buttonSave_1_SNI = new System.Windows.Forms.Button();
            this.buttonSave_SNI = new System.Windows.Forms.Button();
            this.buttonSave_2_SNI = new System.Windows.Forms.Button();
            this.buttonSave_4_SNI = new System.Windows.Forms.Button();
            this.buttonSave_3_SNI = new System.Windows.Forms.Button();
            this.button_Help_s_SNI = new System.Windows.Forms.Button();
            this.buttonHelp_SNI_Click = new System.Windows.Forms.Button();
            this.button_INFO_DOCTOR_2_SNI = new System.Windows.Forms.Button();
            this.button_INFO_DOCTOR_3_SNI = new System.Windows.Forms.Button();
            this.button_INFO_DOCTOR_4_SNI = new System.Windows.Forms.Button();
            this.button_INFO_DOCTOR_5_SNI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button_Help_s_SNI);
            this.panel1.Controls.Add(this.buttonHelp_SNI_Click);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 51);
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
            // dataGridView_SNI
            // 
            this.dataGridView_SNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SNI.Location = new System.Drawing.Point(456, 124);
            this.dataGridView_SNI.Name = "dataGridView_SNI";
            this.dataGridView_SNI.RowHeadersWidth = 51;
            this.dataGridView_SNI.RowTemplate.Height = 24;
            this.dataGridView_SNI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_SNI.Size = new System.Drawing.Size(888, 415);
            this.dataGridView_SNI.TabIndex = 1;
            this.dataGridView_SNI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SNI_CellContentClick);
            // 
            // button_doctor_SNI
            // 
            this.button_doctor_SNI.Location = new System.Drawing.Point(5, 136);
            this.button_doctor_SNI.Name = "button_doctor_SNI";
            this.button_doctor_SNI.Size = new System.Drawing.Size(249, 40);
            this.button_doctor_SNI.TabIndex = 2;
            this.button_doctor_SNI.Text = "Сиряк Данил Сергеевич";
            this.button_doctor_SNI.UseVisualStyleBackColor = true;
            this.button_doctor_SNI.Click += new System.EventHandler(this.button_doctor_SNI_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_doctor1_SNI
            // 
            this.button_doctor1_SNI.Location = new System.Drawing.Point(6, 50);
            this.button_doctor1_SNI.Name = "button_doctor1_SNI";
            this.button_doctor1_SNI.Size = new System.Drawing.Size(248, 40);
            this.button_doctor1_SNI.TabIndex = 4;
            this.button_doctor1_SNI.Text = "Дьяков Лаврентий Алексеевич";
            this.button_doctor1_SNI.UseVisualStyleBackColor = true;
            this.button_doctor1_SNI.Click += new System.EventHandler(this.button_doctor1_SNI_Click);
            // 
            // button_doctor_2_SNI
            // 
            this.button_doctor_2_SNI.Location = new System.Drawing.Point(5, 236);
            this.button_doctor_2_SNI.Name = "button_doctor_2_SNI";
            this.button_doctor_2_SNI.Size = new System.Drawing.Size(249, 40);
            this.button_doctor_2_SNI.TabIndex = 5;
            this.button_doctor_2_SNI.Text = "Туляков Станислав Сергеевич";
            this.button_doctor_2_SNI.UseVisualStyleBackColor = true;
            this.button_doctor_2_SNI.Click += new System.EventHandler(this.button_doctor_2_SNI_Click);
            // 
            // button_doctor_3_SNI
            // 
            this.button_doctor_3_SNI.Location = new System.Drawing.Point(6, 332);
            this.button_doctor_3_SNI.Name = "button_doctor_3_SNI";
            this.button_doctor_3_SNI.Size = new System.Drawing.Size(248, 40);
            this.button_doctor_3_SNI.TabIndex = 6;
            this.button_doctor_3_SNI.Text = "Сагитов Рашид Шайхуллович";
            this.button_doctor_3_SNI.UseVisualStyleBackColor = true;
            this.button_doctor_3_SNI.Click += new System.EventHandler(this.button_doctor_3_SNI_Click);
            // 
            // button_doctor_4_SNI
            // 
            this.button_doctor_4_SNI.Location = new System.Drawing.Point(6, 432);
            this.button_doctor_4_SNI.Name = "button_doctor_4_SNI";
            this.button_doctor_4_SNI.Size = new System.Drawing.Size(248, 40);
            this.button_doctor_4_SNI.TabIndex = 7;
            this.button_doctor_4_SNI.Text = "Некрасова Оксана Викторовна";
            this.button_doctor_4_SNI.UseVisualStyleBackColor = true;
            this.button_doctor_4_SNI.Click += new System.EventHandler(this.button_doctor_4_SNI_Click);
            // 
            // comboBox_SNI
            // 
            this.comboBox_SNI.FormattingEnabled = true;
            this.comboBox_SNI.Location = new System.Drawing.Point(712, 57);
            this.comboBox_SNI.Name = "comboBox_SNI";
            this.comboBox_SNI.Size = new System.Drawing.Size(592, 24);
            this.comboBox_SNI.TabIndex = 21;
            this.comboBox_SNI.SelectedIndexChanged += new System.EventHandler(this.comboBox_SNI_SelectedIndexChanged);
            this.comboBox_SNI.Click += new System.EventHandler(this.button_Search_SNI_Click);
            // 
            // button_Search_SNI
            // 
            this.button_Search_SNI.Location = new System.Drawing.Point(1219, 95);
            this.button_Search_SNI.Name = "button_Search_SNI";
            this.button_Search_SNI.Size = new System.Drawing.Size(75, 23);
            this.button_Search_SNI.TabIndex = 23;
            this.button_Search_SNI.Text = "Поиск";
            this.button_Search_SNI.UseVisualStyleBackColor = true;
            this.button_Search_SNI.Click += new System.EventHandler(this.button_Search_SNI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_INFO_DOCTOR_5_SNI);
            this.groupBox1.Controls.Add(this.button_INFO_DOCTOR_4_SNI);
            this.groupBox1.Controls.Add(this.button_INFO_DOCTOR_3_SNI);
            this.groupBox1.Controls.Add(this.button_INFO_DOCTOR_2_SNI);
            this.groupBox1.Controls.Add(this.button_INFO_DOCTOR_1_SNI);
            this.groupBox1.Controls.Add(this.button_updatе_SNI);
            this.groupBox1.Controls.Add(this.button_doctor1_SNI);
            this.groupBox1.Controls.Add(this.buttonSave_1_SNI);
            this.groupBox1.Controls.Add(this.button_doctor_SNI);
            this.groupBox1.Controls.Add(this.buttonSave_SNI);
            this.groupBox1.Controls.Add(this.button_doctor_2_SNI);
            this.groupBox1.Controls.Add(this.buttonSave_2_SNI);
            this.groupBox1.Controls.Add(this.buttonSave_4_SNI);
            this.groupBox1.Controls.Add(this.button_doctor_3_SNI);
            this.groupBox1.Controls.Add(this.buttonSave_3_SNI);
            this.groupBox1.Controls.Add(this.button_doctor_4_SNI);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 545);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Врачи";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // textBoxSearch_SNI
            // 
            this.textBoxSearch_SNI.Location = new System.Drawing.Point(528, 95);
            this.textBoxSearch_SNI.Name = "textBoxSearch_SNI";
            this.textBoxSearch_SNI.Size = new System.Drawing.Size(100, 22);
            this.textBoxSearch_SNI.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_INFO_DOCTOR_1_SNI
            // 
            this.button_INFO_DOCTOR_1_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.group;
            this.button_INFO_DOCTOR_1_SNI.Location = new System.Drawing.Point(310, 50);
            this.button_INFO_DOCTOR_1_SNI.Name = "button_INFO_DOCTOR_1_SNI";
            this.button_INFO_DOCTOR_1_SNI.Size = new System.Drawing.Size(50, 40);
            this.button_INFO_DOCTOR_1_SNI.TabIndex = 27;
            this.button_INFO_DOCTOR_1_SNI.UseVisualStyleBackColor = true;
            this.button_INFO_DOCTOR_1_SNI.Click += new System.EventHandler(this.button_INFO_DOCTOR_1_SNI_Click);
            // 
            // button_updatе_SNI
            // 
            this.button_updatе_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.pencil;
            this.button_updatе_SNI.Location = new System.Drawing.Point(301, 493);
            this.button_updatе_SNI.Name = "button_updatе_SNI";
            this.button_updatе_SNI.Size = new System.Drawing.Size(122, 46);
            this.button_updatе_SNI.TabIndex = 26;
            this.button_updatе_SNI.UseVisualStyleBackColor = true;
            this.button_updatе_SNI.Click += new System.EventHandler(this.button_updatе_SNI_Click);
            // 
            // buttonSave_1_SNI
            // 
            this.buttonSave_1_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.page_white_go;
            this.buttonSave_1_SNI.Location = new System.Drawing.Point(260, 50);
            this.buttonSave_1_SNI.Name = "buttonSave_1_SNI";
            this.buttonSave_1_SNI.Size = new System.Drawing.Size(44, 40);
            this.buttonSave_1_SNI.TabIndex = 11;
            this.buttonSave_1_SNI.UseVisualStyleBackColor = true;
            this.buttonSave_1_SNI.Click += new System.EventHandler(this.buttonSave_1_SNI_Click);
            // 
            // buttonSave_SNI
            // 
            this.buttonSave_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.page_white_go;
            this.buttonSave_SNI.Location = new System.Drawing.Point(260, 136);
            this.buttonSave_SNI.Name = "buttonSave_SNI";
            this.buttonSave_SNI.Size = new System.Drawing.Size(44, 40);
            this.buttonSave_SNI.TabIndex = 3;
            this.buttonSave_SNI.UseVisualStyleBackColor = true;
            this.buttonSave_SNI.Click += new System.EventHandler(this.buttonSave_SNI_Click);
            // 
            // buttonSave_2_SNI
            // 
            this.buttonSave_2_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.page_white_go;
            this.buttonSave_2_SNI.Location = new System.Drawing.Point(260, 236);
            this.buttonSave_2_SNI.Name = "buttonSave_2_SNI";
            this.buttonSave_2_SNI.Size = new System.Drawing.Size(44, 40);
            this.buttonSave_2_SNI.TabIndex = 12;
            this.buttonSave_2_SNI.UseVisualStyleBackColor = true;
            this.buttonSave_2_SNI.Click += new System.EventHandler(this.buttonSave_2_SNI_Click);
            // 
            // buttonSave_4_SNI
            // 
            this.buttonSave_4_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.page_white_go;
            this.buttonSave_4_SNI.Location = new System.Drawing.Point(260, 432);
            this.buttonSave_4_SNI.Name = "buttonSave_4_SNI";
            this.buttonSave_4_SNI.Size = new System.Drawing.Size(44, 40);
            this.buttonSave_4_SNI.TabIndex = 14;
            this.buttonSave_4_SNI.UseVisualStyleBackColor = true;
            this.buttonSave_4_SNI.Click += new System.EventHandler(this.buttonSave_4_SNI_Click);
            // 
            // buttonSave_3_SNI
            // 
            this.buttonSave_3_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.page_white_go;
            this.buttonSave_3_SNI.Location = new System.Drawing.Point(260, 332);
            this.buttonSave_3_SNI.Name = "buttonSave_3_SNI";
            this.buttonSave_3_SNI.Size = new System.Drawing.Size(44, 40);
            this.buttonSave_3_SNI.TabIndex = 13;
            this.buttonSave_3_SNI.UseVisualStyleBackColor = true;
            this.buttonSave_3_SNI.Click += new System.EventHandler(this.buttonSave_3_SNI_Click);
            // 
            // button_Help_s_SNI
            // 
            this.button_Help_s_SNI.BackColor = System.Drawing.Color.Aquamarine;
            this.button_Help_s_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.cog;
            this.button_Help_s_SNI.Location = new System.Drawing.Point(1205, 3);
            this.button_Help_s_SNI.Name = "button_Help_s_SNI";
            this.button_Help_s_SNI.Size = new System.Drawing.Size(45, 45);
            this.button_Help_s_SNI.TabIndex = 2;
            this.button_Help_s_SNI.UseVisualStyleBackColor = false;
            this.button_Help_s_SNI.Click += new System.EventHandler(this.button_Help_s_SNI_Click);
            // 
            // buttonHelp_SNI_Click
            // 
            this.buttonHelp_SNI_Click.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonHelp_SNI_Click.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonHelp_SNI_Click.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.help;
            this.buttonHelp_SNI_Click.Location = new System.Drawing.Point(1256, 3);
            this.buttonHelp_SNI_Click.Name = "buttonHelp_SNI_Click";
            this.buttonHelp_SNI_Click.Size = new System.Drawing.Size(48, 44);
            this.buttonHelp_SNI_Click.TabIndex = 1;
            this.buttonHelp_SNI_Click.UseVisualStyleBackColor = false;
            this.buttonHelp_SNI_Click.Click += new System.EventHandler(this.buttonHelp_SNI_Click_Click);
            // 
            // button_INFO_DOCTOR_2_SNI
            // 
            this.button_INFO_DOCTOR_2_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.group;
            this.button_INFO_DOCTOR_2_SNI.Location = new System.Drawing.Point(310, 136);
            this.button_INFO_DOCTOR_2_SNI.Name = "button_INFO_DOCTOR_2_SNI";
            this.button_INFO_DOCTOR_2_SNI.Size = new System.Drawing.Size(50, 40);
            this.button_INFO_DOCTOR_2_SNI.TabIndex = 28;
            this.button_INFO_DOCTOR_2_SNI.UseVisualStyleBackColor = true;
            this.button_INFO_DOCTOR_2_SNI.Click += new System.EventHandler(this.button_INFO_DOCTOR_2_SNI_Click);
            // 
            // button_INFO_DOCTOR_3_SNI
            // 
            this.button_INFO_DOCTOR_3_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.group;
            this.button_INFO_DOCTOR_3_SNI.Location = new System.Drawing.Point(310, 236);
            this.button_INFO_DOCTOR_3_SNI.Name = "button_INFO_DOCTOR_3_SNI";
            this.button_INFO_DOCTOR_3_SNI.Size = new System.Drawing.Size(50, 40);
            this.button_INFO_DOCTOR_3_SNI.TabIndex = 29;
            this.button_INFO_DOCTOR_3_SNI.UseVisualStyleBackColor = true;
            this.button_INFO_DOCTOR_3_SNI.Click += new System.EventHandler(this.button_INFO_DOCTOR_3_SNI_Click);
            // 
            // button_INFO_DOCTOR_4_SNI
            // 
            this.button_INFO_DOCTOR_4_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.group;
            this.button_INFO_DOCTOR_4_SNI.Location = new System.Drawing.Point(310, 332);
            this.button_INFO_DOCTOR_4_SNI.Name = "button_INFO_DOCTOR_4_SNI";
            this.button_INFO_DOCTOR_4_SNI.Size = new System.Drawing.Size(50, 40);
            this.button_INFO_DOCTOR_4_SNI.TabIndex = 30;
            this.button_INFO_DOCTOR_4_SNI.UseVisualStyleBackColor = true;
            this.button_INFO_DOCTOR_4_SNI.Click += new System.EventHandler(this.button_INFO_DOCTOR_4_SNI_Click);
            // 
            // button_INFO_DOCTOR_5_SNI
            // 
            this.button_INFO_DOCTOR_5_SNI.Image = global::Tyuiu.SugrovskiyNI.Sprint7.Project.V6.Properties.Resources.group;
            this.button_INFO_DOCTOR_5_SNI.Location = new System.Drawing.Point(310, 432);
            this.button_INFO_DOCTOR_5_SNI.Name = "button_INFO_DOCTOR_5_SNI";
            this.button_INFO_DOCTOR_5_SNI.Size = new System.Drawing.Size(50, 40);
            this.button_INFO_DOCTOR_5_SNI.TabIndex = 31;
            this.button_INFO_DOCTOR_5_SNI.UseVisualStyleBackColor = true;
            this.button_INFO_DOCTOR_5_SNI.Click += new System.EventHandler(this.button_INFO_DOCTOR_5_SNI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 614);
            this.Controls.Add(this.textBoxSearch_SNI);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Search_SNI);
            this.Controls.Add(this.comboBox_SNI);
            this.Controls.Add(this.dataGridView_SNI);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Справочная поликлиники ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Help_s_SNI;
        private System.Windows.Forms.Button buttonHelp_SNI_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_SNI;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_doctor_SNI;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSave_SNI;
        private System.Windows.Forms.Button buttonSave_4_SNI;
        private System.Windows.Forms.Button buttonSave_3_SNI;
        private System.Windows.Forms.Button buttonSave_2_SNI;
        private System.Windows.Forms.Button buttonSave_1_SNI;
        private System.Windows.Forms.Button button_doctor_4_SNI;
        private System.Windows.Forms.Button button_doctor_3_SNI;
        private System.Windows.Forms.Button button_doctor_2_SNI;
        private System.Windows.Forms.Button button_doctor1_SNI;
        private System.Windows.Forms.ComboBox comboBox_SNI;
        private System.Windows.Forms.Button button_Search_SNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button_updatе_SNI;
        private System.Windows.Forms.TextBox textBoxSearch_SNI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_INFO_DOCTOR_1_SNI;
        private System.Windows.Forms.Button button_INFO_DOCTOR_5_SNI;
        private System.Windows.Forms.Button button_INFO_DOCTOR_4_SNI;
        private System.Windows.Forms.Button button_INFO_DOCTOR_3_SNI;
        private System.Windows.Forms.Button button_INFO_DOCTOR_2_SNI;
    }
}

