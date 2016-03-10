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
    public partial class DateB : UserControl
    {
        public DateB()
        {
            InitializeComponent();
        }
        //
        private int _jour=-1;
        private int _mois=-1;
        private int _annee=-1;
        //
        public int Jour  { 
            get { return _jour; } 
            set { 
                    comboBox_jour.Text = value.ToString();
                    _jour = value;
                } 
        }
        public int Mois  { 
            get { return _mois; } 
            set  
            {
                if (value <= 12 && value >= 1)
                {
                    comboBox_mois.Text = comboBox_mois.Items[value - 1].ToString();
                    _mois = value;
                }
            } 
        }
        public int Annee 
            { 
                get { return _annee;} 
                set 
                { 
                        comboBox_annee.Text = value.ToString();
                        _annee = value;
                } 
            }
        
        public void Reinitialiser()
        {
            _jour=-1;
            _mois=-1;
            _annee=-1;
            comboBox_jour.Text = "Jour";
            comboBox_mois.Text = "Mois";
            comboBox_annee.Text="Année";
        }
        public string DateSQL 
        { 
            
            get {
                if (_jour != -1 && _mois != -1 && _annee != -1) 
                { 
                    return comboBox_annee.Text + "-" + cMois(comboBox_mois.Text) + "-" + comboBox_jour.Text; 
                }
                else { return ""; }
                } 
        }
        //
        public int cMois(string mois)
        {
            int res = -1;
            for (int i = 1; i <= 12; i++)
            {
                if (comboBox_mois.Items[i-1].ToString() == mois) 
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        private void comboBox_jour_SelectedIndexChanged(object sender, EventArgs e)
        {
            _jour = int.Parse(comboBox_jour.Text);
        }

        private void comboBox_mois_SelectedIndexChanged(object sender, EventArgs e)
        {
            _mois = cMois(comboBox_mois.Text);
        }

        private void comboBox_annee_SelectedIndexChanged(object sender, EventArgs e)
        {
            _annee = int.Parse(comboBox_annee.Text);
        }

        private void DateB_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            { comboBox_jour.Items.Add(i); }
            for (int i = DateTime.Now.Year; i >=DateTime.Now.Year - 100 ; i--)
            { comboBox_annee.Items.Add(i); }
            Reinitialiser();
        }
        

    }
}
