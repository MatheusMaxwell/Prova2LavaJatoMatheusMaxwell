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
    public partial class Form5 : Form
    {
        HttpClient client;
        Uri custosUri;
        int ID = 0;

        public Form5()
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

            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/custos").Result;

            if (response.IsSuccessStatusCode)
            {
                custosUri = response.Headers.Location;

                var custos = response.Content.ReadAsAsync<IEnumerable<Custo>>().Result;

                dataGridView1.DataSource = custos;

            }

           
            else
                MessageBox.Show("Não foi possível obter os custos: " + response.StatusCode);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBusca1.Visible = true;
            if (cbBusca.SelectedIndex == 0)
            {
                lblBusca1.Text = "Nome:";
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                lblBusca2.Visible = false;
                txtBusca2.Visible = false;
                txtBusca2.Text = "";
                btnBusca.Visible = true;
                lblTipo.Visible = false;
                cbBuscaTipo.Visible = false;

            }
            else
            {
                if (cbBusca.SelectedIndex == 1)
                {
                    lblBusca1.Text = "Maior que:";
                    txtBusca1.Visible = true;
                    txtBusca1.Text = "";
                    lblBusca2.Visible = true;
                    txtBusca2.Visible = true;
                    txtBusca2.Text = "";
                    btnBusca.Visible = true;
                    lblTipo.Visible = false;
                    cbBuscaTipo.Visible = false;
                }
                else
                {
                    lblBusca1.Visible = false;
                    txtBusca1.Visible = false;
                    lblBusca2.Visible = false;
                    txtBusca2.Visible = false;
                    lblTipo.Visible = true;
                    cbBuscaTipo.Visible = true;
                    btnBusca.Visible = true;
                }
            }
        }

        private void getAllNome (string nome)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/custos/nome/"+nome).Result;

            if (response.IsSuccessStatusCode)
            {
                custosUri = response.Headers.Location;

                var custos = response.Content.ReadAsAsync<IEnumerable<Custo>>().Result;

                dataGridView1.DataSource = custos;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllValor (double min, double max)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/custos/valor/"+min+"/"+max).Result;

            if (response.IsSuccessStatusCode)
            {
                custosUri = response.Headers.Location;

                var custos = response.Content.ReadAsAsync<IEnumerable<Custo>>().Result;

                dataGridView1.DataSource = custos;

            }


            else
                MessageBox.Show("Não foi possível obter os custos: " + response.StatusCode);
        }

        private void getAllTipo (string tipo)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/custos/tipo/"+tipo).Result;

            if (response.IsSuccessStatusCode)
            {
                custosUri = response.Headers.Location;

                var custos = response.Content.ReadAsAsync<IEnumerable<Custo>>().Result;

                dataGridView1.DataSource = custos;

            }


            else
                MessageBox.Show("Não foi possível obter os custos: " + response.StatusCode);
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(cbBusca.SelectedIndex == 0)
            {
                getAllNome(txtBusca1.Text);
            }
            else if(cbBusca.SelectedIndex == 1)
            {
                getAllValor(double.Parse(txtBusca1.Text), double.Parse(txtBusca2.Text));
            }
            else if(cbBusca.SelectedIndex == 2)
            {
                if (cbBuscaTipo.SelectedIndex == 0)
                    getAllTipo("Material");
                else
                    getAllTipo("Outros");
            }
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && cbTipo.SelectedIndex >= 0 && txtValor.Text != "" && txtDescricao.Text != "")
            {
                Custo custo = new Custo();
                custo.Nome = txtNome.Text;
                if (cbTipo.SelectedIndex == 0)
                    custo.Tipo = "Material";
                else
                    custo.Tipo = "Outros";
                custo.Valor = double.Parse(txtValor.Text);
                custo.Descricao = txtDescricao.Text;
                using (var client = new HttpClient())
                {
                    var serializedMaterial = JsonConvert.SerializeObject(custo);
                    var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapilavajato.azurewebsites.net/api/custos", content);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Custo adicionado!");
                        getAll();
                    }

                    else
                        MessageBox.Show("Erro ao adicionar custo!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && cbTipo.SelectedIndex >= 0 && txtValor.Text != "" && txtDescricao.Text != "")
            {
                Custo custo = new Custo();
                custo.Id = ID;
                custo.Nome = txtNome.Text;
                if (cbTipo.SelectedIndex == 0)
                    custo.Tipo = "Material";
                else
                    custo.Tipo = "Outros";
                custo.Valor = double.Parse(txtValor.Text);
                custo.Descricao = txtDescricao.Text;
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapilavajato.azurewebsites.net/api/custos" + "/" + ID, custo);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Custos atualizados!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar custos : " + responseMessage.StatusCode);
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
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net/api/custos");
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapilavajato.azurewebsites.net/api/custos", ID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Custo excluído com sucesso!");
                    getAll();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o custo: " + responseMessage.StatusCode);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                cbTipo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                txtValor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
                txtDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAll();
        }
    }
}
