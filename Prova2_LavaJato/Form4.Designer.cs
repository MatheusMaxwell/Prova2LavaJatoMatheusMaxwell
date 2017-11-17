namespace Prova2_LavaJato
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAutomovel = new System.Windows.Forms.ComboBox();
            this.cbFuncResponsavel = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.lblBuscaNome = new System.Windows.Forms.Label();
            this.txtBuscaNome = new System.Windows.Forms.TextBox();
            this.lblTipoBusca = new System.Windows.Forms.Label();
            this.cbTipoBusca = new System.Windows.Forms.ComboBox();
            this.lblFuncBusca = new System.Windows.Forms.Label();
            this.cbFuncBusca = new System.Windows.Forms.ComboBox();
            this.funcionarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblDataFBusca = new System.Windows.Forms.Label();
            this.txtDataFBusca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoLavagem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblTipoLavagem = new System.Windows.Forms.Label();
            this.cbTipoLava = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Automóvel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(414, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(574, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Funcionário Responsável:";
            // 
            // cbAutomovel
            // 
            this.cbAutomovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutomovel.FormattingEnabled = true;
            this.cbAutomovel.Items.AddRange(new object[] {
            "Carro",
            "Caminhão",
            "Moto"});
            this.cbAutomovel.Location = new System.Drawing.Point(140, 7);
            this.cbAutomovel.Name = "cbAutomovel";
            this.cbAutomovel.Size = new System.Drawing.Size(155, 26);
            this.cbAutomovel.TabIndex = 1;
            // 
            // cbFuncResponsavel
            // 
            this.cbFuncResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncResponsavel.FormattingEnabled = true;
            this.cbFuncResponsavel.Location = new System.Drawing.Point(772, 7);
            this.cbFuncResponsavel.Name = "cbFuncResponsavel";
            this.cbFuncResponsavel.Size = new System.Drawing.Size(181, 26);
            this.cbFuncResponsavel.TabIndex = 3;
            // 
            // funcionarioBindingSource3
            // 
            this.funcionarioBindingSource3.DataMember = "Funcionario";
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            // 
            // funcionarioBindingSource1
            // 
            this.funcionarioBindingSource1.DataMember = "Funcionario";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(140, 49);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(268, 24);
            this.txtNomeCliente.TabIndex = 4;
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(468, 7);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(100, 24);
            this.txtTelefoneCliente.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(468, 51);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 24);
            this.txtData.TabIndex = 5;
            this.txtData.Click += new System.EventHandler(this.txtData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(686, 400);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Mais_Filled_50;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Location = new System.Drawing.Point(690, 142);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(29, 27);
            this.btnIncluir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnIncluir, "Incluir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Actualizar_Filled_50;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(690, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(29, 26);
            this.btnEditar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnEditar, "Atualizar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Lixo_Filled_50;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(690, 207);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(29, 26);
            this.btnExcluir.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deletar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(704, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar por:";
            // 
            // cbBusca
            // 
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome Cliente",
            "Tipo Automovel",
            "Funcionario",
            "Data",
            "Tipo Lavagem",
            "Preço"});
            this.cbBusca.Location = new System.Drawing.Point(799, 253);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(154, 21);
            this.cbBusca.TabIndex = 10;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaNome.Location = new System.Drawing.Point(694, 297);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(108, 20);
            this.lblBuscaNome.TabIndex = 16;
            this.lblBuscaNome.Text = "Nome Cliente:";
            this.lblBuscaNome.Visible = false;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.Location = new System.Drawing.Point(800, 299);
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(154, 20);
            this.txtBuscaNome.TabIndex = 17;
            this.txtBuscaNome.Visible = false;
            this.txtBuscaNome.Click += new System.EventHandler(this.txtBuscaNome_Click);
            // 
            // lblTipoBusca
            // 
            this.lblTipoBusca.AutoSize = true;
            this.lblTipoBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoBusca.Location = new System.Drawing.Point(687, 299);
            this.lblTipoBusca.Name = "lblTipoBusca";
            this.lblTipoBusca.Size = new System.Drawing.Size(115, 18);
            this.lblTipoBusca.TabIndex = 18;
            this.lblTipoBusca.Text = "Tipo Automovel:";
            this.lblTipoBusca.Visible = false;
            // 
            // cbTipoBusca
            // 
            this.cbTipoBusca.FormattingEnabled = true;
            this.cbTipoBusca.Items.AddRange(new object[] {
            "Carro",
            "Caminhão",
            "Moto"});
            this.cbTipoBusca.Location = new System.Drawing.Point(799, 300);
            this.cbTipoBusca.Name = "cbTipoBusca";
            this.cbTipoBusca.Size = new System.Drawing.Size(154, 21);
            this.cbTipoBusca.TabIndex = 19;
            this.cbTipoBusca.Visible = false;
            // 
            // lblFuncBusca
            // 
            this.lblFuncBusca.AutoSize = true;
            this.lblFuncBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncBusca.Location = new System.Drawing.Point(698, 299);
            this.lblFuncBusca.Name = "lblFuncBusca";
            this.lblFuncBusca.Size = new System.Drawing.Size(96, 20);
            this.lblFuncBusca.TabIndex = 20;
            this.lblFuncBusca.Text = "Funcionario:";
            this.lblFuncBusca.Visible = false;
            // 
            // cbFuncBusca
            // 
            this.cbFuncBusca.FormattingEnabled = true;
            this.cbFuncBusca.Location = new System.Drawing.Point(799, 300);
            this.cbFuncBusca.Name = "cbFuncBusca";
            this.cbFuncBusca.Size = new System.Drawing.Size(154, 21);
            this.cbFuncBusca.TabIndex = 21;
            this.cbFuncBusca.Visible = false;
            // 
            // funcionarioBindingSource2
            // 
            this.funcionarioBindingSource2.DataMember = "Funcionario";
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Pesquisar_Filled_50;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(853, 392);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(36, 35);
            this.btnBusca.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblDataFBusca
            // 
            this.lblDataFBusca.AutoSize = true;
            this.lblDataFBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblDataFBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFBusca.Location = new System.Drawing.Point(704, 340);
            this.lblDataFBusca.Name = "lblDataFBusca";
            this.lblDataFBusca.Size = new System.Drawing.Size(86, 20);
            this.lblDataFBusca.TabIndex = 23;
            this.lblDataFBusca.Text = "Data Final:";
            this.lblDataFBusca.Visible = false;
            // 
            // txtDataFBusca
            // 
            this.txtDataFBusca.Location = new System.Drawing.Point(800, 342);
            this.txtDataFBusca.Name = "txtDataFBusca";
            this.txtDataFBusca.Size = new System.Drawing.Size(154, 20);
            this.txtDataFBusca.TabIndex = 18;
            this.txtDataFBusca.Visible = false;
            this.txtDataFBusca.Click += new System.EventHandler(this.txtDataFBusca_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tipo Lavagem:";
            // 
            // cbTipoLavagem
            // 
            this.cbTipoLavagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoLavagem.FormattingEnabled = true;
            this.cbTipoLavagem.Items.AddRange(new object[] {
            "Lavegem Completa",
            "Lavagem Fora",
            "Lavagem Dentro",
            "Lavagem e Revisão"});
            this.cbTipoLavagem.Location = new System.Drawing.Point(692, 49);
            this.cbTipoLavagem.Name = "cbTipoLavagem";
            this.cbTipoLavagem.Size = new System.Drawing.Size(197, 26);
            this.cbTipoLavagem.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(140, 95);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(133, 24);
            this.txtPreco.TabIndex = 7;
            // 
            // lblTipoLavagem
            // 
            this.lblTipoLavagem.AutoSize = true;
            this.lblTipoLavagem.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoLavagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLavagem.Location = new System.Drawing.Point(690, 301);
            this.lblTipoLavagem.Name = "lblTipoLavagem";
            this.lblTipoLavagem.Size = new System.Drawing.Size(112, 20);
            this.lblTipoLavagem.TabIndex = 28;
            this.lblTipoLavagem.Text = "Tipo Lavagem:";
            this.lblTipoLavagem.Visible = false;
            // 
            // cbTipoLava
            // 
            this.cbTipoLava.FormattingEnabled = true;
            this.cbTipoLava.Items.AddRange(new object[] {
            "Lavegem Completa",
            "Lavagem Fora",
            "Lavagem Dentro",
            "Lavagem e Revisão"});
            this.cbTipoLava.Location = new System.Drawing.Point(801, 301);
            this.cbTipoLava.Name = "cbTipoLava";
            this.cbTipoLava.Size = new System.Drawing.Size(153, 21);
            this.cbTipoLava.TabIndex = 29;
            this.cbTipoLava.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.icons8_Cardápio_64;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(690, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 27);
            this.button1.TabIndex = 30;
            this.toolTip1.SetToolTip(this.button1, "Preencher Grid");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prova2_LavaJato.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbTipoLava);
            this.Controls.Add(this.lblTipoLavagem);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTipoLavagem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDataFBusca);
            this.Controls.Add(this.lblDataFBusca);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.cbFuncBusca);
            this.Controls.Add(this.lblFuncBusca);
            this.Controls.Add(this.cbTipoBusca);
            this.Controls.Add(this.lblTipoBusca);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.lblBuscaNome);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.cbFuncResponsavel);
            this.Controls.Add(this.cbAutomovel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Lavagem";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAutomovel;
        private System.Windows.Forms.ComboBox cbFuncResponsavel;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtData;
       // private BDLavaJatoDataSet bDLavaJatoDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
       // private BDLavaJatoDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label lblBuscaNome;
        private System.Windows.Forms.TextBox txtBuscaNome;
        private System.Windows.Forms.Label lblTipoBusca;
        private System.Windows.Forms.ComboBox cbTipoBusca;
        private System.Windows.Forms.Label lblFuncBusca;
        private System.Windows.Forms.ComboBox cbFuncBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblDataFBusca;
        private System.Windows.Forms.TextBox txtDataFBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTipoLavagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblTipoLavagem;
        private System.Windows.Forms.ComboBox cbTipoLava;
      //  private BDLavaJatoDataSet1 bDLavaJatoDataSet1;
        private System.Windows.Forms.BindingSource funcionarioBindingSource1;
     //   private BDLavaJatoDataSet1TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter1;
       // private BDLavaJatoDataSet2 bDLavaJatoDataSet2;
        private System.Windows.Forms.BindingSource funcionarioBindingSource2;
     //   private BDLavaJatoDataSet2TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter2;
        private System.Windows.Forms.Button button1;
    //    private BDLavaJatoDataSet3 bDLavaJatoDataSet3;
        private System.Windows.Forms.BindingSource funcionarioBindingSource3;
        private System.Windows.Forms.ToolTip toolTip1;
        //   private BDLavaJatoDataSet3TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter3;
    }
}