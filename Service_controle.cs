using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projet_Stage
{
    public partial class Service_controle : UserControl
    {
        public Service_controle()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private int _idService = -1;
        private string _nameService = "";
        public int IdService { 
            get { return _idService; }
            set 
            {
                if (value > 0)
                {
                    _idService = value;
                    comboBox_service.Text = dic[value.ToString()];
                }
            }
        }
        public string NameService { get { return _nameService; } }
        public string Texte { set { comboBox_service.Text = value; } get { return this.comboBox_service.Text; } }
        public int Largeur { set { comboBox_service.Width = value; } }
        
        //

        private void ServiceB_Load(object sender, EventArgs e)
        {
            ChargerCombobox();
        }

        private void comboBox_service_SelectedIndexChanged(object sender, EventArgs e)
        {
            _idService =int.Parse(Obtenir_Id_Service(comboBox_service.Text));
            _nameService = comboBox_service.Text;
        }
        void ChargerCombobox()
        {
            comboBox_service.Items.Clear();
            dic.Clear();
            CConnection.Connecter();
            CConnection.SQuery("select * from Servicee");
            while (CConnection.dr.Read())
            {
                dic.Add(CConnection.dr[0].ToString(), CConnection.dr[1].ToString());
                comboBox_service.Items.Add(CConnection.dr[1]);
            }
            CConnection.Deconnecter();
        }
        string Obtenir_Id_Service(string nomService)
        {
            string Id = "";
            CConnection.Connecter();
            CConnection.SQuery("select idService from Servicee where nomService='"+nomService+"'");
            while (CConnection.dr.Read())
            {
                Id = CConnection.dr[0].ToString();
            }
            CConnection.Deconnecter();
            return Id;
        }

    }
}
