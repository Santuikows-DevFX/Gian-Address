using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealTimeAddress
{
    public partial class Address : Form
    {
        public Address()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbRegion.Items.Add("Metro Manila");
            cmbProvince.Items.Add("Metro Manila");

            string[] cities = { "Valenzuela", "Ermita" };
            foreach(string city in cities)
            {
                cmbCity.Items.Add(city);
            }

           

        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList barangays = new ArrayList();
            if(cmbCity.Text.Equals("Valenzuela"))
            {
                cmbBarangay.Items.Clear();
                cmbBarangay.Text = "";
                barangays.Add("Barangay In Val #1");
                barangays.Add("Barangay In Val #2");
                barangays.Add("Barangay In Val #3");
                barangays.Add("Barangay In Val #4");

                for (int i = 0; i < barangays.Count; i++)
                {
                    cmbBarangay.Items.Add(barangays[i]);
                }
            }else
            {
                cmbBarangay.Items.Clear();
                cmbBarangay.Text = "";
                barangays.Add("Barangay In Ermita #1");
                barangays.Add("Barangay In Ermita #2");
                barangays.Add("Barangay In Ermita #3");
                barangays.Add("Barangay In Ermita #4");

                for (int i = 0; i < barangays.Count; i++)
                {
                    cmbBarangay.Items.Add(barangays[i]);
                }

            }
        }
    }
}
