namespace projet_Stage
{
    partial class Service
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IdService = new System.Windows.Forms.TextBox();
            this.textBox_NomService = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Serivices = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Serivices)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id service :";
            // 
            // textBox_IdService
            // 
            this.textBox_IdService.Location = new System.Drawing.Point(117, 32);
            this.textBox_IdService.Name = "textBox_IdService";
            this.textBox_IdService.Size = new System.Drawing.Size(165, 23);
            this.textBox_IdService.TabIndex = 1;
            // 
            // textBox_NomService
            // 
            this.textBox_NomService.Location = new System.Drawing.Point(117, 75);
            this.textBox_NomService.Name = "textBox_NomService";
            this.textBox_NomService.Size = new System.Drawing.Size(165, 23);
            this.textBox_NomService.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom service :";
            // 
            // dgv_Serivices
            // 
            this.dgv_Serivices.AllowUserToAddRows = false;
            this.dgv_Serivices.AllowUserToDeleteRows = false;
            this.dgv_Serivices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Serivices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_Serivices.Location = new System.Drawing.Point(43, 59);
            this.dgv_Serivices.Name = "dgv_Serivices";
            this.dgv_Serivices.ReadOnly = true;
            this.dgv_Serivices.Size = new System.Drawing.Size(423, 278);
            this.dgv_Serivices.TabIndex = 4;
            this.dgv_Serivices.TabStop = false;
            this.dgv_Serivices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Serivices_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id service :";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom service";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 260;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "List services :";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(328, 74);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(89, 27);
            this.btn_Valider.TabIndex = 8;
            this.btn_Valider.Text = "Valider l\'ajout";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBox_IdService);
            this.groupBox.Controls.Add(this.btn_Valider);
            this.groupBox.Controls.Add(this.textBox_NomService);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(43, 385);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(423, 107);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Visible = false;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Ajouter.Location = new System.Drawing.Point(43, 352);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(133, 27);
            this.btn_Ajouter.TabIndex = 11;
            this.btn_Ajouter.Text = "Ajouter service";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modifier.Location = new System.Drawing.Point(189, 352);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(133, 27);
            this.btn_Modifier.TabIndex = 12;
            this.btn_Modifier.Text = "Modifier service";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Supprimer.Location = new System.Drawing.Point(333, 352);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(133, 27);
            this.btn_Supprimer.TabIndex = 13;
            this.btn_Supprimer.Text = "Supprimer service";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 408);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Serivices);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Service";
            this.Text = "Service";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Service_FormClosed);
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Serivices)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IdService;
        private System.Windows.Forms.TextBox textBox_NomService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Serivices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}