
namespace AtendimentoBareseRestaurantes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FlowLayoutItens = new System.Windows.Forms.FlowLayoutPanel();
            this.materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.MenuIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.FlowLayoutItens.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.MenuIconList;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(70, 27);
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.FlowLayoutItens);
            this.tabPage4.ImageKey = "round_swap_vert_white_24dp.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(786, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vendas";
            // 
            // FlowLayoutItens
            // 
            this.FlowLayoutItens.Controls.Add(this.materialFloatingActionButton1);
            this.FlowLayoutItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutItens.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutItens.Name = "FlowLayoutItens";
            this.FlowLayoutItens.Size = new System.Drawing.Size(786, 348);
            this.FlowLayoutItens.TabIndex = 0;
            this.FlowLayoutItens.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutItens_Paint);
            // 
            // materialFloatingActionButton1
            // 
            this.materialFloatingActionButton1.Depth = 0;
            this.materialFloatingActionButton1.Icon = null;
            this.materialFloatingActionButton1.Location = new System.Drawing.Point(3, 3);
            this.materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.Size = new System.Drawing.Size(56, 56);
            this.materialFloatingActionButton1.TabIndex = 0;
            this.materialFloatingActionButton1.Text = "materialFloatingActionButton1";
            this.materialFloatingActionButton1.UseVisualStyleBackColor = true;
            // 
            // MenuIconList
            // 
            this.MenuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuIconList.ImageStream")));
            this.MenuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuIconList.Images.SetKeyName(0, "baseline_bluetooth_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(1, "baseline_build_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(2, "baseline_favorite_border_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(3, "baseline_fingerprint_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(4, "baseline_thumb_up_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(5, "minus.png");
            this.MenuIconList.Images.SetKeyName(6, "plus.png");
            this.MenuIconList.Images.SetKeyName(7, "round_add_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(8, "round_assessment_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(9, "round_backup_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(10, "round_bluetooth_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(11, "round_bookmark_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(12, "round_build_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(13, "round_gps_fixed_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(14, "round_http_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(15, "round_phone_black_24dp.png");
            this.MenuIconList.Images.SetKeyName(16, "round_report_problem_white_24dp.png");
            this.MenuIconList.Images.SetKeyName(17, "round_swap_vert_white_24dp.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bares e restaurantes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.FlowLayoutItens.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList MenuIconList;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutItens;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
    }
}

