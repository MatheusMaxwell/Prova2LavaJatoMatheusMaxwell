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
    public partial class Form6 : Form
    {
        HttpClient client;
        Uri funcionariosUri;
        int ID = 0;
        public Form6()
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

            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/funcionarios").Result;

            if (response.IsSuccessStatusCode)
            {
                funcionariosUri = response.Headers.Location;

                var funcionarios = response.Content.ReadAsAsync<IEnumerable<Funcionario>>().Result;

                dataGridView1.DataSource = funcionarios;

            }


            else
                MessageBox.Show("Não foi possível obter os funcionarios : " + response.StatusCode);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Visible = true;
            if (cbBusca.SelectedIndex == 0)
            {
                label5.Text = "Nome:";
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                lblBusca2.Visible = false;
                txtBusca2.Visible = false;
                txtBusca2.Text = "";
                btnBusca.Visible = true;

            }
            else
            {
                label5.Text = "Maior igual:";
                txtBusca1.Visible = true;
                txtBusca1.Text = "";
                lblBusca2.Visible = true;
                txtBusca2.Visible = true;
                txtBusca2.Text = "";
                btnBusca.Visible = true;
            }
        }

        private void getAllNome(string nome)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/funcionarios/nome/"+nome).Result;

            if (response.IsSuccessStatusCode)
            {
                funcionariosUri = response.Headers.Location;

                var funcionarios = response.Content.ReadAsAsync<IEnumerable<Funcionario>>().Result;

                dataGridView1.DataSource = funcionarios;

            }


            else
                MessageBox.Show("Não foi possível obter os funcionarios : " + response.StatusCode);
        }

        private void getAllSalario (double min, double max)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/funcionarios/salario/" + min+"/"+max).Result;

            if (response.IsSuccessStatusCode)
            {
                funcionariosUri = response.Headers.Location;

                var funcionarios = response.Content.ReadAsAsync<IEnumerable<Funcionario>>().Result;

                dataGridView1.DataSource = funcionarios;

            }


            else
                MessageBox.Show("Não foi possível obter os funcionarios : " + response.StatusCode);
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            if(cbBusca.SelectedIndex == 0)
            {
                getAllNome(txtBusca1.Text);
            }
            else if(cbBusca.SelectedIndex == 1)
            {
                getAllSalario(double.Parse(txtBusca1.Text), double.Parse(txtBusca2.Text));
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(txtNome.Text != "" && txtTelefone.Text != "" && txtSalario.Text != "")
            {
                Funcionario func = new Funcionario();
                func.Nome = txtNome.Text; ;
                func.Telefone = txtTelefone.Text;
                func.Salario = double.Parse(txtSalario.Text);
                using (var client = new HttpClient())
                {
                    var serializedMaterial = JsonConvert.SerializeObject(func);
                    var content = new StringContent(serializedMaterial, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapilavajato.azurewebsites.net/api/funcionarios", content);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Funcionario adicionado!");
                        getAll();
                    }

                    else
                        MessageBox.Show("Erro ao adicionar funcionario!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }
            

        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtTelefone.Text != "" && txtSalario.Text != "")
            {
                Funcionario func = new Funcionario();
                func.Id = ID;
                func.Nome = txtNome.Text; ;
                func.Telefone = txtTelefone.Text;
                func.Salario = double.Parse(txtSalario.Text);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapilavajato.azurewebsites.net/api/funcionarios" + "/" + ID, func);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Funcionario atualizado!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar o funcionario : " + responseMessage.StatusCode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net/api/funcionarios");
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapilavajato.azurewebsites.net/api/funcionarios", ID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Funcionario excluído com sucesso!");
                    getAll();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o funcionario: " + responseMessage.StatusCode);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
            txtTelefone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
            txtSalario.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getAll();
        }
    }
}
