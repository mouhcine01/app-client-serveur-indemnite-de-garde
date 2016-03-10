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
    public partial class Compte : Form
    {
        public Compte()
        {
            InitializeComponent();
        }
        //Vider
        void Vider()
        {
            textBox_pseudo.Text = "";
            textBox_pass.Text = "";
            Service.Texte = "";
        }
        //
        //Initialiser
        void Initialiser()
        {
            groupBox.Text = "";
            btn_Valider.Text = "Valider";
            textBox_pseudo.Enabled = true;
        }
        //Timer
        static string state = "haut";
        static int cpt = 384;        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                cpt = cpt + 12;
                this.Height = cpt;
                if (cpt >= 544) { state = "bas"; timer.Stop(); }
            }
            else if (state == "bas")
            {
                cpt = cpt - 12;
                this.Height = cpt;
                if (cpt <= 384) { timer.Stop(); state = "haut"; groupBox.Visible = false; }
            }
        }
        //Button ajouter
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                timer.Start();
            }
            Initialiser();
            groupBox.Visible = true;
            groupBox.Text = "Addition d'un compte :";
            btn_Valider.Text = "Ajouter";
            textBox_pseudo.Focus();
            Vider();
        }
        //Button modifier
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            
            if (state == "haut")
            {
                timer.Start();
            }
            textBox_pseudo.Enabled = false;
            groupBox.Visible = true;
            groupBox.Text = "Modification d'un compte :";
            btn_Valider.Text = "Modifier";
            Affecter();
            textBox_pass.Focus();

        }
        //Button Valider
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            #region Ajouter
            if (btn_Valider.Text == "Ajouter")
            {
                if (textBox_pseudo.Text != "" && textBox_pass.Text != "" && Service.IdService != -1)
                {
                    try
                    {
                        //
                        MessageBox.Show("insert into Compte values('" + textBox_pseudo.Text + "','" + textBox_pass.Text + "'," + Service.IdService + ")");
                        CConnection.Connecter();
                        CConnection.DIUQuery("insert into Compte values('" + textBox_pseudo.Text + "','" + textBox_pass.Text + "'," + Service.IdService + ")");
                        CConnection.Deconnecter();
                        MessageBox.Show("Compte ajouté avec succès", "Addition validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualiser();
                        Vider();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else 
                {
                    MessageBox.Show("Tous les champs doivent être remplir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            #endregion 
                //
            #region Modifier

            else if(btn_Valider.Text=="Modifier")
            {
                if (textBox_pass.Text != "" && Service.IdService != -1)
                {
                    try
                    {
                        CConnection.Connecter();
                        CConnection.DIUQuery("update Compte set pass='" + textBox_pass.Text + "',#idService=" + Service.IdService+ " where loginn='" + textBox_pseudo.Text + "'");
                        CConnection.Deconnecter();
                        MessageBox.Show("Compte modifié !", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualiser();
                        Affecter();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else { MessageBox.Show("Tous les champs doivent être remplir", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            #endregion
        }
        //Chargement
        private void Compte_Load(object sender, EventArgs e)
        {
            Service.Largeur = 165;
            Actualiser();
        }
        void Actualiser()
        {
            dgv_Comptes.Rows.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select * from Compte");
            while (CConnection.dr.Read())
            {
                dgv_Comptes.Rows.Add(CConnection.dr[0], CConnection.dr[1], CConnection.dr[2]);
            }
            CConnection.Deconnecter();
        }

        private void dgv_Comptes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Affecter();
        }
        //Affecter
        void Affecter()
        {
            textBox_pseudo.Text = dgv_Comptes.Rows[dgv_Comptes.CurrentCell.RowIndex].Cells[0].Value.ToString();
            textBox_pass.Text = dgv_Comptes.Rows[dgv_Comptes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            Service.IdService = int.Parse(dgv_Comptes.Rows[dgv_Comptes.CurrentCell.RowIndex].Cells[2].Value.ToString());
        }
        //Supprimer
        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Comptes.Rows.Count > 0)
                {
                    int index = dgv_Comptes.CurrentCell.RowIndex;
                    string value = dgv_Comptes.Rows[index].Cells[0].Value.ToString();
                    DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer le compte selectionné dans la liste ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dr == DialogResult.Yes)
                    {
                        CConnection.Connecter();
                        CConnection.DIUQuery("delete from Compte where loginn='" + value + "'");
                        CConnection.Deconnecter();
                        Actualiser();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        //
    }
}
