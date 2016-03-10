namespace projet_Stage
{
    partial class Authentication
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.btn_Connecter = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(138, 72);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(161, 20);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(138, 111);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '●';
            this.textBox_pass.Size = new System.Drawing.Size(161, 20);
            this.textBox_pass.TabIndex = 1;
            // 
            // btn_Connecter
            // 
            this.btn_Connecter.Location = new System.Drawing.Point(138, 162);
            this.btn_Connecter.Name = "btn_Connecter";
            this.btn_Connecter.Size = new System.Drawing.Size(75, 23);
            this.btn_Connecter.TabIndex = 2;
            this.btn_Connecter.Text = "Se conn.";
            this.btn_Connecter.UseVisualStyleBackColor = true;
            this.btn_Connecter.Click += new System.EventHandler(this.btn_Connecter_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(224, 162);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuler.TabIndex = 3;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de pass :";
            // 
            // Authentication
            // 
            this.AcceptButton = this.btn_Connecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Annuler;
            this.ClientSize = new System.Drawing.Size(408, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_Connecter);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(414, 280);
            this.MinimumSize = new System.Drawing.Size(414, 280);
            this.Name = "Authentication";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button btn_Connecter;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}