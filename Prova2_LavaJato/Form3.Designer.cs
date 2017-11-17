namespace Prova2_LavaJato
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBusca1 = new System.Windows.Forms.Label();
            this.txtBusca1 = new System.Windows.Forms.TextBox();
            this.lblBusca2 = new System.Windows.Forms.Label();
            this.txtBusca2 = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unitário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(381, 50);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(53, 20);
            this.txtQtd.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(568, 50);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 20);
            this.txtValor.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 442);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Actualizar_Filled_50;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(714, 135);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnEditar, "Atualizar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Lixo_Filled_50;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(714, 173);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(32, 33);
            this.btnExcluir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deletar");
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Mais_Filled_50;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Location = new System.Drawing.Point(714, 100);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(32, 29);
            this.btnIncluir.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(843, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(714, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Quantidade",
            "Valor"});
            this.cbBusca.Location = new System.Drawing.Point(805, 250);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(139, 21);
            this.cbBusca.TabIndex = 13;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.cbBusca_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(803, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 14;
            // 
            // lblBusca1
            // 
            this.lblBusca1.AutoSize = true;
            this.lblBusca1.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca1.Location = new System.Drawing.Point(714, 325);
            this.lblBusca1.Name = "lblBusca1";
            this.lblBusca1.Size = new System.Drawing.Size(0, 18);
            this.lblBusca1.TabIndex = 15;
            this.lblBusca1.Visible = false;
            // 
            // txtBusca1
            // 
            this.txtBusca1.Location = new System.Drawing.Point(803, 323);
            this.txtBusca1.Name = "txtBusca1";
            this.txtBusca1.Size = new System.Drawing.Size(141, 20);
            this.txtBusca1.TabIndex = 16;
            this.txtBusca1.Visible = false;
            // 
            // lblBusca2
            // 
            this.lblBusca2.AutoSize = true;
            this.lblBusca2.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca2.Location = new System.Drawing.Point(714, 402);
            this.lblBusca2.Name = "lblBusca2";
            this.lblBusca2.Size = new System.Drawing.Size(89, 18);
            this.lblBusca2.TabIndex = 17;
            this.lblBusca2.Text = "Menor/igual:";
            this.lblBusca2.Visible = false;
            // 
            // txtBusca2
            // 
            this.txtBusca2.Location = new System.Drawing.Point(803, 400);
            this.txtBusca2.Name = "txtBusca2";
            this.txtBusca2.Size = new System.Drawing.Size(141, 20);
            this.txtBusca2.TabIndex = 18;
            this.txtBusca2.Visible = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Pesquisar_Filled_50;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(860, 448);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(35, 32);
            this.btnBusca.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Cardápio_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(717, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button1, "Preencher Grid");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca2);
            this.Controls.Add(this.lblBusca2);
            this.Controls.Add(this.txtBusca1);
            this.Controls.Add(this.lblBusca1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBusca1;
        private System.Windows.Forms.TextBox txtBusca1;
        private System.Windows.Forms.Label lblBusca2;
        private System.Windows.Forms.TextBox txtBusca2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}