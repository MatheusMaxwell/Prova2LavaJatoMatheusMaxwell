using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2_LavaJato
{
    public partial class Form3 : Form
    {
        HttpClient client;
        Uri materialsUri;
        int ID = 0;
        public Form3()
        {
            InitializeComponent();
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            getAll();
        }

        private void getAll()
        {
           
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/materials").Result;

            if (response.IsSuccessStatusCode)
            {
                materialsUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Material>>().Result;

                dataGridView1.DataSource = materiais;
                
            }

         
            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void getAllNome (string nome)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/materials/nome/"+nome).Result;

            if (response.IsSuccessStatusCode)
            {
                materialsUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Material>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void getAllQtd (int min, int max)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/materials/quantidade/"+min+"/"+max).Result;

            if (response.IsSuccessStatusCode)
            {
                materialsUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Material>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }

        private void getAllValor (double min, double max)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/materials/valor/"+min+"/"+max).Result;

            if (response.IsSuccessStatusCode)
            {
                materialsUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Material>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível obter o estoque : " + response.StatusCode);
        }
        private void cbBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBusca1.Visible = true;
            if(cbBusca.SelectedIndex == 0)
            {
                lblBusca1.Text = "Nome:";
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                lblBusca2.Visible = false;
                txtBusca2.Visible = false;
                btnBusca.Visible = true;

            }
            else
            {
                if(cbBusca.SelectedIndex == 2)
                {
                    lblBusca1.Text = "Maior/igual:";
                    txtBusca1.Visible = true;
                    txtBusca1.Text = "";
                    lblBusca2.Visible = true;
                    txtBusca2.Visible = true;
                    txtBusca2.Text = "";
                    btnBusca.Visible = true;
                }
                else
                {
                    lblBusca1.Text = "Maior/igual:";
                    txtBusca1.Visible = true;
                    txtBusca1.Text = "";
                    lblBusca2.Visible = true;
                    txtBusca2.Visible = true;
                    txtBusca2.Text = "";
                    btnBusca.Visible = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                txtValor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                txtQtd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
            }
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && txtQtd.Text != "" && txtValor.Text != "")
            {
                Material mat = new Material();
                mat.Nome = txtNome.Text;
                mat.Quantidade = int.Parse(txtQtd.Text);
                mat.ValorUnitario = double.Parse(txtValor.Text);
                using (var client = new HttpClient())
                {
                    var serializedMaterial = JsonConvert.SerializeObject(mat);
                    var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapilavajato.azurewebsites.net/api/materials", content);
                    if (result.IsSuccessStatusCode)
                    {
                         MessageBox.Show("Material adicionado!");
                         getAll();
                    }
                   
                    else
                        MessageBox.Show("Erro ao adicionar material!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            
            
            
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(cbBusca.SelectedIndex == 0)
            {
                getAllNome(txtBusca1.Text);
            }
            else if(cbBusca.SelectedIndex == 1)
            {
                getAllQtd(int.Parse(txtBusca1.Text), int.Parse(txtBusca2.Text));
            }
            else
            {
                getAllValor(double.Parse(txtBusca1.Text), double.Parse(txtBusca2.Text));
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtQtd.Text != "" && txtValor.Text != "")
            {
                Material mat = new Material();
                mat.Id = ID;
                mat.Nome = txtNome.Text;
                mat.Quantidade = int.Parse(txtQtd.Text);
                mat.ValorUnitario = double.Parse(txtValor.Text);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapilavajato.azurewebsites.net/api/materials" + "/" + ID, mat);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Estoque atualizado!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o estoque : " + responseMessage.StatusCode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net/api/lavagens");
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapilavajato.azurewebsites.net/api/materials", ID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Material excluído do estoque com sucesso!");
                    getAll();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o material: " + responseMessage.StatusCode);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAll();
        }
    }
}
