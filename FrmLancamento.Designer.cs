
namespace AtendimentoBareseRestaurantes
{
    partial class FrmLancamento
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
            this.lblTotalItens = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnRemove = new MaterialSkin.Controls.MaterialButton();
            this.tbNomeNota = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.dgItensLancados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInicio = new MaterialSkin.Controls.MaterialButton();
            this.btnFin = new MaterialSkin.Controls.MaterialButton();
            this.btnTiket = new MaterialSkin.Controls.MaterialButton();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblDesconto = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotalLiquido = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblGarcon = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tbDesconto = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.tbSeqChamado = new MaterialSkin.Controls.MaterialTextBox();
            this.tbDescMax = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPesquisa = new MaterialSkin.Controls.MaterialTextBox();
            this.tbID = new MaterialSkin.Controls.MaterialTextBox();
            this.tbAcrescimo = new MaterialSkin.Controls.MaterialTextBox();
            this.btnImprimir = new MaterialSkin.Controls.MaterialButton();
            this.mtbCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.mtbOBS = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgItensLancados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalItens
            // 
            this.lblTotalItens.AutoSize = true;
            this.lblTotalItens.Depth = 0;
            this.lblTotalItens.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalItens.Location = new System.Drawing.Point(937, 645);
            this.lblTotalItens.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalItens.Name = "lblTotalItens";
            this.lblTotalItens.Size = new System.Drawing.Size(5, 19);
            this.lblTotalItens.TabIndex = 8;
            this.lblTotalItens.Text = ".";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(34, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemove.Depth = 0;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.HighEmphasis = true;
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(669, 302);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemove.Size = new System.Drawing.Size(64, 36);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "-";
            this.btnRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemove.UseAccentColor = false;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbNomeNota
            // 
            this.tbNomeNota.AnimateReadOnly = false;
            this.tbNomeNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomeNota.Depth = 0;
            this.tbNomeNota.Enabled = false;
            this.tbNomeNota.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNomeNota.Hint = "Nome para Nota";
            this.tbNomeNota.LeadingIcon = null;
            this.tbNomeNota.Location = new System.Drawing.Point(20, 98);
            this.tbNomeNota.MaxLength = 50;
            this.tbNomeNota.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNomeNota.Multiline = false;
            this.tbNomeNota.Name = "tbNomeNota";
            this.tbNomeNota.Size = new System.Drawing.Size(306, 50);
            this.tbNomeNota.TabIndex = 0;
            this.tbNomeNota.Text = "";
            this.tbNomeNota.TrailingIcon = null;
            this.tbNomeNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNomeNota_KeyDown);
            this.tbNomeNota.Leave += new System.EventHandler(this.tbNomeNota_Leave);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigo.AnimateReadOnly = false;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigo.Hint = "Codigo";
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(1002, 67);
            this.tbCodigo.MaxLength = 50;
            this.tbCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigo.Multiline = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(80, 50);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.Text = "";
            this.tbCodigo.TrailingIcon = null;
            // 
            // dgItensLancados
            // 
            this.dgItensLancados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgItensLancados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgItensLancados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItensLancados.Location = new System.Drawing.Point(8, 33);
            this.dgItensLancados.Name = "dgItensLancados";
            this.dgItensLancados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItensLancados.Size = new System.Drawing.Size(1039, 176);
            this.dgItensLancados.TabIndex = 5;
            this.dgItensLancados.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItensLancados_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgItensLancados);
            this.groupBox1.Location = new System.Drawing.Point(20, 425);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 217);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ItensLançados";
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInicio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnInicio.Depth = 0;
            this.btnInicio.HighEmphasis = true;
            this.btnInicio.Icon = null;
            this.btnInicio.Location = new System.Drawing.Point(532, 24);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnInicio.Size = new System.Drawing.Size(73, 36);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "&Inicio";
            this.btnInicio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInicio.UseAccentColor = false;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnFin.Depth = 0;
            this.btnFin.HighEmphasis = true;
            this.btnFin.Icon = null;
            this.btnFin.Location = new System.Drawing.Point(761, 24);
            this.btnFin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFin.Name = "btnFin";
            this.btnFin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFin.Size = new System.Drawing.Size(64, 36);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "&FIM";
            this.btnFin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFin.UseAccentColor = false;
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // btnTiket
            // 
            this.btnTiket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTiket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTiket.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnTiket.Depth = 0;
            this.btnTiket.HighEmphasis = true;
            this.btnTiket.Icon = null;
            this.btnTiket.Location = new System.Drawing.Point(639, 24);
            this.btnTiket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTiket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTiket.Name = "btnTiket";
            this.btnTiket.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTiket.Size = new System.Drawing.Size(70, 36);
            this.btnTiket.TabIndex = 6;
            this.btnTiket.Text = "&Tiket";
            this.btnTiket.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTiket.UseAccentColor = false;
            this.btnTiket.UseVisualStyleBackColor = true;
            this.btnTiket.Click += new System.EventHandler(this.btnTiket_Click);
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPesquisa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgPesquisa.Location = new System.Drawing.Point(20, 283);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.ReadOnly = true;
            this.dgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisa.ShowCellErrors = false;
            this.dgPesquisa.ShowRowErrors = false;
            this.dgPesquisa.Size = new System.Drawing.Size(805, 160);
            this.dgPesquisa.TabIndex = 4;
            this.dgPesquisa.VirtualMode = true;
            this.dgPesquisa.Visible = false;
            this.dgPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPesquisa_KeyDown);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Total";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(104, 32);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 19);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0,00";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(6, 70);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Desconto";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Depth = 0;
            this.lblDesconto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDesconto.Location = new System.Drawing.Point(104, 70);
            this.lblDesconto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(31, 19);
            this.lblDesconto.TabIndex = 3;
            this.lblDesconto.Text = "0,00";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(6, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "T.Liquido";
            // 
            // lblTotalLiquido
            // 
            this.lblTotalLiquido.AutoSize = true;
            this.lblTotalLiquido.Depth = 0;
            this.lblTotalLiquido.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalLiquido.Location = new System.Drawing.Point(104, 141);
            this.lblTotalLiquido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotalLiquido.Name = "lblTotalLiquido";
            this.lblTotalLiquido.Size = new System.Drawing.Size(31, 19);
            this.lblTotalLiquido.TabIndex = 5;
            this.lblTotalLiquido.Text = "0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblGarcon);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.lblTotalLiquido);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.lblDesconto);
            this.groupBox2.Controls.Add(this.materialLabel2);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.materialLabel1);
            this.groupBox2.Location = new System.Drawing.Point(833, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 170);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totais";
            // 
            // lblGarcon
            // 
            this.lblGarcon.AutoSize = true;
            this.lblGarcon.Depth = 0;
            this.lblGarcon.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblGarcon.Location = new System.Drawing.Point(104, 107);
            this.lblGarcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGarcon.Name = "lblGarcon";
            this.lblGarcon.Size = new System.Drawing.Size(31, 19);
            this.lblGarcon.TabIndex = 7;
            this.lblGarcon.Text = "0,00";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(6, 107);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Garçon";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDesconto.AnimateReadOnly = false;
            this.tbDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDesconto.Depth = 0;
            this.tbDesconto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDesconto.Hint = "Desconto ( R$ / % )";
            this.tbDesconto.LeadingIcon = null;
            this.tbDesconto.Location = new System.Drawing.Point(644, 228);
            this.tbDesconto.MaxLength = 50;
            this.tbDesconto.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDesconto.Multiline = false;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(181, 50);
            this.tbDesconto.TabIndex = 1;
            this.tbDesconto.Text = "";
            this.tbDesconto.TrailingIcon = null;
            this.tbDesconto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDesconto_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(842, 24);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(105, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbSeqChamado
            // 
            this.tbSeqChamado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSeqChamado.AnimateReadOnly = false;
            this.tbSeqChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeqChamado.Depth = 0;
            this.tbSeqChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSeqChamado.Hint = "Sequência Chamado";
            this.tbSeqChamado.LeadingIcon = null;
            this.tbSeqChamado.Location = new System.Drawing.Point(906, 119);
            this.tbSeqChamado.MaxLength = 50;
            this.tbSeqChamado.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSeqChamado.Multiline = false;
            this.tbSeqChamado.Name = "tbSeqChamado";
            this.tbSeqChamado.Size = new System.Drawing.Size(176, 50);
            this.tbSeqChamado.TabIndex = 1;
            this.tbSeqChamado.Text = "0";
            this.tbSeqChamado.TrailingIcon = null;
            this.tbSeqChamado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSeqChamado_KeyDown);
            this.tbSeqChamado.Leave += new System.EventHandler(this.tbSeqChamado_Leave);
            // 
            // tbDescMax
            // 
            this.tbDescMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescMax.AnimateReadOnly = false;
            this.tbDescMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescMax.Depth = 0;
            this.tbDescMax.Enabled = false;
            this.tbDescMax.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbDescMax.Hint = "Desconto Maximo";
            this.tbDescMax.LeadingIcon = null;
            this.tbDescMax.Location = new System.Drawing.Point(906, 169);
            this.tbDescMax.MaxLength = 50;
            this.tbDescMax.MouseState = MaterialSkin.MouseState.OUT;
            this.tbDescMax.Multiline = false;
            this.tbDescMax.Name = "tbDescMax";
            this.tbDescMax.Size = new System.Drawing.Size(176, 50);
            this.tbDescMax.TabIndex = 1;
            this.tbDescMax.Text = "";
            this.tbDescMax.TrailingIcon = null;
            this.tbDescMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbTempoMedio_KeyDown);
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPesquisa.AnimateReadOnly = false;
            this.tbPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPesquisa.Depth = 0;
            this.tbPesquisa.Enabled = false;
            this.tbPesquisa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPesquisa.Hint = "Produto";
            this.tbPesquisa.LeadingIcon = null;
            this.tbPesquisa.Location = new System.Drawing.Point(20, 175);
            this.tbPesquisa.MaxLength = 50;
            this.tbPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPesquisa.Multiline = false;
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(805, 50);
            this.tbPesquisa.TabIndex = 2;
            this.tbPesquisa.Text = "";
            this.tbPesquisa.TrailingIcon = global::AtendimentoBareseRestaurantes.Properties.Resources.baseline_fingerprint_black_24dp;
            this.tbPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisa_KeyDown);
            // 
            // tbID
            // 
            this.tbID.AnimateReadOnly = true;
            this.tbID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbID.Depth = 0;
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbID.Hint = "id";
            this.tbID.LeadingIcon = null;
            this.tbID.Location = new System.Drawing.Point(332, 98);
            this.tbID.MaxLength = 50;
            this.tbID.MouseState = MaterialSkin.MouseState.OUT;
            this.tbID.Multiline = false;
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(117, 50);
            this.tbID.TabIndex = 12;
            this.tbID.Text = "0";
            this.tbID.TrailingIcon = null;
            // 
            // tbAcrescimo
            // 
            this.tbAcrescimo.AnimateReadOnly = false;
            this.tbAcrescimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAcrescimo.Depth = 0;
            this.tbAcrescimo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAcrescimo.Hint = "%Acresc";
            this.tbAcrescimo.LeadingIcon = null;
            this.tbAcrescimo.Location = new System.Drawing.Point(906, 67);
            this.tbAcrescimo.MaxLength = 50;
            this.tbAcrescimo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAcrescimo.Multiline = false;
            this.tbAcrescimo.Name = "tbAcrescimo";
            this.tbAcrescimo.Size = new System.Drawing.Size(90, 50);
            this.tbAcrescimo.TabIndex = 13;
            this.tbAcrescimo.Text = "";
            this.tbAcrescimo.TrailingIcon = null;
            this.tbAcrescimo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAcrescimo_KeyDown);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = null;
            this.btnImprimir.Location = new System.Drawing.Point(984, 24);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnImprimir.Size = new System.Drawing.Size(97, 36);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // mtbCliente
            // 
            this.mtbCliente.AllowPromptAsInput = true;
            this.mtbCliente.AnimateReadOnly = false;
            this.mtbCliente.AsciiOnly = false;
            this.mtbCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbCliente.BeepOnError = false;
            this.mtbCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbCliente.Depth = 0;
            this.mtbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCliente.HidePromptOnLeave = false;
            this.mtbCliente.HideSelection = true;
            this.mtbCliente.Hint = "Cliente";
            this.mtbCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtbCliente.LeadingIcon = null;
            this.mtbCliente.Location = new System.Drawing.Point(471, 100);
            this.mtbCliente.Mask = "";
            this.mtbCliente.MaxLength = 32767;
            this.mtbCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbCliente.Name = "mtbCliente";
            this.mtbCliente.PasswordChar = '\0';
            this.mtbCliente.PrefixSuffixText = null;
            this.mtbCliente.PromptChar = '_';
            this.mtbCliente.ReadOnly = false;
            this.mtbCliente.RejectInputOnFirstFailure = false;
            this.mtbCliente.ResetOnPrompt = true;
            this.mtbCliente.ResetOnSpace = true;
            this.mtbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbCliente.SelectedText = "";
            this.mtbCliente.SelectionLength = 0;
            this.mtbCliente.SelectionStart = 0;
            this.mtbCliente.ShortcutsEnabled = true;
            this.mtbCliente.Size = new System.Drawing.Size(354, 48);
            this.mtbCliente.SkipLiterals = true;
            this.mtbCliente.TabIndex = 15;
            this.mtbCliente.TabStop = false;
            this.mtbCliente.Text = "1";
            this.mtbCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbCliente.TrailingIcon = null;
            this.mtbCliente.UseSystemPasswordChar = false;
            this.mtbCliente.ValidatingType = null;
            this.mtbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbCliente_KeyDown);
            this.mtbCliente.Leave += new System.EventHandler(this.mtbCliente_Leave);
            // 
            // mtbOBS
            // 
            this.mtbOBS.AllowPromptAsInput = true;
            this.mtbOBS.AnimateReadOnly = false;
            this.mtbOBS.AsciiOnly = false;
            this.mtbOBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbOBS.BeepOnError = false;
            this.mtbOBS.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbOBS.Depth = 0;
            this.mtbOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbOBS.HidePromptOnLeave = false;
            this.mtbOBS.HideSelection = true;
            this.mtbOBS.Hint = "Observação";
            this.mtbOBS.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtbOBS.LeadingIcon = null;
            this.mtbOBS.Location = new System.Drawing.Point(105, 228);
            this.mtbOBS.Mask = "";
            this.mtbOBS.MaxLength = 32767;
            this.mtbOBS.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbOBS.Name = "mtbOBS";
            this.mtbOBS.PasswordChar = '\0';
            this.mtbOBS.PrefixSuffixText = null;
            this.mtbOBS.PromptChar = '_';
            this.mtbOBS.ReadOnly = false;
            this.mtbOBS.RejectInputOnFirstFailure = false;
            this.mtbOBS.ResetOnPrompt = true;
            this.mtbOBS.ResetOnSpace = true;
            this.mtbOBS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbOBS.SelectedText = "";
            this.mtbOBS.SelectionLength = 0;
            this.mtbOBS.SelectionStart = 0;
            this.mtbOBS.ShortcutsEnabled = true;
            this.mtbOBS.Size = new System.Drawing.Size(524, 48);
            this.mtbOBS.SkipLiterals = true;
            this.mtbOBS.TabIndex = 16;
            this.mtbOBS.TabStop = false;
            this.mtbOBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbOBS.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbOBS.TrailingIcon = null;
            this.mtbOBS.UseSystemPasswordChar = false;
            this.mtbOBS.ValidatingType = null;
            this.mtbOBS.Click += new System.EventHandler(this.materialMaskedTextBox1_Click);
            this.mtbOBS.Leave += new System.EventHandler(this.mtbOBS_Leave);
            // 
            // FrmLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 669);
            this.Controls.Add(this.mtbOBS);
            this.Controls.Add(this.mtbCliente);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.tbAcrescimo);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgPesquisa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalItens);
            this.Controls.Add(this.btnTiket);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.tbDescMax);
            this.Controls.Add(this.tbSeqChamado);
            this.Controls.Add(this.tbDesconto);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNomeNota);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmLancamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lancamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLancamento_FormClosing);
            this.Load += new System.EventHandler(this.FrmLancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgItensLancados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTotalItens;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnRemove;
        private MaterialSkin.Controls.MaterialTextBox tbNomeNota;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private MaterialSkin.Controls.MaterialTextBox tbPesquisa;
        private System.Windows.Forms.DataGridView dgItensLancados;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnInicio;
        private MaterialSkin.Controls.MaterialButton btnFin;
        private MaterialSkin.Controls.MaterialButton btnTiket;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblDesconto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblTotalLiquido;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox tbDesconto;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox tbSeqChamado;
        private MaterialSkin.Controls.MaterialTextBox tbDescMax;
        private MaterialSkin.Controls.MaterialLabel lblGarcon;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox tbID;
        private MaterialSkin.Controls.MaterialTextBox tbAcrescimo;
        private MaterialSkin.Controls.MaterialButton btnImprimir;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtbCliente;
        private MaterialSkin.Controls.MaterialMaskedTextBox mtbOBS;
    }
}