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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        void Actualiser()
        {
            dgv_Serivices.Rows.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select * from Servicee");
            while (CConnection.dr.Read())
            {
                dgv_Serivices.Rows.Add(CConnection.dr[0].ToString(), CConnection.dr[1].ToString());
            }
            CConnection.Deconnecter();
        }
        private void Service_Load(object sender, EventArgs e)
        {
            Actualiser();
        }
        //Timer
        static string state = "haut";
        static int cpt = 436;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                cpt = cpt + 7;
                this.Height = cpt;
                if (cpt >= 541) { state = "bas"; timer.Stop(); }
            }
            else if (state == "bas")
            {
                cpt = cpt - 9;
                this.Height = cpt;
                if (cpt <= 436) 
                { 
                    timer.Stop(); state = "haut"; 
                    groupBox.Visible = false;
                    Initialiser();
                }
            }
        }
        //Button Ajouter
        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                timer.Start();
            }
            groupBox.Visible = true;
            groupBox.Text = "Addition d'un service :";
            btn_Valider.Text = "Ajouter";
            textBox_IdService.Enabled=true;
            Vider();
            textBox_IdService.Focus();
        }
        //Button Modifier
        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            if (state == "haut")
            {
                timer.Start();
            }
            textBox_IdService.Enabled = false;
            groupBox.Visible = true;
            groupBox.Text = "Modification d'un service :";
            btn_Valider.Text = "Modifier";
            textBox_NomService.Focus();
            Affecter();
        }
        //Button Valider
        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (btn_Valider.Text == "Ajouter")
            {
                try
                {
                    CConnection.Connecter();
                    CConnection.DIUQuery("insert into Servicee values(" + textBox_IdService.Text + ",'" + textBox_NomService.Text + "')");
                    CConnection.Deconnecter();
                    Actualiser();
                    MessageBox.Show("Service ajouté avec succès", "Addition validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                try
                {
                    CConnection.Connecter();
                    CConnection.DIUQuery("update Servicee set nomService='"+textBox_NomService.Text+"' where idService="+textBox_IdService.Text+"");
                    CConnection.Deconnecter();
                    Actualiser();
                    MessageBox.Show("Service modifié avec succès", "Modification validé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    timer.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //Button Supprimer
        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (dgv_Serivices.Rows.Count > 0 )
            { 
                int index = dgv_Serivices.CurrentCell.RowIndex;
                string value = dgv_Serivices.Rows[index].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer le service '" + value + "' de la list des services ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.Yes)
                {
                    CConnection.Connecter();
                    CConnection.DIUQuery("delete from Servicee where idService=" + value + "");
                    CConnection.Deconnecter();
                    MessageBox.Show("Suppression validé !","Suppression");
                    Actualiser();
                }
            }
        }
        //Initialiser
        void Initialiser()
        {
            groupBox.Text = "";
            btn_Valider.Text = "Valider";
            textBox_IdService.Enabled = true;
        }
        //Vider
        void Vider()
        {
            textBox_IdService.Text = "";
            textBox_NomService.Text = "";
        }
        //Affectation
        void Affecter()
        {
            textBox_IdService.Text = dgv_Serivices.Rows[dgv_Serivices.CurrentRow.Index].Cells[0].Value.ToString();
            textBox_NomService.Text = dgv_Serivices.Rows[dgv_Serivices.CurrentRow.Index].Cells[1].Value.ToString();
        }
        //
        private void dgv_Serivices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Serivices.Rows.Count > 0 && groupBox.Visible && btn_Valider.Text == "Modifier")
            {
                Affecter();
            }
        }

        private void Service_FormClosed(object sender, FormClosedEventArgs e)
        {
            state = "haut";
            cpt = 436;
        }
    }
}
