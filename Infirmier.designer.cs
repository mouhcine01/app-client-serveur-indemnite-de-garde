namespace projet_Stage
{
    partial class Infirmier
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
            this.Service = new projet_Stage.Service_controle();
            this.dateN = new projet_Stage.DateB();
            this.comboBox_sexe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_supervis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_prenom = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Supprimer.Location = new System.Drawing.Point(316, 524);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(133, 27);
            this.btn_Supprimer.TabIndex = 19;
            this.btn_Supprimer.Text = "Supprimer infirmier";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Modifier.Location = new System.Drawing.Point(171, 524);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(133, 27);
            this.btn_Modifier.TabIndex = 18;
            this.btn_Modifier.Text = "Modifier infirmier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Ajouter.Location = new System.Drawing.Point(25, 524);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(133, 27);
            this.btn_Ajouter.TabIndex = 17;
            this.btn_Ajouter.Text = "Ajouter infirmier";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Service);
            this.groupBox.Controls.Add(this.dateN);
            this.groupBox.Controls.Add(this.comboBox_sexe);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label19);
            this.groupBox.Controls.Add(this.textBox_adresse);
            this.groupBox.Controls.Add(this.textBox_tel);
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.label_id);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.textBox_Id);
            this.groupBox.Controls.Add(this.textBox_supervis);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.textBox_email);
            this.groupBox.Controls.Add(this.label_prenom);
            this.groupBox.Controls.Add(this.textBox_prenom);
            this.groupBox.Controls.Add(this.label_nom);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBox_nom);
            this.groupBox.Controls.Add(this.btn_Valider);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox.Location = new System.Drawing.Point(631, 24);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(263, 527);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Visible = false;
            // 
            // Service
            // 
            this.Service.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.IdService = -1;
            this.Service.Location = new System.Drawing.Point(19, 455);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(238, 30);
            this.Service.TabIndex = 20;
            this.Service.Texte = "";
            // 
            // dateN
            // 
            this.dateN.Annee = -1;
            this.dateN.Jour = -1;
            this.dateN.Location = new System.Drawing.Point(19, 187);
            this.dateN.Mois = -1;
            this.dateN.Name = "dateN";
            this.dateN.Size = new System.Drawing.Size(238, 29);
            this.dateN.TabIndex = 62;
            // 
            // comboBox_sexe
            // 
            this.comboBox_sexe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_sexe.FormattingEnabled = true;
            this.comboBox_sexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.comboBox_sexe.Location = new System.Drawing.Point(22, 358);
            this.comboBox_sexe.Name = "comboBox_sexe";
            this.comboBox_sexe.Size = new System.Drawing.Size(232, 23);
            this.comboBox_sexe.TabIndex = 58;
            this.comboBox_sexe.Text = "Selectionnez ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "Sexe :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 269);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 15);
            this.label19.TabIndex = 57;
            this.label19.Text = "Adresse :";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adresse.Location = new System.Drawing.Point(21, 288);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(233, 44);
            this.textBox_adresse.TabIndex = 8;
            // 
            // textBox_tel
            // 
            this.textBox_tel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tel.Location = new System.Drawing.Point(22, 239);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(232, 23);
            this.textBox_tel.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 52;
            this.label16.Text = "Telephone :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 437);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "Service :";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.BackColor = System.Drawing.Color.White;
            this.label_id.Enabled = false;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_id.Location = new System.Drawing.Point(26, 47);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(47, 15);
            this.label_id.TabIndex = 48;
            this.label_id.Text = "Identité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Id infirmier :";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Id.Location = new System.Drawing.Point(21, 43);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(233, 23);
            this.textBox_Id.TabIndex = 0;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // textBox_supervis
            // 
            this.textBox_supervis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_supervis.Location = new System.Drawing.Point(22, 407);
            this.textBox_supervis.Name = "textBox_supervis";
            this.textBox_supervis.Size = new System.Drawing.Size(232, 23);
            this.textBox_supervis.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 388);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Id de superviseur :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 32;
            this.label14.Text = "Date de naissance :";
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(21, 141);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(233, 23);
            this.textBox_email.TabIndex = 3;
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.BackColor = System.Drawing.Color.White;
            this.label_prenom.Enabled = false;
            this.label_prenom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prenom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_prenom.Location = new System.Drawing.Point(153, 95);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(49, 15);
            this.label_prenom.TabIndex = 27;
            this.label_prenom.Text = "Prénom";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_prenom.Location = new System.Drawing.Point(146, 92);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(108, 23);
            this.textBox_prenom.TabIndex = 2;
            this.textBox_prenom.TextChanged += new System.EventHandler(this.textBox_prenom_TextChanged);
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.BackColor = System.Drawing.Color.White;
            this.label_nom.Enabled = false;
            this.label_nom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_nom.Location = new System.Drawing.Point(26, 95);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(34, 15);
            this.label_nom.TabIndex = 25;
            this.label_nom.Text = "Nom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Email : (Valide)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nom.Location = new System.Drawing.Point(21, 92);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(122, 23);
            this.textBox_nom.TabIndex = 1;
            this.textBox_nom.TextChanged += new System.EventHandler(this.textBox_IdService_TextChanged);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(165, 491);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(89, 27);
            this.btn_Valider.TabIndex = 11;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "List des infirmiers :";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column6});
            this.dgv.Location = new System.Drawing.Point(25, 47);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(578, 462);
            this.dgv.TabIndex = 14;
            this.dgv.TabStop = false;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Infirmiers_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id infirmier";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prénom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date naissance";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Superviseur";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Sexe";
            this.Column7.MinimumWidth = 60;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Telephone";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Adresse";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id service";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 75;
            // 
            // timer
            // 
            this.timer.Interval = 2;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Infirmier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 562);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Infirmier";
            this.Text = "Infirmier";
            this.Load += new System.EventHandler(this.Infirmier_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_supervis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox comboBox_sexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label12;
        private DateB dateN;
        private Service_controle Service;
    }
}