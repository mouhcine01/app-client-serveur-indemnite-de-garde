namespace projet_Stage
{
    partial class Service_controle
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
            this.comboBox_service = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox_service
            // 
            this.comboBox_service.FormattingEnabled = true;
            this.comboBox_service.Location = new System.Drawing.Point(3, 3);
            this.comboBox_service.Name = "comboBox_service";
            this.comboBox_service.Size = new System.Drawing.Size(195, 23);
            this.comboBox_service.TabIndex = 0;
            this.comboBox_service.SelectedIndexChanged += new System.EventHandler(this.comboBox_service_SelectedIndexChanged);
            // 
            // Service_controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_service);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Service_controle";
            this.Size = new System.Drawing.Size(201, 30);
            this.Load += new System.EventHandler(this.ServiceB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_service;
    }
}
