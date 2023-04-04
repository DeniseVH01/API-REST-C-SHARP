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
using System.Net;
using System.IO;
namespace API_REST_C_SHARP
{
    public partial class Form1 : Form
    {
        string URL = "https://jsonplaceholder.typicode.com/posts";

        public Form1()
        {
            InitializeComponent();
        }

        public async Task<string> GetHttp()
        {

            WebRequest oRequest = WebRequest.Create(URL);
            WebResponse oResponse = oRequest.GetResponse();
            oResponse.Headers["Placeholder-Token"] = "3951d5d8-b2f8-4cd8-bf5f-9d619e03a5c2";
            HttpWebResponse response = oRequest.GetResponse() as HttpWebResponse;
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async void BTNaceptar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<PostModelo> lista = JsonConvert.DeserializeObject<List<PostModelo>>(respuesta);
            DGVlista.DataSource = lista;
            DGVlista.CurrentCell = null;
            foreach (DataGridViewRow row in DGVlista.Rows)
            {
                row.Visible = row.Cells["userId"].Value.ToString().Contains(TXTbuscar.Text);
            }
        }

        private async void BTNbuscar_Click(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            DGVlista.CurrentCell = null;
            foreach (DataGridViewRow row in DGVlista.Rows)
            {
                row.Visible = row.Cells["userId"].Value.ToString().Contains(TXTbuscar.Text);
            }
        }

       
    }
}
