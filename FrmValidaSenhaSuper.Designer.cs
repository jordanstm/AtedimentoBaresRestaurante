
namespace AtendimentoBareseRestaurantes
{
    partial class FrmValidaSenhaSuper
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
            this.tbSenha = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.AllowPromptAsInput = true;
            this.tbSenha.AnimateReadOnly = false;
            this.tbSenha.AsciiOnly = false;
            this.tbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbSenha.BeepOnError = false;
            this.tbSenha.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbSenha.Depth = 0;
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.tbSenha.HidePromptOnLeave = false;
            this.tbSenha.HideSelection = true;
            this.tbSenha.Hint = "Senha Supervisor";
            this.tbSenha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbSenha.LeadingIcon = null;
            this.tbSenha.Location = new System.Drawing.Point(122, 123);
            this.tbSenha.Mask = "";
            this.tbSenha.MaxLength = 32767;
            this.tbSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '●';
            this.tbSenha.PrefixSuffixText = null;
            this.tbSenha.PromptChar = '_';
            this.tbSenha.ReadOnly = false;
            this.tbSenha.RejectInputOnFirstFailure = false;
            this.tbSenha.ResetOnPrompt = true;
            this.tbSenha.ResetOnSpace = true;
            this.tbSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSenha.SelectedText = "";
            this.tbSenha.SelectionLength = 0;
            this.tbSenha.SelectionStart = 0;
            this.tbSenha.ShortcutsEnabled = true;
            this.tbSenha.Size = new System.Drawing.Size(579, 48);
            this.tbSenha.SkipLiterals = true;
            this.tbSenha.TabIndex = 0;
            this.tbSenha.TabStop = false;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSenha.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbSenha.TrailingIcon = null;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.ValidatingType = null;
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.HighEmphasis = true;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(543, 201);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConfirmar.Size = new System.Drawing.Size(158, 47);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConfirmar.UseAccentColor = false;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FrmValidaSenhaSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbSenha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValidaSenhaSuper";
            this.Text = "Validação Senha";
            this.Load += new System.EventHandler(this.FrmValidaSenhaSuper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox tbSenha;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
    }
}