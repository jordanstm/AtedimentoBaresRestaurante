namespace AtendimentoBareseRestaurantes
{
    partial class FrmConsultaCliente
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
            this.mtbPesquisaCliente = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.listDadosPesquisa = new MaterialSkin.Controls.MaterialListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mtbPesquisaCliente
            // 
            this.mtbPesquisaCliente.AllowPromptAsInput = true;
            this.mtbPesquisaCliente.AnimateReadOnly = false;
            this.mtbPesquisaCliente.AsciiOnly = false;
            this.mtbPesquisaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mtbPesquisaCliente.BeepOnError = false;
            this.mtbPesquisaCliente.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbPesquisaCliente.Depth = 0;
            this.mtbPesquisaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtbPesquisaCliente.HidePromptOnLeave = false;
            this.mtbPesquisaCliente.HideSelection = true;
            this.mtbPesquisaCliente.Hint = "Descricao";
            this.mtbPesquisaCliente.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.mtbPesquisaCliente.LeadingIcon = null;
            this.mtbPesquisaCliente.Location = new System.Drawing.Point(6, 127);
            this.mtbPesquisaCliente.Mask = "";
            this.mtbPesquisaCliente.MaxLength = 32767;
            this.mtbPesquisaCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.mtbPesquisaCliente.Name = "mtbPesquisaCliente";
            this.mtbPesquisaCliente.PasswordChar = '\0';
            this.mtbPesquisaCliente.PrefixSuffixText = null;
            this.mtbPesquisaCliente.PromptChar = '_';
            this.mtbPesquisaCliente.ReadOnly = false;
            this.mtbPesquisaCliente.RejectInputOnFirstFailure = false;
            this.mtbPesquisaCliente.ResetOnPrompt = true;
            this.mtbPesquisaCliente.ResetOnSpace = true;
            this.mtbPesquisaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbPesquisaCliente.SelectedText = "";
            this.mtbPesquisaCliente.SelectionLength = 0;
            this.mtbPesquisaCliente.SelectionStart = 0;
            this.mtbPesquisaCliente.ShortcutsEnabled = true;
            this.mtbPesquisaCliente.Size = new System.Drawing.Size(627, 48);
            this.mtbPesquisaCliente.SkipLiterals = true;
            this.mtbPesquisaCliente.TabIndex = 0;
            this.mtbPesquisaCliente.TabStop = false;
            this.mtbPesquisaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mtbPesquisaCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.mtbPesquisaCliente.TrailingIcon = null;
            this.mtbPesquisaCliente.UseSystemPasswordChar = false;
            this.mtbPesquisaCliente.ValidatingType = null;
            this.mtbPesquisaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbPesquisaCliente_KeyDown);
            // 
            // listDadosPesquisa
            // 
            this.listDadosPesquisa.AutoSizeTable = false;
            this.listDadosPesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listDadosPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listDadosPesquisa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descricao});
            this.listDadosPesquisa.Depth = 0;
            this.listDadosPesquisa.FullRowSelect = true;
            this.listDadosPesquisa.HideSelection = false;
            this.listDadosPesquisa.Location = new System.Drawing.Point(6, 181);
            this.listDadosPesquisa.MinimumSize = new System.Drawing.Size(200, 100);
            this.listDadosPesquisa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listDadosPesquisa.MouseState = MaterialSkin.MouseState.OUT;
            this.listDadosPesquisa.Name = "listDadosPesquisa";
            this.listDadosPesquisa.OwnerDraw = true;
            this.listDadosPesquisa.Size = new System.Drawing.Size(627, 232);
            this.listDadosPesquisa.TabIndex = 1;
            this.listDadosPesquisa.UseCompatibleStateImageBehavior = false;
            this.listDadosPesquisa.View = System.Windows.Forms.View.Tile;
            this.listDadosPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listDadosPesquisa_KeyDown);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 100;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descricao";
            this.Descricao.Width = 560;
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 419);
            this.Controls.Add(this.listDadosPesquisa);
            this.Controls.Add(this.mtbPesquisaCliente);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.FrmConsultaCliente_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox mtbPesquisaCliente;
        private MaterialSkin.Controls.MaterialListView listDadosPesquisa;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descricao;
    }
}