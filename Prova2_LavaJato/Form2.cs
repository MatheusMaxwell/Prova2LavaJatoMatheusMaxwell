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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.Show();
        }

        private void lavagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.Show();
        }

        private void custoDispesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.Show();
        }

        private void closeFormsChildren()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].IsMdiChild)
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeFormsChildren();
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.StartPosition = FormStartPosition.CenterScreen;
            f6.Show();
        }


        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
