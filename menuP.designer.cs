namespace projet_Stage
{
    partial class menuP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cahierDePresenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planingDeGardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeCongésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infirmierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cahierDePresenceToolStripMenuItem,
            this.planingDeGardeToolStripMenuItem,
            this.gestionDeCongésToolStripMenuItem,
            this.traitementToolStripMenuItem,
            this.paramétragesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cahierDePresenceToolStripMenuItem
            // 
            this.cahierDePresenceToolStripMenuItem.Name = "cahierDePresenceToolStripMenuItem";
            this.cahierDePresenceToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.cahierDePresenceToolStripMenuItem.Text = "Cahier de presence";
            this.cahierDePresenceToolStripMenuItem.Click += new System.EventHandler(this.cahierDePresenceToolStripMenuItem_Click);
            // 
            // planingDeGardeToolStripMenuItem
            // 
            this.planingDeGardeToolStripMenuItem.Name = "planingDeGardeToolStripMenuItem";
            this.planingDeGardeToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.planingDeGardeToolStripMenuItem.Text = "Planing de garde";
            this.planingDeGardeToolStripMenuItem.Click += new System.EventHandler(this.planingDeGardeToolStripMenuItem_Click);
            // 
            // gestionDeCongésToolStripMenuItem
            // 
            this.gestionDeCongésToolStripMenuItem.Name = "gestionDeCongésToolStripMenuItem";
            this.gestionDeCongésToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.gestionDeCongésToolStripMenuItem.Text = "Gestion de congés";
            this.gestionDeCongésToolStripMenuItem.Click += new System.EventHandler(this.gestionDeCongésToolStripMenuItem_Click);
            // 
            // traitementToolStripMenuItem
            // 
            this.traitementToolStripMenuItem.Name = "traitementToolStripMenuItem";
            this.traitementToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.traitementToolStripMenuItem.Text = "Traitement";
            // 
            // paramétragesToolStripMenuItem
            // 
            this.paramétragesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infirmierToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.servicesToolStripMenuItem});
            this.paramétragesToolStripMenuItem.Name = "paramétragesToolStripMenuItem";
            this.paramétragesToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.paramétragesToolStripMenuItem.Text = "Paramétrages";
            // 
            // infirmierToolStripMenuItem
            // 
            this.infirmierToolStripMenuItem.Name = "infirmierToolStripMenuItem";
            this.infirmierToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.infirmierToolStripMenuItem.Text = "Infirmiers";
            this.infirmierToolStripMenuItem.Click += new System.EventHandler(this.infirmierToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.compteToolStripMenuItem.Text = "Comptes";
            this.compteToolStripMenuItem.Click += new System.EventHandler(this.compteToolStripMenuItem_Click);
            // 
            // servicesToolStripMenuItem
            // 
            this.servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            this.servicesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.servicesToolStripMenuItem.Text = "Services";
            this.servicesToolStripMenuItem.Click += new System.EventHandler(this.servicesToolStripMenuItem_Click);
            // 
            // menuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 354);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuP";
            this.Text = "menuP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuP_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cahierDePresenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeCongésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infirmierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planingDeGardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traitementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem;
    }
}