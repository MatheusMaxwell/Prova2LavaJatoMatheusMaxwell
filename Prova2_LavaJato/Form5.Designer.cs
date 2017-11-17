namespace Prova2_LavaJato
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.lblBusca1 = new System.Windows.Forms.Label();
            this.txtBusca1 = new System.Windows.Forms.TextBox();
            this.lblBusca2 = new System.Windows.Forms.Label();
            this.txtBusca2 = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbBuscaTipo = new System.Windows.Forms.ComboBox();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(97, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 24);
            this.txtNome.TabIndex = 4;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(468, 22);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(122, 24);
            this.txtValor.TabIndex = 5;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(468, 62);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(286, 71);
            this.txtDescricao.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Material",
            "Outros"});
            this.cbTipo.Location = new System.Drawing.Point(97, 83);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(148, 26);
            this.cbTipo.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(689, 383);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Mais_Filled_50;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Location = new System.Drawing.Point(707, 159);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(35, 31);
            this.btnIncluir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Actualizar_Filled_50;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(707, 196);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(35, 31);
            this.btnEditar.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnEditar, "Atualizar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Lixo_Filled_50;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(707, 233);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 31);
            this.btnExcluir.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deletar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Valor",
            "Tipo"});
            this.cbBusca.Location = new System.Drawing.Point(799, 303);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(152, 21);
            this.cbBusca.TabIndex = 13;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lblBusca1
            // 
            this.lblBusca1.AutoSize = true;
            this.lblBusca1.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca1.Location = new System.Drawing.Point(703, 367);
            this.lblBusca1.Name = "lblBusca1";
            this.lblBusca1.Size = new System.Drawing.Size(0, 20);
            this.lblBusca1.TabIndex = 14;
            // 
            // txtBusca1
            // 
            this.txtBusca1.Location = new System.Drawing.Point(799, 367);
            this.txtBusca1.Name = "txtBusca1";
            this.txtBusca1.Size = new System.Drawing.Size(152, 20);
            this.txtBusca1.TabIndex = 15;
            this.txtBusca1.Visible = false;
            // 
            // lblBusca2
            // 
            this.lblBusca2.AutoSize = true;
            this.lblBusca2.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca2.Location = new System.Drawing.Point(703, 413);
            this.lblBusca2.Name = "lblBusca2";
            this.lblBusca2.Size = new System.Drawing.Size(89, 20);
            this.lblBusca2.TabIndex = 16;
            this.lblBusca2.Text = "Menor que:";
            this.lblBusca2.Visible = false;
            // 
            // txtBusca2
            // 
            this.txtBusca2.Location = new System.Drawing.Point(799, 413);
            this.txtBusca2.Name = "txtBusca2";
            this.txtBusca2.Size = new System.Drawing.Size(152, 20);
            this.txtBusca2.TabIndex = 17;
            this.txtBusca2.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(703, 364);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.Visible = false;
            // 
            // cbBuscaTipo
            // 
            this.cbBuscaTipo.FormattingEnabled = true;
            this.cbBuscaTipo.Items.AddRange(new object[] {
            "Material",
            "Outros"});
            this.cbBuscaTipo.Location = new System.Drawing.Point(799, 366);
            this.cbBuscaTipo.Name = "cbBuscaTipo";
            this.cbBuscaTipo.Size = new System.Drawing.Size(152, 21);
            this.cbBuscaTipo.TabIndex = 19;
            this.cbBuscaTipo.Visible = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Pesquisar_Filled_50;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(862, 472);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(35, 31);
            this.btnBusca.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Cardápio_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(707, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button1, "Preencher Grid");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.cbBuscaTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtBusca2);
            this.Controls.Add(this.lblBusca2);
            this.Controls.Add(this.txtBusca1);
            this.Controls.Add(this.lblBusca1);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Custo/Dispesa";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label lblBusca1;
        private System.Windows.Forms.TextBox txtBusca1;
        private System.Windows.Forms.Label lblBusca2;
        private System.Windows.Forms.TextBox txtBusca2;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbBuscaTipo;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}