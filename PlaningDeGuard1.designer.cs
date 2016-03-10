namespace projet_Stage
{
    partial class PlaningDeGuard1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaningDeGuard1));
            this.dgv_date = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_infirmier_1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_infirmier_2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_annee = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox_mois = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.btn_Valider_2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Valider_1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infirmier_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infirmier_2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_date
            // 
            this.dgv_date.AllowUserToAddRows = false;
            this.dgv_date.AllowUserToDeleteRows = false;
            this.dgv_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_date.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_date.Location = new System.Drawing.Point(54, 106);
            this.dgv_date.Name = "dgv_date";
            this.dgv_date.ReadOnly = true;
            this.dgv_date.RowTemplate.Height = 28;
            this.dgv_date.Size = new System.Drawing.Size(318, 346);
            this.dgv_date.TabIndex = 7;
            this.dgv_date.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_date_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "De 08H à 20H";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "De 20H à 08H";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // dgv_infirmier_1
            // 
            this.dgv_infirmier_1.AllowUserToAddRows = false;
            this.dgv_infirmier_1.AllowUserToDeleteRows = false;
            this.dgv_infirmier_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_infirmier_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_infirmier_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_infirmier_1.Location = new System.Drawing.Point(372, 69);
            this.dgv_infirmier_1.Name = "dgv_infirmier_1";
            this.dgv_infirmier_1.RowTemplate.Height = 28;
            this.dgv_infirmier_1.Size = new System.Drawing.Size(362, 383);
            this.dgv_infirmier_1.TabIndex = 8;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Select.";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id infirmier";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Prénom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dgv_infirmier_2
            // 
            this.dgv_infirmier_2.AllowUserToAddRows = false;
            this.dgv_infirmier_2.AllowUserToDeleteRows = false;
            this.dgv_infirmier_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_infirmier_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_infirmier_2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgv_infirmier_2.Location = new System.Drawing.Point(733, 69);
            this.dgv_infirmier_2.Name = "dgv_infirmier_2";
            this.dgv_infirmier_2.RowTemplate.Height = 28;
            this.dgv_infirmier_2.Size = new System.Drawing.Size(363, 383);
            this.dgv_infirmier_2.TabIndex = 9;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Select.";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id infirmier";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prénom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1151, 106);
            this.panel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(872, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "De 20H à 08H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "De 08H à 20H";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86188F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(319, 68);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.86188F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.13812F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(372, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 32);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1092, 176);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_annee
            // 
            this.comboBox_annee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_annee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_annee.FormattingEnabled = true;
            this.comboBox_annee.Location = new System.Drawing.Point(265, 77);
            this.comboBox_annee.Name = "comboBox_annee";
            this.comboBox_annee.Size = new System.Drawing.Size(97, 23);
            this.comboBox_annee.TabIndex = 13;
            this.comboBox_annee.SelectedIndexChanged += new System.EventHandler(this.ChangeDate);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1092, 495);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox_mois
            // 
            this.comboBox_mois.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_mois.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_mois.FormattingEnabled = true;
            this.comboBox_mois.Location = new System.Drawing.Point(116, 77);
            this.comboBox_mois.Name = "comboBox_mois";
            this.comboBox_mois.Size = new System.Drawing.Size(87, 23);
            this.comboBox_mois.TabIndex = 16;
            this.comboBox_mois.SelectedIndexChanged += new System.EventHandler(this.ChangeDate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(63, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mois :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(216, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Année :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(63, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Service :";
            // 
            // comboBox_service
            // 
            this.comboBox_service.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(116, 47);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(246, 23);
            this.comboBox_service.TabIndex = 19;
            this.comboBox_service.SelectedIndexChanged += new System.EventHandler(this.comboBox_service_SelectedIndexChanged);
            // 
            // btn_Valider_2
            // 
            this.btn_Valider_2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Valider_2.FlatAppearance.BorderSize = 0;
            this.btn_Valider_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider_2.Location = new System.Drawing.Point(902, 473);
            this.btn_Valider_2.Name = "btn_Valider_2";
            this.btn_Valider_2.Size = new System.Drawing.Size(193, 30);
            this.btn_Valider_2.TabIndex = 21;
            this.btn_Valider_2.Text = "Valider les modification";
            this.btn_Valider_2.UseVisualStyleBackColor = false;
            this.btn_Valider_2.Click += new System.EventHandler(this.btn_Valider_2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(888, 462);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(232, 60);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Valider_1
            // 
            this.btn_Valider_1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_Valider_1.FlatAppearance.BorderSize = 0;
            this.btn_Valider_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valider_1.Location = new System.Drawing.Point(541, 473);
            this.btn_Valider_1.Name = "btn_Valider_1";
            this.btn_Valider_1.Size = new System.Drawing.Size(193, 30);
            this.btn_Valider_1.TabIndex = 23;
            this.btn_Valider_1.Text = "Valider les modification";
            this.btn_Valider_1.UseVisualStyleBackColor = false;
            this.btn_Valider_1.Click += new System.EventHandler(this.btn_Valider_1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(527, 462);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(232, 60);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // PlaningDeGuard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 514);
            this.Controls.Add(this.btn_Valider_1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Valider_2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_service);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_annee);
            this.Controls.Add(this.comboBox_mois);
            this.Controls.Add(this.dgv_date);
            this.Controls.Add(this.dgv_infirmier_1);
            this.Controls.Add(this.dgv_infirmier_2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlaningDeGuard1";
            this.Text = "PlaningDeGuard1";
            this.Load += new System.EventHandler(this.PlaningDeGuard1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infirmier_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_infirmier_2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_date;
        private System.Windows.Forms.DataGridView dgv_infirmier_1;
        private System.Windows.Forms.DataGridView dgv_infirmier_2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_annee;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox_mois;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_service;
        private System.Windows.Forms.Button btn_Valider_2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_Valider_1;
        private System.Windows.Forms.PictureBox pictureBox4;

    }
}