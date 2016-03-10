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
    public partial class Gestion_Absence : Form
    {
        public Gestion_Absence()
        {
            InitializeComponent();
        }
        //**************** Variables
        private string premierPass = "";
        //**************** Méthodes
        void ChargerDGVInfirmier(string date,int idService)
        {
            dgv_infirmier.Rows.Clear();
            CConnection.Connecter();
            CConnection.SQuery("exec  AfficherInfirmierAbsence '"+date+"',"+idService+"");
            while (CConnection.dr.Read())
            {
                bool absent = false;
                if ((bool)CConnection.dr[0] == true) { absent = false; } else { absent = true; }
                dgv_infirmier.Rows.Add(absent, CConnection.dr[1].ToString(), CConnection.dr[2].ToString(), CConnection.dr[3].ToString());
            }
            CConnection.Deconnecter();
        }
        //----------
        string GetIdServiceByPremierPass(string premP)
        {
            string id = "";
            CConnection.Connecter();
            CConnection.SQuery("select idService from Servicee where substring(nomService,1,4)='" + premP + "'");
            while (CConnection.dr.Read())
            {
                id = CConnection.dr[0].ToString();
            }
            CConnection.Deconnecter();
            return id;
        }
        //
        private string DateSQL()
        {
            return dateTimePicker.Value.Year + "-" + dateTimePicker.Value.Month + "-" + dateTimePicker.Value.Day;
        }
        //**************** Bouttons
        private void Gestion_Absence_Load(object sender, EventArgs e)
        {
            this.premierPass = Authentication.premierPass;
            ChargerDGVInfirmier(DateSQL(), int.Parse(GetIdServiceByPremierPass(this.premierPass)));
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ChargerDGVInfirmier(DateSQL(), int.Parse(GetIdServiceByPremierPass(this.premierPass)));
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_infirmier.Rows.Count > 0)
                {

                    for (int i = 0; i <= dgv_infirmier.Rows.Count - 1; i++)
                    {
                        bool x = (bool)dgv_infirmier.Rows[i].Cells[0].Value;
                        string idInf = dgv_infirmier.Rows[i].Cells[1].Value.ToString();
                        if (x == false)
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("insert into Absence values (" + idInf + ",'" + DateSQL() + "')");
                            CConnection.Deconnecter();
                        }
                        else
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("delete from Absence where dateAbsence='" + DateSQL() + "' and #idInfirmier=" + idInf + "");
                            CConnection.Deconnecter();
                        }
                    }
                    //
                    MessageBox.Show("Modification des absence · " + DateSQL() + " · validé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
    }
}
