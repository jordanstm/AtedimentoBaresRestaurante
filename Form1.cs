using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using UltrasoftDAO.Controles;
using UltrasoftDAO.Modelos;

namespace AtendimentoBareseRestaurantes
{
    public partial class Form1 : MaterialForm

    {
        public Form1()
        {
            
            InitializeComponent();
            populaModuloEmpresa();
        }
        private string Modulo { get; set; }
        private void BtnInseir_Click(object sender, EventArgs e)
        {
            FrmLancamento lanc = new FrmLancamento();
            lanc.ShowDialog();
            validaModuloSistema();
           
            
        }
        private void validaModuloSistema()
        {
            if (Modulo.Equals("TakeOut-Mesas"))
            {
                populaAtendimentoMesas();
            }
            else
            {
                PopulaAtendimentos();
            }
        }
        private void populaModuloEmpresa()
        {
            Modulo = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["Modulo"].ToString().Trim();
                
        }
        public void PopulaUsuario(string Usuario)
        {
            DAOSQLSERVER.CodigoUsuario = Usuario;
            pegaCodCaixaUsuario();
        }
        private void pegaCodCaixaUsuario()
        {
            DAOSQLSERVER.pegaCodigoCaixaUsuario();
        }
        private async void populaAtendimentoMesas()
        {
            FlowLayoutItens.Controls.Clear();

           // var Lt = DAOSQLSERVER.listaAtendimentos().Result;
            var Mesas = DAOSQLSERVER.ListaMesasQuartos().Result;
           // var listaNaoViewer = await DesobreMesasNaoExibidas(Mesas, Lt);

             foreach(var NotViewer  in Mesas)
            {
                var btn = new Button();
                btn.AutoSize = true;
                btn.AutoSizeMode = AutoSizeMode.GrowOnly;
                btn.Text = NotViewer.Codigo + "\n" + string.Format("{0:dd.MM.yyyy}", DateTime.Now);
                btn.Tag = NotViewer.Codigo;
                
                btn.Click += Btn_Click;
                MudaCorSkin(btn);
                FlowLayoutItens.Controls.Add(btn);
            }

            
        }
      
        private void MudaCorSkin(Button btn)

        {
            bool teste = DAOSQLSERVER.ConteItensnaVenda(btn.Tag.ToString());
             if(teste)
            {
                btn.BackColor = Color.FromArgb(255,200,40,40);
                btn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                btn.ForeColor = Color.FromArgb(255, 250, 250, 230);
            }
            else
            {
                btn.BackColor = Color.Green;
                btn.Font = new Font("Microsoft Sans Serif", 12,FontStyle.Bold);
            }
        }
        private async void PopulaAtendimentos()
        {

            try
            {
                FlowLayoutItens.Controls.Clear();
                //adionabotaocontrole();


                var btnG = new MaterialFloatingActionButton();
                btnG.ImageList = MenuIconList;
                btnG.ImageKey = "plus";
                btnG.Click += BtnG_Click;
                btnG.Icon = AtendimentoBareseRestaurantes.Properties.Resources.plus;
                FlowLayoutItens.Controls.Add(btnG);




                var Lt = DAOSQLSERVER.listaAtendimentos().Result;




                if (Lt.Count > 0)
                {
                    foreach (ViewAtendimento Atend in Lt)
                    {
                        var btn = new MaterialButton();
                        btn.AutoSize = true;
                        btn.AutoSizeMode = AutoSizeMode.GrowOnly;
                        btn.Text = Atend.NomeNota + " | Ch.:" + Atend.CodChamador + "\n" + string.Format("{0:dd.MM.yyyy}", Atend.Data);
                        btn.Tag = Atend.Codigo.ToString();

                        btn.Click += Btn_Click;
                        FlowLayoutItens.Controls.Add(btn);
                    }
                }
                btnG.Select();
                btnG.Focus();
            }
             catch(Exception ex)
            {
                Util.GravaErroLog(ex.Message, "PopulaAtendimentos()");
            }
           
        }
        

        private void BtnG_Click(object sender, EventArgs e)
        {
            FrmLancamento lanc = new FrmLancamento();
            lanc.Modulo = Modulo;
            lanc.ShowDialog();
            
            if (!Modulo.Equals("TakeOut-Mesas"))
                validaModuloSistema();
            
          
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (Modulo.Equals("TakeOut-Mesas"))
            {
                var bet = (sender as Button);
                FrmLancamento lanc = new FrmLancamento();
                lanc.Codigo = bet.Tag.ToString().Trim();
                lanc.Modulo = Modulo;
                lanc.ShowDialog();
               
                    validaModuloSistema();
            }
            else
            {
                var bet = (sender as MaterialButton);
                FrmLancamento lanc = new FrmLancamento();
                lanc.Codigo = bet.Tag.ToString().Trim();
                lanc.Modulo = Modulo;
                lanc.ShowDialog();
               // if (!Modulo.Equals("TakeOut-Mesas"))
                    validaModuloSistema();
            }
            

           
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAOSQLSERVER.AnalisaSkin(this);

            validaModuloSistema();
            
            
        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {
            if (!Modulo.Equals("TakeOut-Mesas"))
                validaModuloSistema();
            //PopulaAtendimentos();
        }

        private void FlowLayoutItens_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
