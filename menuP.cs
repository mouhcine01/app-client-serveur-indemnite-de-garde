using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Stage
{
    public partial class menuP : Form
    {
        public menuP()
        {
            InitializeComponent();
        }

        private void menuP_Load(object sender, EventArgs e)
        {
            Authentication frm = new Authentication();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (Authentication.Auth == false)
            {
                this.Close();
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Service frm = new Service();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void gestionDeCongésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conge frm = new Conge();
            frm.ShowDialog();
        }

        private void cahierDePresenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion_Absence frm = new Gestion_Absence();
            frm.ShowDialog();
        }

        private void infirmierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Infirmier frm = new Infirmier();
            frm.ShowDialog();
        }

        private void compteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compte frm = new Compte();
            frm.Show();
        }

        private void planingDeGardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaningDeGuard1 frm = new PlaningDeGuard1();
            frm.ShowDialog();
        }
    }
}
