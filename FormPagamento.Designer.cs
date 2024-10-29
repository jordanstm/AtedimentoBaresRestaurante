
namespace AtendimentoBareseRestaurantes
{
    partial class FormPagamento
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
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.listBoxPago = new MaterialSkin.Controls.MaterialListBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.tbPagoAVista = new MaterialSkin.Controls.MaterialTextBox();
            this.tbQuit = new MaterialSkin.Controls.MaterialTextBox();
            this.tbRestoAVista = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCodigo = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTotalVista = new MaterialSkin.Controls.MaterialTextBox();
            this.dgPlanosAVista = new System.Windows.Forms.DataGridView();
            this.btnFiscal = new MaterialSkin.Controls.MaterialButton();
            this.btnNormal = new MaterialSkin.Controls.MaterialButton();
            this.tbCPF = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.CmbImpressoras = new MaterialSkin.Controls.MaterialComboBox();
            this.tbQtdCopias = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.materialExpansionPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanosAVista)).BeginInit();
            this.SuspendLayout();
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.CancelButtonText = "CANCELAR";
            this.materialExpansionPanel1.Collapse = true;
            this.materialExpansionPanel1.Controls.Add(this.groupBox1);
            this.materialExpansionPanel1.Controls.Add(this.btnConfirmar);
            this.materialExpansionPanel1.Controls.Add(this.tbPagoAVista);
            this.materialExpansionPanel1.Controls.Add(this.tbQuit);
            this.materialExpansionPanel1.Controls.Add(this.tbRestoAVista);
            this.materialExpansionPanel1.Controls.Add(this.tbCodigo);
            this.materialExpansionPanel1.Controls.Add(this.tbTotalVista);
            this.materialExpansionPanel1.Controls.Add(this.dgPlanosAVista);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "Selecione os pagamentos a seguir";
            this.materialExpansionPanel1.ExpandHeight = 568;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(6, 80);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.Size = new System.Drawing.Size(542, 48);
            this.materialExpansionPanel1.TabIndex = 0;
            this.materialExpansionPanel1.Title = "Pagamento a Vista";
            this.materialExpansionPanel1.ValidationButtonEnable = true;
            this.materialExpansionPanel1.ValidationButtonText = "SALVAR";
            this.materialExpansionPanel1.Click += new System.EventHandler(this.materialExpansionPanel1_Click);
            this.materialExpansionPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialExpansionPanel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialButton1);
            this.groupBox1.Controls.Add(this.listBoxPago);
            this.groupBox1.Location = new System.Drawing.Point(0, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 198);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(463, 47);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(2);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 11;
            this.materialButton1.Text = "-";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // listBoxPago
            // 
            this.listBoxPago.BackColor = System.Drawing.Color.White;
            this.listBoxPago.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxPago.Depth = 0;
            this.listBoxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxPago.Location = new System.Drawing.Point(6, 22);
            this.listBoxPago.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxPago.Name = "listBoxPago";
            this.listBoxPago.SelectedIndex = -1;
            this.listBoxPago.SelectedItem = null;
            this.listBoxPago.Size = new System.Drawing.Size(453, 170);
            this.listBoxPago.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(422, 252);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(105, 36);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tbPagoAVista
            // 
            this.tbPagoAVista.AnimateReadOnly = false;
            this.tbPagoAVista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPagoAVista.Depth = 0;
            this.tbPagoAVista.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPagoAVista.Hint = "Informado";
            this.tbPagoAVista.LeadingIcon = null;
            this.tbPagoAVista.Location = new System.Drawing.Point(197, 186);
            this.tbPagoAVista.MaxLength = 50;
            this.tbPagoAVista.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPagoAVista.Multiline = false;
            this.tbPagoAVista.Name = "tbPagoAVista";
            this.tbPagoAVista.Size = new System.Drawing.Size(157, 50);
            this.tbPagoAVista.TabIndex = 5;
            this.tbPagoAVista.Text = "";
            this.tbPagoAVista.TrailingIcon = null;
            this.tbPagoAVista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPagoAVista_KeyDown);
            this.tbPagoAVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPagoAVista_KeyPress);
            // 
            // tbQuit
            // 
            this.tbQuit.AnimateReadOnly = true;
            this.tbQuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuit.Depth = 0;
            this.tbQuit.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbQuit.Hint = "Quitado";
            this.tbQuit.LeadingIcon = null;
            this.tbQuit.Location = new System.Drawing.Point(197, 243);
            this.tbQuit.MaxLength = 50;
            this.tbQuit.MouseState = MaterialSkin.MouseState.OUT;
            this.tbQuit.Multiline = false;
            this.tbQuit.Name = "tbQuit";
            this.tbQuit.Size = new System.Drawing.Size(157, 50);
            this.tbQuit.TabIndex = 6;
            this.tbQuit.Text = "";
            this.tbQuit.TrailingIcon = null;
            // 
            // tbRestoAVista
            // 
            this.tbRestoAVista.AnimateReadOnly = false;
            this.tbRestoAVista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRestoAVista.Depth = 0;
            this.tbRestoAVista.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbRestoAVista.Hint = "Resto";
            this.tbRestoAVista.LeadingIcon = null;
            this.tbRestoAVista.Location = new System.Drawing.Point(385, 186);
            this.tbRestoAVista.MaxLength = 50;
            this.tbRestoAVista.MouseState = MaterialSkin.MouseState.OUT;
            this.tbRestoAVista.Multiline = false;
            this.tbRestoAVista.Name = "tbRestoAVista";
            this.tbRestoAVista.Size = new System.Drawing.Size(142, 50);
            this.tbRestoAVista.TabIndex = 6;
            this.tbRestoAVista.Text = "";
            this.tbRestoAVista.TrailingIcon = null;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AnimateReadOnly = false;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCodigo.Depth = 0;
            this.tbCodigo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCodigo.Hint = "Codigo";
            this.tbCodigo.LeadingIcon = null;
            this.tbCodigo.Location = new System.Drawing.Point(20, 243);
            this.tbCodigo.MaxLength = 50;
            this.tbCodigo.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCodigo.Multiline = false;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(161, 50);
            this.tbCodigo.TabIndex = 7;
            this.tbCodigo.Text = "";
            this.tbCodigo.TrailingIcon = null;
            // 
            // tbTotalVista
            // 
            this.tbTotalVista.AnimateReadOnly = false;
            this.tbTotalVista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalVista.Depth = 0;
            this.tbTotalVista.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTotalVista.Hint = "Total devido";
            this.tbTotalVista.LeadingIcon = null;
            this.tbTotalVista.Location = new System.Drawing.Point(20, 187);
            this.tbTotalVista.MaxLength = 50;
            this.tbTotalVista.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTotalVista.Multiline = false;
            this.tbTotalVista.Name = "tbTotalVista";
            this.tbTotalVista.Size = new System.Drawing.Size(161, 50);
            this.tbTotalVista.TabIndex = 7;
            this.tbTotalVista.Text = "";
            this.tbTotalVista.TrailingIcon = null;
            // 
            // dgPlanosAVista
            // 
            this.dgPlanosAVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanosAVista.Location = new System.Drawing.Point(0, 51);
            this.dgPlanosAVista.Name = "dgPlanosAVista";
            this.dgPlanosAVista.Size = new System.Drawing.Size(542, 129);
            this.dgPlanosAVista.TabIndex = 2;
            this.dgPlanosAVista.Click += new System.EventHandler(this.dgPlanosAVista_Click);
            this.dgPlanosAVista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgPlanosAVista_KeyDown);
            // 
            // btnFiscal
            // 
            this.btnFiscal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFiscal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFiscal.Depth = 0;
            this.btnFiscal.HighEmphasis = true;
            this.btnFiscal.Icon = null;
            this.btnFiscal.Location = new System.Drawing.Point(86, 332);
            this.btnFiscal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFiscal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFiscal.Name = "btnFiscal";
            this.btnFiscal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFiscal.Size = new System.Drawing.Size(134, 36);
            this.btnFiscal.TabIndex = 1;
            this.btnFiscal.Text = "Cupom &Fiscal";
            this.btnFiscal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFiscal.UseAccentColor = false;
            this.btnFiscal.UseVisualStyleBackColor = true;
            this.btnFiscal.Click += new System.EventHandler(this.btnFiscal_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNormal.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnNormal.Depth = 0;
            this.btnNormal.HighEmphasis = true;
            this.btnNormal.Icon = null;
            this.btnNormal.Location = new System.Drawing.Point(294, 332);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNormal.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnNormal.Size = new System.Drawing.Size(146, 36);
            this.btnNormal.TabIndex = 1;
            this.btnNormal.Text = "Recibo &Normal";
            this.btnNormal.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnNormal.UseAccentColor = false;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            this.btnNormal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNormal_KeyDown);
            // 
            // tbCPF
            // 
            this.tbCPF.AllowPromptAsInput = true;
            this.tbCPF.AnimateReadOnly = false;
            this.tbCPF.AsciiOnly = false;
            this.tbCPF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCPF.BeepOnError = false;
            this.tbCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbCPF.Depth = 0;
            this.tbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCPF.HidePromptOnLeave = false;
            this.tbCPF.HideSelection = true;
            this.tbCPF.Hint = "Informe o CPF";
            this.tbCPF.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbCPF.LeadingIcon = null;
            this.tbCPF.Location = new System.Drawing.Point(85, 399);
            this.tbCPF.Mask = "";
            this.tbCPF.MaxLength = 32767;
            this.tbCPF.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.PasswordChar = '\0';
            this.tbCPF.PrefixSuffixText = null;
            this.tbCPF.PromptChar = '_';
            this.tbCPF.ReadOnly = false;
            this.tbCPF.RejectInputOnFirstFailure = false;
            this.tbCPF.ResetOnPrompt = true;
            this.tbCPF.ResetOnSpace = true;
            this.tbCPF.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbCPF.SelectedText = "";
            this.tbCPF.SelectionLength = 0;
            this.tbCPF.SelectionStart = 0;
            this.tbCPF.ShortcutsEnabled = true;
            this.tbCPF.Size = new System.Drawing.Size(352, 48);
            this.tbCPF.SkipLiterals = true;
            this.tbCPF.TabIndex = 2;
            this.tbCPF.TabStop = false;
            this.tbCPF.Text = "0";
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbCPF.TrailingIcon = null;
            this.tbCPF.UseSystemPasswordChar = false;
            this.tbCPF.ValidatingType = null;
            this.tbCPF.Visible = false;
            this.tbCPF.Click += new System.EventHandler(this.tbCPF_Click);
            this.tbCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCPF_KeyDown);
            // 
            // CmbImpressoras
            // 
            this.CmbImpressoras.AutoResize = false;
            this.CmbImpressoras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CmbImpressoras.Depth = 0;
            this.CmbImpressoras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CmbImpressoras.DropDownHeight = 174;
            this.CmbImpressoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbImpressoras.DropDownWidth = 121;
            this.CmbImpressoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CmbImpressoras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CmbImpressoras.FormattingEnabled = true;
            this.CmbImpressoras.Hint = "Impressoras Disponiveis";
            this.CmbImpressoras.IntegralHeight = false;
            this.CmbImpressoras.ItemHeight = 43;
            this.CmbImpressoras.Location = new System.Drawing.Point(85, 248);
            this.CmbImpressoras.MaxDropDownItems = 4;
            this.CmbImpressoras.MouseState = MaterialSkin.MouseState.OUT;
            this.CmbImpressoras.Name = "CmbImpressoras";
            this.CmbImpressoras.Size = new System.Drawing.Size(352, 49);
            this.CmbImpressoras.StartIndex = 0;
            this.CmbImpressoras.TabIndex = 3;
            // 
            // tbQtdCopias
            // 
            this.tbQtdCopias.AllowPromptAsInput = true;
            this.tbQtdCopias.AnimateReadOnly = false;
            this.tbQtdCopias.AsciiOnly = false;
            this.tbQtdCopias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbQtdCopias.BeepOnError = false;
            this.tbQtdCopias.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbQtdCopias.Depth = 0;
            this.tbQtdCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbQtdCopias.HidePromptOnLeave = false;
            this.tbQtdCopias.HideSelection = true;
            this.tbQtdCopias.Hint = "Nro.Copias";
            this.tbQtdCopias.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbQtdCopias.LeadingIcon = null;
            this.tbQtdCopias.Location = new System.Drawing.Point(85, 194);
            this.tbQtdCopias.Mask = "";
            this.tbQtdCopias.MaxLength = 32767;
            this.tbQtdCopias.MouseState = MaterialSkin.MouseState.OUT;
            this.tbQtdCopias.Name = "tbQtdCopias";
            this.tbQtdCopias.PasswordChar = '\0';
            this.tbQtdCopias.PrefixSuffixText = null;
            this.tbQtdCopias.PromptChar = '_';
            this.tbQtdCopias.ReadOnly = false;
            this.tbQtdCopias.RejectInputOnFirstFailure = false;
            this.tbQtdCopias.ResetOnPrompt = true;
            this.tbQtdCopias.ResetOnSpace = true;
            this.tbQtdCopias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbQtdCopias.SelectedText = "";
            this.tbQtdCopias.SelectionLength = 0;
            this.tbQtdCopias.SelectionStart = 0;
            this.tbQtdCopias.ShortcutsEnabled = true;
            this.tbQtdCopias.Size = new System.Drawing.Size(114, 48);
            this.tbQtdCopias.SkipLiterals = true;
            this.tbQtdCopias.TabIndex = 4;
            this.tbQtdCopias.TabStop = false;
            this.tbQtdCopias.Text = "1";
            this.tbQtdCopias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbQtdCopias.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbQtdCopias.TrailingIcon = null;
            this.tbQtdCopias.UseSystemPasswordChar = false;
            this.tbQtdCopias.ValidatingType = null;
            // 
            // FormPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 667);
            this.Controls.Add(this.materialExpansionPanel1);
            this.Controls.Add(this.btnFiscal);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.CmbImpressoras);
            this.Controls.Add(this.tbQtdCopias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPagamento";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento";
            this.Load += new System.EventHandler(this.FormPagamento_Load);
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanosAVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private System.Windows.Forms.DataGridView dgPlanosAVista;
        private MaterialSkin.Controls.MaterialButton btnFiscal;
        private MaterialSkin.Controls.MaterialButton btnNormal;
        private MaterialSkin.Controls.MaterialTextBox tbPagoAVista;
        private MaterialSkin.Controls.MaterialTextBox tbRestoAVista;
        private MaterialSkin.Controls.MaterialTextBox tbTotalVista;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialListBox listBoxPago;
        private MaterialSkin.Controls.MaterialTextBox tbQuit;
        private MaterialSkin.Controls.MaterialTextBox tbCodigo;
        private MaterialSkin.Controls.MaterialMaskedTextBox tbCPF;
        private MaterialSkin.Controls.MaterialComboBox CmbImpressoras;
        private MaterialSkin.Controls.MaterialMaskedTextBox tbQtdCopias;
    }
}