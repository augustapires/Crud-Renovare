namespace Crud_Renovare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tstIdBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.labelBuscar = new System.Windows.Forms.ToolStripLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbModalidade = new System.Windows.Forms.ComboBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.cmbQuartos = new System.Windows.Forms.ComboBox();
            this.cmbVagas = new System.Windows.Forms.ComboBox();
            this.cmbBanheiros = new System.Windows.Forms.ComboBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.tsbSalvar,
            this.tsbEditar,
            this.tsbExcluir,
            this.tsbBuscar,
            this.tstIdBuscar,
            this.labelBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(883, 40);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovo
            // 
            this.tsbNovo.AutoSize = false;
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(40, 40);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalvar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvar.Image")));
            this.tsbSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(34, 37);
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(34, 37);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(34, 37);
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.Click += new System.EventHandler(this.tsbExcluir_Click);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(34, 37);
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // tstIdBuscar
            // 
            this.tstIdBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstIdBuscar.Name = "tstIdBuscar";
            this.tstIdBuscar.Size = new System.Drawing.Size(100, 40);
            // 
            // labelBuscar
            // 
            this.labelBuscar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(56, 37);
            this.labelBuscar.Text = "Buscar ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(704, 207);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(250, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(562, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modalidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(562, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Complemento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(371, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(562, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vagas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(228, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Quartos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Área (m²)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(502, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "CEP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(296, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(10, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cidade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(386, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Banheiros";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 15;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Location = new System.Drawing.Point(12, 167);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(325, 23);
            this.txtEndereco.TabIndex = 16;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(375, 167);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);
            this.txtNumero.TabIndex = 17;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Location = new System.Drawing.Point(562, 167);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(300, 23);
            this.txtComplemento.TabIndex = 18;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(10, 247);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(233, 23);
            this.txtCidade.TabIndex = 19;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(12, 322);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 23);
            this.txtArea.TabIndex = 20;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "CASA",
            "APARTAMENTO"});
            this.cmbTipo.Location = new System.Drawing.Point(250, 89);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 23);
            this.cmbTipo.TabIndex = 21;
            // 
            // cmbModalidade
            // 
            this.cmbModalidade.FormattingEnabled = true;
            this.cmbModalidade.Items.AddRange(new object[] {
            "VENDA",
            "LOCAÇÃO"});
            this.cmbModalidade.Location = new System.Drawing.Point(562, 89);
            this.cmbModalidade.Name = "cmbModalidade";
            this.cmbModalidade.Size = new System.Drawing.Size(121, 23);
            this.cmbModalidade.TabIndex = 22;
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(296, 247);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(121, 23);
            this.cmbUf.TabIndex = 23;
            // 
            // cmbQuartos
            // 
            this.cmbQuartos.FormattingEnabled = true;
            this.cmbQuartos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbQuartos.Location = new System.Drawing.Point(228, 322);
            this.cmbQuartos.Name = "cmbQuartos";
            this.cmbQuartos.Size = new System.Drawing.Size(74, 23);
            this.cmbQuartos.TabIndex = 24;
            this.cmbQuartos.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cmbVagas
            // 
            this.cmbVagas.FormattingEnabled = true;
            this.cmbVagas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbVagas.Location = new System.Drawing.Point(562, 324);
            this.cmbVagas.Name = "cmbVagas";
            this.cmbVagas.Size = new System.Drawing.Size(74, 23);
            this.cmbVagas.TabIndex = 25;
            // 
            // cmbBanheiros
            // 
            this.cmbBanheiros.FormattingEnabled = true;
            this.cmbBanheiros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbBanheiros.Location = new System.Drawing.Point(386, 324);
            this.cmbBanheiros.Name = "cmbBanheiros";
            this.cmbBanheiros.Size = new System.Drawing.Size(74, 23);
            this.cmbBanheiros.TabIndex = 26;
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(502, 247);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(100, 23);
            this.mskCep.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 380);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.cmbBanheiros);
            this.Controls.Add(this.cmbVagas);
            this.Controls.Add(this.cmbQuartos);
            this.Controls.Add(this.cmbUf);
            this.Controls.Add(this.cmbModalidade);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNovo;
        private ToolStripButton tsbSalvar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbExcluir;
        private ToolStripButton tsbBuscar;
        private ToolStripTextBox tstIdBuscar;
        private ToolStripLabel labelBuscar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtId;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private TextBox txtArea;
        private ComboBox cmbTipo;
        private ComboBox cmbModalidade;
        private ComboBox cmbUf;
        private ComboBox cmbQuartos;
        private ComboBox cmbVagas;
        private ComboBox cmbBanheiros;
        private MaskedTextBox mskCep;
    }
}