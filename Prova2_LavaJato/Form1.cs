using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova2_LavaJato
{
    public partial class Form1 : Form
    {
        Usuario usu = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if(txtLoguin.Text == usu.Loguin)
            {
                if(txtSenha.Text == usu.Senha)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                }
            }
            else
            {
                MessageBox.Show("Usuario incorreto!");
            }
            
        }

        
    }
}
