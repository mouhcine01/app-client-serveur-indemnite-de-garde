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
    public partial class PlaningDeGuard1 : Form
    {
        public PlaningDeGuard1()
        {
            InitializeComponent();
        }
        //-----------------------Variables
        private static int initiale = 0;
        private Dictionary<string, string> dic_GetIdByName = new Dictionary<string, string>();
        private Dictionary<string, string> dic_GetNameById = new Dictionary<string, string>();
        private void PlaningDeGuard1_Load(object sender, EventArgs e)
        {
            comboBox_mois.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBox_mois.Items.Add(i);
            }
            comboBox_annee.Items.Clear();
            for (int i = DateTime.Now.Year + 1; i >= DateTime.Now.Year -100; i--)
            {
                comboBox_annee.Items.Add(i);
            }
            //
            //ChargerDGVDate(DateTime.Now.Month, DateTime.Now.Year);
            //
            initiale = 0;
            comboBox_mois.SelectedIndex = DateTime.Now.Month - 1;
            comboBox_annee.SelectedIndex = 1;
            initiale = 1;
            //
            ChargerComboboxService();
            ChargerDGVDate(int.Parse(comboBox_mois.Text),int.Parse(comboBox_annee.Text));
            
        }
        //-----------------------Methodes
        void ChargerComboboxService()
        {
            comboBox_service.Items.Clear();
            dic_GetNameById.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select * from Servicee");
            while (CConnection.dr.Read())
            {
                dic_GetNameById.Add(CConnection.dr[0].ToString(), CConnection.dr[1].ToString());
                dic_GetIdByName.Add(CConnection.dr[1].ToString(), CConnection.dr[0].ToString());
                comboBox_service.Items.Add(CConnection.dr[1]);
            }
            CConnection.Deconnecter();
        }
        string GetIdByName(string name)
        {
            string Id=dic_GetIdByName[name];
            return Id;
        }
        string GetNameById(string id)
        {
            string Name = dic_GetNameById[id];
            return Name;
        }
        void ChargerDGVInfirmier1()
        {
            dgv_infirmier_1.Rows.Clear();
            string dateFrancais = dgv_date.Rows[dgv_date.CurrentCell.RowIndex].Cells[0].Value.ToString();
            CConnection.Connecter();
            CConnection.SQuery("exec AficherInfirmier " + GetIdByName(comboBox_service.Text) + ",'" + SQLDate(dateFrancais) + "',1");
            while (CConnection.dr.Read())
            {
                dgv_infirmier_1.Rows.Add((bool)CConnection.dr[0], CConnection.dr[1].ToString(), CConnection.dr[2].ToString(), CConnection.dr[3].ToString());
            }
            CConnection.Deconnecter();
        }
        void ChargerDGVInfirmier2()
        {
            dgv_infirmier_2.Rows.Clear();
            string dateFrancais = dgv_date.Rows[dgv_date.CurrentCell.RowIndex].Cells[0].Value.ToString();
            CConnection.Connecter();
            CConnection.SQuery("exec AficherInfirmier " + GetIdByName(comboBox_service.Text) + ",'" + SQLDate(dateFrancais) + "',2");
            while (CConnection.dr.Read())
            {
                dgv_infirmier_2.Rows.Add((bool)CConnection.dr[0], CConnection.dr[1].ToString(), CConnection.dr[2].ToString(), CConnection.dr[3].ToString());
            }
            CConnection.Deconnecter();
        }
        void ChargerDGVDate(int mois, int annee)
        {
            dgv_date.Rows.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(annee, mois); i++)
            {
                if (i <= 9)
                {
                    if (mois <= 9)
                    {
                        dgv_date.Rows.Add("0" + i + "/0" + mois + "/" + annee);
                    }
                    else { dgv_date.Rows.Add("0" + i + "/" + mois + "/" + annee); }
                }
                else 
                {
                    if (mois <= 9)
                    {
                        dgv_date.Rows.Add(i + "/0" + mois + "/" + annee);
                    }
                    else { dgv_date.Rows.Add(i + "/" + mois + "/" + annee); }
                }
            }
        }
        string SQLDate(string FrDate)
        {
            string EnDate = FrDate.Substring(6, 4) + "-" + FrDate.Substring(3, 2) + "-" + FrDate.Substring(0, 2);
            return EnDate;
        }
        //-----------------------Evennements
        private void comboBox_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChargerDGVInfirmier1();
            ChargerDGVInfirmier2();
        }
        private void ChangeDate(object sender, EventArgs e)
        {
            if (initiale == 1)
            {
                ChargerDGVDate(int.Parse(comboBox_mois.Text), int.Parse(comboBox_annee.Text));
                if (comboBox_service.Text != "")
                {
                    ChargerDGVInfirmier1();
                    ChargerDGVInfirmier2();
                }
            }
        }
        //-----------------------Bouttons

        private void btn_Valider_2_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                if (dgv_infirmier_2.Rows.Count > 0)
                {
                    string dateFrancais = dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[0].Value.ToString();
                    string SQLdate = SQLDate(dateFrancais);
                    for (int i = 0; i <= dgv_infirmier_2.Rows.Count - 1; i++)
                    {
                        bool x = (bool)dgv_infirmier_2.Rows[i].Cells[0].Value;
                        string idInf = dgv_infirmier_2.Rows[i].Cells[1].Value.ToString();
                        if (x == true)
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("insert into Guarde values ('" + SQLdate + "',2," + idInf + ")");//perioede 2
                            CConnection.Deconnecter();
                        }
                        else
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("delete from Guarde where dateGuarde='" + SQLdate + "' and periode=2 and #idInfirmier=" + idInf + "");
                            CConnection.Deconnecter();
                        }
                    }
                    //
                    MessageBox.Show("Modification de la guarde · " + dateFrancais + " · periode · II · validé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[2].Style.BackColor = Color.LightGreen;
                    ChargerDGVInfirmier2();
                }
            }
            catch
            {
                ChargerDGVInfirmier2();
                MessageBox.Show("La date  · " + dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[0].Value.ToString() + " · est réservé par un cogé ou une absence d'un ou plusieurs infirmers sélectionneé(s) dans la liste .", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }

        private void btn_Valider_1_Click(object sender, EventArgs e)
        {
            #region
            try
            {
                if (dgv_infirmier_1.Rows.Count > 0)
                {
                    string dateFrancais = dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[0].Value.ToString();
                    string SQLdate = SQLDate(dateFrancais);
                    for (int i = 0; i <= dgv_infirmier_1.Rows.Count - 1; i++)
                    {
                        bool x = (bool)dgv_infirmier_1.Rows[i].Cells[0].Value;
                        string idInf = dgv_infirmier_1.Rows[i].Cells[1].Value.ToString();
                        if (x == true)
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("insert into Guarde values ('"+SQLdate+"',1,"+idInf+")");//perioede 1
                            CConnection.Deconnecter();
                        }
                        else
                        {
                            CConnection.Connecter();
                            CConnection.DIUQuery("delete from Guarde where dateGuarde='"+SQLdate+"' and periode=1 and #idInfirmier="+idInf+"");
                            CConnection.Deconnecter();
                        }
                    }
                    //
                    MessageBox.Show("Modification de la guarde · " + dateFrancais + " · periode · I · validé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[1].Style.BackColor = Color.LightGreen;
                    ChargerDGVInfirmier1();
                }
            }
            catch
            {
                ChargerDGVInfirmier1();
                MessageBox.Show("La date  · " + dgv_date.Rows[dgv_date.CurrentRow.Index].Cells[0].Value.ToString() + " · est réservé par un cogé ou une absence d'un ou plusieurs infirmers sélectionneé(s) dans la liste .", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            #endregion
        }

        private void dgv_date_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_service.Text != "")
            {
                ChargerDGVInfirmier1();
                ChargerDGVInfirmier2();
            }
        }
    }
}
