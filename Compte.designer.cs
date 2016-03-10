namespace projet_Stage
{
    partial class Compte
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
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pseudo = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Comptes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Service = new projet_Stage.Service_controle();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comptes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Supprimer.Location = new System.Drawing.Point(315, 311);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(133, 27);
            this.btn_Supprimer.TabIndex = 19;
            this.btn_Supprimer.Text = "Supprimer un compte";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modifier.Location = new System.Drawing.Point(170, 311);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(133, 27);
            this.btn_Modifier.TabIndex = 18;
            this.btn_Modifier.Text = "Modifier un compte";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Ajouter.Location = new System.Drawing.Point(25, 311);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(133, 27);
            this.btn_Ajouter.TabIndex = 17;
            this.btn_Ajouter.Text = "Ajouter un compte";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Service);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBox_pseudo);
            this.groupBox.Controls.Add(this.btn_Valider);
            this.groupBox.Controls.Add(this.textBox_pass);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Location = new System.Drawing.Point(25, 352);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(423, 148);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Service :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo :";
            // 
            // textBox_pseudo
            // 
            this.textBox_pseudo.Location = new System.Drawing.Point(117, 32);
            this.textBox_pseudo.Name = "textBox_pseudo";
            this.textBox_pseudo.Size = new System.Drawing.Size(165, 23);
            this.textBox_pseudo.TabIndex = 1;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(328, 113);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(89, 27);
            this.btn_Valider.TabIndex = 8;
            this.btn_Valider.Text = "Valider l\'ajout";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(117, 75);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(165, 23);
            this.textBox_pass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de pass :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "List des comptes :";
            // 
            // dgv_Comptes
            // 
            this.dgv_Comptes.AllowUserToAddRows = false;
            this.dgv_Comptes.AllowUserToDeleteRows = false;
            this.dgv_Comptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Comptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Comptes.Location = new System.Drawing.Point(25, 48);
            this.dgv_Comptes.Name = "dgv_Comptes";
            this.dgv_Comptes.ReadOnly = true;
            this.dgv_Comptes.Size = new System.Drawing.Size(423, 241);
            this.dgv_Comptes.TabIndex = 14;
            this.dgv_Comptes.TabStop = false;
            this.dgv_Comptes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Comptes_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pseudo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 160;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mot de pass";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Id service";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Service
            // 
            this.Service.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.IdService = -1;
            this.Service.Location = new System.Drawing.Point(114, 112);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(208, 30);
            this.Service.TabIndex = 12;
            // 
            // Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 356);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_Comptes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Compte";
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Compte_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comptes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Comptes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox_pseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Service_controle Service;

    }
}