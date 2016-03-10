namespace projet_Stage
{
    partial class DateB
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_annee = new System.Windows.Forms.ComboBox();
            this.comboBox_mois = new System.Windows.Forms.ComboBox();
            this.comboBox_jour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_annee
            // 
            this.comboBox_annee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_annee.FormattingEnabled = true;
            this.comboBox_annee.Location = new System.Drawing.Point(139, 3);
            this.comboBox_annee.Name = "comboBox_annee";
            this.comboBox_annee.Size = new System.Drawing.Size(62, 23);
            this.comboBox_annee.TabIndex = 9;
            this.comboBox_annee.Text = "Annee";
            this.comboBox_annee.SelectedIndexChanged += new System.EventHandler(this.comboBox_annee_SelectedIndexChanged);
            // 
            // comboBox_mois
            // 
            this.comboBox_mois.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_mois.FormattingEnabled = true;
            this.comboBox_mois.Items.AddRange(new object[] {
            "janvier",
            "février",
            "mars",
            "avril",
            "mai",
            "juin",
            "juillet",
            "août",
            "septembre",
            "octobre",
            "novembre",
            "décembre"});
            this.comboBox_mois.Location = new System.Drawing.Point(71, 3);
            this.comboBox_mois.Name = "comboBox_mois";
            this.comboBox_mois.Size = new System.Drawing.Size(62, 23);
            this.comboBox_mois.TabIndex = 8;
            this.comboBox_mois.Text = "Mois";
            this.comboBox_mois.SelectedIndexChanged += new System.EventHandler(this.comboBox_mois_SelectedIndexChanged);
            // 
            // comboBox_jour
            // 
            this.comboBox_jour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_jour.FormattingEnabled = true;
            this.comboBox_jour.Location = new System.Drawing.Point(3, 3);
            this.comboBox_jour.Name = "comboBox_jour";
            this.comboBox_jour.Size = new System.Drawing.Size(62, 23);
            this.comboBox_jour.TabIndex = 7;
            this.comboBox_jour.Text = "Jour";
            this.comboBox_jour.SelectedIndexChanged += new System.EventHandler(this.comboBox_jour_SelectedIndexChanged);
            // 
            // DateB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_annee);
            this.Controls.Add(this.comboBox_mois);
            this.Controls.Add(this.comboBox_jour);
            this.Name = "DateB";
            this.Size = new System.Drawing.Size(205, 29);
            this.Load += new System.EventHandler(this.DateB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_annee;
        private System.Windows.Forms.ComboBox comboBox_mois;
        private System.Windows.Forms.ComboBox comboBox_jour;
    }
}
