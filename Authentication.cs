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
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
        public static bool Auth = false;
        public static string premierPass = "";
        private void btn_Connecter_Click(object sender, EventArgs e)
        {
                string login = textBox_login.Text;
                string pass = textBox_pass.Text;
                CConnection.Connecter();
                CConnection.SQuery("select * from compte");
                while (CConnection.dr.Read())
                {
                    if (CConnection.dr[0].ToString() == login && CConnection.dr[1].ToString() == pass)
                    {
                        this.Close();
                        Auth = true;
                        premierPass = CConnection.dr[1].ToString().Substring(0, 4);
                        break;
                    }
                }
                CConnection.Deconnecter();
        }
        //
    }
}
