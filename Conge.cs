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
    public partial class Conge : Form
    {
        public Conge()
        {
            InitializeComponent();
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id_infirmier_1.Text != "")
            {
                label_id.Visible = false;
            }
            else { label_id.Visible = true; }
        }

        private void Conge_Load(object sender, EventArgs e)
        {
            Service.Largeur = 123;
            comboBox_nbr_jour.Items.Clear();
            for (int i = 1; i <= 22; i++)
            {
                comboBox_nbr_jour.Items.Add(i);
            }
        }

        private void btn_add_delete_conge_Click(object sender, EventArgs e)
        {
            timer.Start();
            
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            if (textBox_Id_infirmier_1.Text != "" || textBox_nom.Text != "" || textBox_prenom.Text != "" || (comboBox_sexe.Text != "Selectionnez ..." && comboBox_sexe.Text != "") || Service.Texte!="")
            {
                int cpt = 0;
                string rqteP = "select idInfirmier,nom,prenom,#idService,sexe from Infirmier where ";
                if (textBox_Id_infirmier_1.Text != "")
                {
                    cpt = cpt + 1;
                    if (cpt == 1) { rqteP = rqteP + "idInfirmier =" + textBox_Id_infirmier_1.Text; }
                    else { rqteP = rqteP + " and idInfirmier =" + textBox_Id_infirmier_1.Text; }
                }
                if (textBox_nom.Text != "")
                {
                    cpt = cpt + 1;
                    if (cpt == 1) { rqteP = rqteP + "nom ='" + textBox_nom.Text + "'"; }
                    else { rqteP = rqteP + " and nom =" + textBox_nom.Text; }
                }
                if (textBox_prenom.Text != "")
                {
                    cpt = cpt + 1;
                    if (cpt == 1) { rqteP = rqteP + " prenom ='" + textBox_prenom.Text +"'"; }
                    else { rqteP = rqteP + " and prenom ='" + textBox_prenom.Text+"'"; }
                }
                if (comboBox_sexe.Text != "" && comboBox_sexe.Text != "Selectionnez ...")
                {
                    cpt = cpt + 1;
                    if (cpt == 1) { rqteP = rqteP + " sexe ='" + comboBox_sexe.Text+"'"; }
                    else { rqteP = rqteP + " and sexe ='" + comboBox_sexe.Text+"'"; }
                }
                if (Service.IdService != -1)
                {
                    cpt = cpt + 1;
                    if (cpt == 1) { rqteP = rqteP + " #idService ='" + Service.IdService  + "'"; }
                    else { rqteP = rqteP + " and #idService ='" + Service.IdService + "'"; }
                }
                dgv_Infirmiers.Rows.Clear();
                CConnection.Connecter();
                CConnection.SQuery(rqteP);
                while (CConnection.dr.Read())
                {
                    dgv_Infirmiers.Rows.Add(CConnection.dr[0].ToString(),CConnection.dr[1].ToString(),CConnection.dr[2].ToString(),CConnection.dr[3].ToString(),CConnection.dr[4].ToString());
                }
                CConnection.Deconnecter();
                
            }
            else 
            {
                MessageBox.Show("Il faut remplir au moins un champs", "Avertissement", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            if (textBox_nom.Text != "")
            {label_nom.Visible = false; }
            else { label_nom.Visible = true; }
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            if (textBox_prenom.Text != "")
            { label_prenom.Visible = false; }
            else { label_prenom.Visible = true; }
        }

        private void textBox_Id_infirmier_1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id_infirmier_1.Text != "")
            {label_id.Visible = false; }
            else { label_id.Visible = true; }
        }
        
        private void dgv_Infirmiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Infirmiers.Rows.Count > 0)
            {
                if (button == "modifier") 
                {
                    string idInf = dgv_Infirmiers.Rows[dgv_Infirmiers.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (state == "haut") { timer.Start(); }
                    textBox_id_infirmier_2.Text = idInf;
                    ActualiserListeConge(idInf);
                    Affecter();
                }
                else if (button == "ajouter")
                {
                    string idInf = dgv_Infirmiers.Rows[dgv_Infirmiers.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    if (state == "haut") { timer.Start(); }
                    textBox_id_infirmier_2.Text = idInf;
                    ActualiserListeConge(idInf);
                }
                
            }

        }
        /////
        #region Timer
        //Timer
        string state = "haut";
        int cpt = 480;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                cpt = cpt + 14;
                this.Width = cpt;
                if (cpt >= 930) { state = "bas"; timer.Stop(); }
            }
            else if (state == "bas")
            {
                cpt = cpt - 10;
                this.Width = cpt;
                if (cpt <= 480)
                {
                    timer.Stop(); state = "haut";
                }
            }
        }
        #endregion
        //
        #region Ajouter Modifier

        string button = "";  /**/

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (dgv_Infirmiers.Rows.Count > 0)
            {
                button = "ajouter";
                string idInf = dgv_Infirmiers.Rows[dgv_Infirmiers.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (state == "haut") { timer.Start(); pictureBox10.Visible = true; pictureBox11.Visible = false; pictureBox12.Visible = false; }
                textBox_id_infirmier_2.Text = idInf;
                ActualiserListeConge(idInf);
                dateDep.Reinitialiser();
                btn_Valider.Text = "Ajouter";
            }
            else 
            {
                MessageBox.Show("Veuillez sélectionner au moins un infirmier\n dans la liste des infirmiers .", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (dgv_Infirmiers.Rows.Count > 0)
            {
                button = "modifier";
                string idInf = dgv_Infirmiers.Rows[dgv_Infirmiers.CurrentCell.RowIndex].Cells[0].Value.ToString();
                if (state == "haut") { timer.Start(); pictureBox10.Visible = true; pictureBox11.Visible = false; pictureBox12.Visible = false; }
                textBox_id_infirmier_2.Text = idInf;
                ActualiserListeConge(idInf);
                Affecter();
                btn_Valider.Text="Modifier";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner au moins un infirmier\n dans la liste des infirmiers .", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion
        //
        void ActualiserListeConge(string idinfirmier)
        {
            dgv_conge.Rows.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select *  from Conge where #idInfirmier="+idinfirmier+"");
            while (CConnection.dr.Read())
            {
                dgv_conge.Rows.Add(false, CConnection.dr[0], CConnection.dr[1], CConnection.dr[2], CConnection.dr[3]);
            }
            CConnection.Deconnecter();
            if (dgv_conge.Rows.Count <= 0) { dateDep.Reinitialiser(); comboBox_nbr_jour.Text = ""; }
        }

        private void dgv_conge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_conge.Rows.Count > 0 && button=="modifier")
            {
                Affecter();
            }
        }
        void Affecter()
        {
            if (dgv_conge.Rows.Count > 0)
            {
                int i = dgv_conge.CurrentRow.Index;
                dateDep.Jour = int.Parse(dgv_conge.Rows[i].Cells[2].Value.ToString().Substring(0, 2));
                dateDep.Mois = int.Parse(dgv_conge.Rows[i].Cells[2].Value.ToString().Substring(3, 2));
                dateDep.Annee = int.Parse(dgv_conge.Rows[i].Cells[2].Value.ToString().Substring(6, 4));
                comboBox_nbr_jour.Text = dgv_conge.Rows[i].Cells[3].Value.ToString();
            }
        }
        void Vider()
        {
            dateDep.Reinitialiser();
            comboBox_nbr_jour.Text = "";
        }

  

        private void btn_supprimer_conge_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_conge.Rows.Count > 0) 
                {
                    int cpt = 0;
                    DialogResult dr = MessageBox.Show("Vous voulez vraiment supprimer les éléments sélectionné \ndans la liste ?", "Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {

                        for (int i = 0; i <= dgv_conge.Rows.Count - 1; i++)
                        {
                            if ((bool)dgv_conge.Rows[i].Cells[0].Value == true)
                            {
                                CConnection.Connecter();
                                CConnection.DIUQuery("delete from Conge where idConge=" + dgv_conge.Rows[i].Cells[1].Value.ToString() + "");
                                CConnection.Deconnecter();
                                cpt = cpt + 1;
                            }
                        }
                    }
                    if (cpt>0)
                    {
                        MessageBox.Show(cpt+" élement(s) supprimé(s) de la liste .", "Supression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualiserListeConge(textBox_id_infirmier_2.Text);
                    }
                    else if (dr == DialogResult.No) { }
                    else { MessageBox.Show("Veuiller cocher au moins un enregistrement a supprimer\ndans la liste pour effectuer cette operation ", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Valider.Text == "Ajouter")
                {
                    if (dateDep.DateSQL != "" && comboBox_nbr_jour.Text != "")
                    {
                        CConnection.Connecter();
                        CConnection.DIUQuery("insert into conge values('" + dateDep.DateSQL + "',"+comboBox_nbr_jour.Text+","+textBox_id_infirmier_2.Text+")");
                        CConnection.Deconnecter();
                         ActualiserListeConge(textBox_id_infirmier_2.Text);
                         MessageBox.Show("Addition du congé validé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("il faut remplir tous les champs associés au congé\n ( Date de départ . Nombres de jours )", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (btn_Valider.Text == "Modifier")
                {
                    if (dateDep.DateSQL != "" && comboBox_nbr_jour.Text != "")
                    {
                        string idConge = dgv_conge.Rows[dgv_conge.CurrentRow.Index].Cells[1].Value.ToString();
                        CConnection.Connecter();
                        CConnection.DIUQuery("update Conge set dateDepart='" + dateDep.DateSQL + "',nbrJours=" + comboBox_nbr_jour.Text + " ,#idInfirmier=" + textBox_id_infirmier_2.Text + " where idConge=" + idConge + "");
                        CConnection.Deconnecter();
                        MessageBox.Show("Modification du congé validé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualiserListeConge(textBox_id_infirmier_2.Text);
                    }
                    else
                    {
                        MessageBox.Show("il faut remplir tous les champs associés au congé\n ( Date de départ · Nombres de jours )", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
