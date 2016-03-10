using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Stage
{
    public partial class Infirmier : Form
    {
        public Infirmier()
        {
            InitializeComponent();
        }

        private void textBox_IdService_TextChanged(object sender, EventArgs e)
        {
            if (textBox_nom.Text != "")
            {
                label_nom.Visible = false;
            }
            else { label_nom.Visible = true; }
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id.Text != "")
            {
                label_id.Visible = false;
            }
            else { label_id.Visible = true; }
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            if (textBox_prenom.Text != "")
            {
                label_prenom.Visible = false;
            }
            else { label_prenom.Visible = true; }
        }

        private void Infirmier_Load(object sender, EventArgs e)
        {
            Service.Largeur = 232;
            Actualiser();
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (this.state == "haut")
            {
                timer.Start();
            }
            Vider();
            groupBox.Text = "Addition d'un infirmier";         
            groupBox.Visible = true;
            btn_Valider.Text = "Ajouter";
            label_id.Visible = true;
            textBox_Id.Enabled = true;
            textBox_Id.Focus();
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                timer.Start();
            }
            Vider();
            groupBox.Text = "Modification d'un infirmier";
            groupBox.Visible = true;
            btn_Valider.Text = "Modifier";
            textBox_nom.Focus();
            textBox_Id.Enabled = false;
            label_id.Visible = false;
            Affecter();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if ( textBox_Id.Text != "" && textBox_nom.Text != "" && textBox_prenom.Text != "" && dateN.DateSQL !=""  && textBox_supervis.Text != "" && textBox_email.Text != "" && comboBox_sexe.Text != "Selectionnez ..." && comboBox_sexe.Text != "" && textBox_tel.Text != "" && textBox_adresse.Text != "" && Service.IdService != -1)
                {
                    if (btn_Valider.Text == "Ajouter")
                    {
                        string rqte = "insert into Infirmier values(" + textBox_Id.Text + ",'" + textBox_nom.Text + "','" + textBox_prenom.Text + "','" + dateN.DateSQL + "'," + textBox_supervis.Text + ",'" + textBox_email.Text + "','" + comboBox_sexe.Text + "','" + textBox_tel.Text + "','" + textBox_adresse.Text + "'," + Service.IdService + ")";
                        CConnection.Connecter();
                        CConnection.DIUQuery(rqte);
                        CConnection.Deconnecter();
                        MessageBox.Show("Infirmier ajouté à la liste des infirmier", "Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualiser();
                        Vider();
                    }
                    else
                    {
                        string rqte = "update Infirmier set nom='" + textBox_nom.Text + "',prenom='" + textBox_prenom.Text + "',dateNaiss='" + dateN.DateSQL + "',superviseur=" + textBox_supervis.Text + ",email='" + textBox_email.Text + "',sexe='" + comboBox_sexe.Text + "',tel='" + textBox_tel.Text + "',adresse='" + textBox_adresse.Text + "',#idService=" + Service.IdService + " where idInfirmier=" + textBox_Id.Text + "";
                        CConnection.Connecter();
                        CConnection.DIUQuery(rqte);
                        CConnection.Deconnecter();
                        MessageBox.Show("Infirmier modifié", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Actualiser();
                        Affecter();
                    }
                }
                else 
                {
                    MessageBox.Show("Remplissage de tous les champs obligatoire", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgv_Infirmiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btn_Valider.Text == "Modifier")
            {
                Affecter();
            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
                {
                    if (dgv.Rows.Count > 0)
                    {
                        int index = dgv.CurrentCell.RowIndex;
                        string value = dgv.Rows[index].Cells[0].Value.ToString();
                        DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer le service selectionné dans list des services ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (dr == DialogResult.Yes)
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("delete from Infirmier where idInfirmier=" + value + "");
                            CConnection.Deconnecter();
                            MessageBox.Show("Suppression validé !", "Suppression");
                            Actualiser();
                        }
                    }
                }
                catch  
                {
                    int index = dgv.CurrentCell.RowIndex;
                    MessageBox.Show("L'infimier " + dgv.Rows[index].Cells[1].Value.ToString() + " considéré comme chef des infirmier ,si vous voulez le supprimer de la liste vous pouvez dabord supprimer tous les infirmier dont le N° de service " + dgv.Rows[index].Cells[9].Value.ToString() + " et réessayez", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

        }

        #region Timer
        //Timer
        string state = "haut";
        int cpt = 635;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                cpt = cpt + 20;
                this.Width = cpt;
                if (cpt >= 913) { state = "bas"; timer.Stop(); }
            }
            else if (state == "bas")
            {
                cpt = cpt - 20;
                this.Width = cpt;
                if (cpt <= 635)
                {
                    timer.Stop(); state = "haut";
                    groupBox.Visible = false;
                }
            }
        }
        #endregion

        
        //Affecter
        void Affecter()
        {
            int i = dgv.CurrentRow.Index;
            textBox_Id.Text = dgv.Rows[i].Cells[0].Value.ToString();
            textBox_nom.Text = dgv.Rows[i].Cells[1].Value.ToString();
            textBox_prenom.Text = dgv.Rows[i].Cells[2].Value.ToString();
            //Date
            dateN.Jour= int.Parse(dgv.Rows[i].Cells[3].Value.ToString().Substring(0, 2));
            dateN.Mois= int.Parse(dgv.Rows[i].Cells[3].Value.ToString().Substring(3, 2));
            dateN.Annee=int.Parse(dgv.Rows[i].Cells[3].Value.ToString().Substring(6, 4));
            //
            textBox_supervis.Text = dgv.Rows[i].Cells[4].Value.ToString();
            textBox_email.Text = dgv.Rows[i].Cells[5].Value.ToString();
            comboBox_sexe.Text = dgv.Rows[i].Cells[6].Value.ToString();
            textBox_tel.Text = dgv.Rows[i].Cells[7].Value.ToString();
            textBox_adresse.Text = dgv.Rows[i].Cells[8].Value.ToString();
            Service.IdService = int.Parse(dgv.Rows[i].Cells[9].Value.ToString());
        }
        
        //Actualiser
        void Actualiser()
        {
            dgv.Rows.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select * from Infirmier");
            while (CConnection.dr.Read())
            {
                dgv.Rows.Add(CConnection.dr[0], CConnection.dr[1], CConnection.dr[2], CConnection.dr[3], CConnection.dr[4], CConnection.dr[5], CConnection.dr[6], CConnection.dr[7], CConnection.dr[8], CConnection.dr[9]);
            }
            CConnection.Deconnecter();
        }
        
        //Vider
        void Vider()
        {
            textBox_Id.Text = "";
            textBox_nom.Text = "";
            textBox_prenom.Text = "";
            textBox_email.Text = "";
            dateN.Reinitialiser();
            textBox_tel.Text = "";
            textBox_adresse.Text = "";
            textBox_supervis.Text = "";
            textBox_Id.Focus();
        }
        
        //Initialiser
        void Initialiser()
        {
            btn_Valider.Text = "Valider";
            groupBox.Visible = false;
            groupBox.Text = "";
            label_id.Visible = true;
            textBox_Id.Enabled = true;
        }
    }
}
