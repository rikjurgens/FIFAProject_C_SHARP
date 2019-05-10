using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FifaApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getDataButton_Click(object sender, EventArgs e)
        {
			try
			{
				listBox.Items.Clear();
				// Bron: https://stackoverflow.com/a/4758334
				System.Net.WebClient downloader = new System.Net.WebClient();
				string dataJson;

				//?id = " + input.ToString());
				dataJson = downloader.DownloadString("http://localhost/FIFAProject_PHP/config-teams.php");

				// Deserialize the json to a data object
				Data data = JsonConvert.DeserializeObject<Data>(dataJson);

				for (int i = 0; i < data.names.Count; i++)
				{
					listBox.Items.Add(data.names[i].ToString());
				}
				
			}

			catch (JsonReaderException) {
				MessageBox.Show("Dit team is nog niet aangemaakt / of bestaat nog niet");
			}
            
        }
    }
}
