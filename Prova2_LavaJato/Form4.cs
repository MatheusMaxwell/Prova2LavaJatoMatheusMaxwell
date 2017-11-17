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
    public partial class Form4 : Form
    {
        HttpClient client;
        Uri lavagensUri;
        int ID = 0;
        public Form4()
        {
            InitializeComponent();
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            getAll();
            getAllComboBox();

        }

        private void getAll()
        {
            txtNomeCliente.Text = "";
            txtTelefoneCliente.Text = "";
            txtData.Text = "dd/MM/yyyy";
            txtData.ForeColor = System.Drawing.Color.Gray;
            txtPreco.Text = "";

            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens").Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var lavagens = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = lavagens;

            }

            
            else
                MessageBox.Show("Não foi possível obter os lavagens : " + response.StatusCode);
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDLavaJatoDataSet3.Funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTableAdapter3.Fill(this.bDLavaJatoDataSet3.Funcionario);
            //// TODO: This line of code loads data into the 'bDLavaJatoDataSet2.Funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTableAdapter2.Fill(this.bDLavaJatoDataSet2.Funcionario);
            //// TODO: This line of code loads data into the 'bDLavaJatoDataSet1.Funcionario' table. You can move, or remove it, as needed.
            //this.funcionarioTableAdapter1.Fill(this.bDLavaJatoDataSet1.Funcionario);
            //    // TODO: This line of code loads data into the 'bDLavaJatoDataSet.Funcionario' table. You can move, or remove it, as needed.
            //    this.funcionarioTableAdapter.Fill(this.bDLavaJatoDataSet.Funcionario);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbBusca.SelectedIndex == 0)
            {
                lblBuscaNome.Visible = true;
                lblBuscaNome.Text = "Nome:";
                txtBuscaNome.Visible = true;
                txtBuscaNome.Text = "";
                lblTipoBusca.Visible = false;
                cbTipoBusca.Visible = false;
                lblFuncBusca.Visible = false;
                cbFuncBusca.Visible = false;
                lblDataFBusca.Visible = false;
                txtDataFBusca.Visible = false;
                lblTipoLavagem.Visible = false;
                cbTipoLava.Visible = false;
                btnBusca.Visible = true;

            }
            else
            {
                if (cbBusca.SelectedIndex == 1)
                {
                    lblBuscaNome.Visible = false;
                    txtBuscaNome.Visible = false;
                    lblTipoBusca.Visible = true;
                    cbTipoBusca.Visible = true;
                    lblFuncBusca.Visible = false;
                    cbFuncBusca.Visible = false;
                    lblDataFBusca.Visible = false;
                    txtDataFBusca.Visible = false;
                    lblTipoLavagem.Visible = false;
                    cbTipoLava.Visible = false;
                    btnBusca.Visible = true;
                }
                else
                {
                    if(cbBusca.SelectedIndex == 2)
                    {
                        lblBuscaNome.Visible = false;
                        txtBuscaNome.Visible = false;
                        lblTipoBusca.Visible = false;
                        cbTipoBusca.Visible = false;
                        lblFuncBusca.Visible = true;
                        cbFuncBusca.Visible = true;
                        getAllComboBoxBusca();
                        lblDataFBusca.Visible = false;
                        txtDataFBusca.Visible = false;
                        lblTipoLavagem.Visible = false;
                        cbTipoLava.Visible = false;
                        btnBusca.Visible = true;
                    }
                    else
                    {
                        if(cbBusca.SelectedIndex == 3)
                        {
                            lblBuscaNome.Visible = true;
                            lblBuscaNome.Text = "Data Inicial:";
                            txtBuscaNome.Visible = true;
                            txtBuscaNome.ForeColor = System.Drawing.Color.Gray;
                            txtBuscaNome.Text = "ddMMyyyy";
                            lblTipoBusca.Visible = false;
                            cbTipoBusca.Visible = false;
                            lblFuncBusca.Visible = false;
                            cbFuncBusca.Visible = false;
                            lblDataFBusca.Visible = true;
                            txtDataFBusca.Visible = true;
                            txtDataFBusca.ForeColor = System.Drawing.Color.Gray;
                            txtDataFBusca.Text = "ddMMyyyy";
                            
                            lblTipoLavagem.Visible = false;
                            cbTipoLava.Visible = false;
                            btnBusca.Visible = true;
                        }
                        else
                        {
                            if(cbBusca.SelectedIndex == 4)
                            {
                                lblBuscaNome.Visible = false;
                                txtBuscaNome.Visible = false;
                                lblTipoBusca.Visible = false;
                                cbTipoBusca.Visible = false;
                                lblFuncBusca.Visible = false;
                                cbFuncBusca.Visible = false;
                                lblDataFBusca.Visible = false;
                                txtDataFBusca.Visible = false;
                                lblTipoLavagem.Visible = true;
                                cbTipoLava.Visible = true;
                                btnBusca.Visible = true;
                            }
                            else
                            {
                                lblBuscaNome.Visible = true;
                                lblBuscaNome.Text = "Preço Inicial:";
                                txtBuscaNome.Visible = true;
                                txtBuscaNome.Text = "";
                                lblTipoBusca.Visible = false;
                                cbTipoBusca.Visible = false;
                                lblFuncBusca.Visible = false;
                                cbFuncBusca.Visible = false;
                                lblDataFBusca.Text = "Preço Final:";
                                lblDataFBusca.Visible = true;
                                txtDataFBusca.Visible = true;
                                txtDataFBusca.Text = "";
                                lblTipoLavagem.Visible = false;
                                cbTipoLava.Visible = false;
                                btnBusca.Visible = true;
                            }
                        }
                        
                    }
                    
                }
            }
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtNomeCliente.Text != "" && txtTelefoneCliente.Text != "" && txtData.Text !="" && cbAutomovel.SelectedIndex >=0 && cbFuncResponsavel.SelectedIndex >= 0 && cbTipoLavagem.SelectedIndex >= 0 && txtPreco.Text != "")
            {
                Lavagem lav = new Lavagem();
                if (cbAutomovel.SelectedIndex == 0)
                    lav.TipoAutomovel = "Carro";
                else if (cbAutomovel.SelectedIndex == 1)
                    lav.TipoAutomovel = "Caminhão";
                else
                    lav.TipoAutomovel = "Moto";
                lav.NomeCliente = txtNomeCliente.Text;
                lav.TelefoneCliente = txtTelefoneCliente.Text;
                lav.DataLavagem = DateTime.Parse(txtData.Text);
                lav.IdFuncResponsavel = (int)cbFuncResponsavel.SelectedValue;

                if (cbTipoLavagem.SelectedIndex == 0)
                    lav.TipoLavagem = "Lavegem Completa";
                else if (cbTipoLavagem.SelectedIndex == 1)
                    lav.TipoLavagem = "Lavagem Fora";
                else if (cbTipoLavagem.SelectedIndex == 2)
                    lav.TipoLavagem = "Lavagem Dentro";
                else if (cbTipoLavagem.SelectedIndex == 3)
                    lav.TipoLavagem = "Lavagem e Revisão";

                lav.Preco = double.Parse(txtPreco.Text);

                using (var client = new HttpClient())
                {
                    var serializedLavagem = JsonConvert.SerializeObject(lav);
                    var content = new StringContent(serializedLavagem, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("http://webapilavajato.azurewebsites.net/api/lavagens", content);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lavagem adicionado!");
                        getAll();
                    }
                        
                    else
                        MessageBox.Show("Erro ao adicionar Lavagem!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }

            
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cbAutomovel.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); ;
                txtNomeCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(); ;
                txtTelefoneCliente.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); ;
                txtData.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
                cbFuncResponsavel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
                cbTipoLavagem.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
                txtPreco.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString(); ;
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text != "" && txtTelefoneCliente.Text != "" && txtData.Text != "" && cbAutomovel.SelectedIndex >= 0 && cbFuncResponsavel.SelectedIndex >= 0 && cbTipoLavagem.SelectedIndex >= 0 && txtPreco.Text != "")
            {
                Lavagem lav = new Lavagem();
                lav.Id = ID;
                if (cbAutomovel.SelectedIndex == 0)
                    lav.TipoAutomovel = "Carro";
                else if (cbAutomovel.SelectedIndex == 1)
                    lav.TipoAutomovel = "Caminhão";
                else
                    lav.TipoAutomovel = "Moto";
                lav.NomeCliente = txtNomeCliente.Text;
                lav.TelefoneCliente = txtTelefoneCliente.Text;
                lav.DataLavagem = DateTime.Parse(txtData.Text);
                lav.IdFuncResponsavel = cbFuncResponsavel.SelectedIndex + 1;

                if (cbTipoLavagem.SelectedIndex == 0)
                    lav.TipoLavagem = "Lavegem Completa";
                else if (cbTipoLavagem.SelectedIndex == 1)
                    lav.TipoLavagem = "Lavagem Fora";
                else if (cbTipoLavagem.SelectedIndex == 2)
                    lav.TipoLavagem = "Lavagem Dentro";
                else if (cbTipoLavagem.SelectedIndex == 3)
                    lav.TipoLavagem = "Lavagem e Revisão";
                lav.Preco = double.Parse(txtPreco.Text);
                using (var client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.PutAsJsonAsync("http://webapilavajato.azurewebsites.net/api/lavagens" + "/" + ID, lav);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Lavagem atualizada!");
                        getAll();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao atualizar a lavagem : " + responseMessage.StatusCode);
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://webapilavajato.azurewebsites.net/api/lavagens");
                HttpResponseMessage responseMessage = await client.DeleteAsync(String.Format("{0}/{1}", "http://webapilavajato.azurewebsites.net/api/lavagens", ID));
                if (responseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Lavagem excluída com sucesso!");
                    getAll();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a lavagem: " + responseMessage.StatusCode);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void getAllNome(string nome)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/nomeCliente/" + nome).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllTipoAutomovel(string tipo)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/tipoAutomovel/" + tipo).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllFuncID (int idFunc)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/funcResponsavel/" + idFunc).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllData(string dataMin, string dataMax)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/data/" + dataMin + "/"+ dataMax).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllTipoLavagem(string tipo)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/tipoLavagem/"+tipo).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllPreco(double min, double max)
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/lavagens/preco/" + min + "/" + max).Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Lavagem>>().Result;

                dataGridView1.DataSource = materiais;

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }

        private void getAllComboBox()
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/funcionarios").Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Funcionario>>().Result;

                cbFuncResponsavel.DataSource = materiais;
                cbFuncResponsavel.DisplayMember = "Nome";
                cbFuncResponsavel.ValueMember = "Id";
                

            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        
        }

        private void getAllComboBoxBusca()
        {
            System.Net.Http.HttpResponseMessage response = client.GetAsync("http://webapilavajato.azurewebsites.net/api/funcionarios").Result;

            if (response.IsSuccessStatusCode)
            {
                lavagensUri = response.Headers.Location;

                var materiais = response.Content.ReadAsAsync<IEnumerable<Funcionario>>().Result;

                cbFuncBusca.DataSource = materiais;
                cbFuncBusca.DisplayMember = "Nome";
                cbFuncBusca.ValueMember = "Id";


            }


            else
                MessageBox.Show("Não foi possível concluir a busca: " + response.StatusCode);
        }
        private void btnBusca_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if(cbBusca.SelectedIndex  == 0)
            {
                getAllNome(txtBuscaNome.Text);
            }
            else if(cbBusca.SelectedIndex == 1)
            {
                if (cbTipoBusca.SelectedIndex == 0)
                    tipo = "Carro";
                else if (cbTipoBusca.SelectedIndex == 1)
                    tipo = "Caminhão";
                else
                    tipo = "Moto";
                getAllTipoAutomovel(tipo);
            }
            else if(cbBusca.SelectedIndex == 2)
            {
                getAllFuncID((int)cbFuncBusca.SelectedValue);
            }
            else if(cbBusca.SelectedIndex == 3)
            {
                getAllData(txtBuscaNome.Text, txtDataFBusca.Text);
            }
            else if(cbBusca.SelectedIndex == 4)
            {
                if (cbTipoLava.SelectedIndex == 0)
                    tipo = "Lavagem Completa";
                else if (cbTipoLava.SelectedIndex == 1)
                    tipo = "Lavagem Fora";
                else if (cbTipoLava.SelectedIndex == 2)
                    tipo = "Lavagem Dentro";
                else if (cbTipoLava.SelectedIndex == 3)
                    tipo = "Lavagem e Revisão";
                getAllTipoLavagem(tipo);
            }
            else if(cbBusca.SelectedIndex == 5)
            {
                getAllPreco(double.Parse(txtBuscaNome.Text), double.Parse(txtDataFBusca.Text));
            }
        }

        private void txtDataFBusca_TextChanged(object sender, EventArgs e)
        {
            if(txtDataFBusca.Text == "ddMMyyyy")
            {
                txtDataFBusca.Text = "";
                txtDataFBusca.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void txtBuscaNome_Click (object sender, EventArgs e)
        {
            if(txtBuscaNome.Text == "ddMMyyyy")
            {
                txtBuscaNome.Text = "";
                txtBuscaNome.ForeColor = System.Drawing.Color.Black;
            }
            
        }

        private void txtData_Click (object sender, EventArgs e)
        {
            if(txtData.Text == "dd/MM/yyyy")
            {
                txtData.Text = "";
                txtData.ForeColor = System.Drawing.Color.Black;
            }
            
        }
    }
}
