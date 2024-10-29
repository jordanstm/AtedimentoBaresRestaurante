using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using UltrasoftDAO.Controles;
using UltrasoftDAO.Modelos;

namespace AtendimentoBareseRestaurantes
{
    public partial class FormPagamento :MaterialForm
    {
        public FormPagamento()
        {
            InitializeComponent();
        }
        private void PopulaPlanosAvista()
        {
            var lista =DAOSQLSERVER.PlanosVenda(true);
            dgPlanosAVista.DataSource = lista;
            DAOSQLSERVER.FormataGridTema(dgPlanosAVista, "Dark",7,20);
            ajustaGrid(dgPlanosAVista);
            dgPlanosAVista.Focus();
            if (dgPlanosAVista.Rows.Count > 0)
            {
                dgPlanosAVista.Select();
                dgPlanosAVista.Rows[0].Selected = true;
            }
        
        }
      
        
        private void FormPagamento_Load(object sender, EventArgs e)
        {
            populaPlanos();
            materialExpansionPanel1.Height = 522;
            DAOSQLSERVER.AnalisaSkin(this);
            PopulaViewParcelamento();
            PoulaImpressorrasnoCombo();
            
        }
       
        private void populaPlanos()
        {
            PopulaPlanosAvista();
            
        }
        private void ajustaGrid(DataGridView Dt)
        {

            Dt.Columns["Descricao"].Width = 450;
            Dt.Columns["Codigo"].Width = 90;
            Dt.Columns["CentroCusto"].Width = 0;


        }
        public  string Modulo { get; set; }
        public decimal Servico { get; set; }
       
        public string Comprador { get; set; }
        private void btnNormal_Click(object sender, EventArgs e)
        {
            ImprimeCupomNormal();
        }
        private void ImprimeCupomNormal()

        {
            string CaminhoLogoNfe = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoLogoNfe"].ToString().Trim();
            string Chamador= DAOSQLSERVER.CodigoChamado(tbCodigo.Text);
            string NomeComprador = Modulo.Equals("TakeOut")? DAOSQLSERVER.PegaNomeComprador(tbCodigo.Text): Comprador;
            string Total =tbQuit.Text.Length>0? tbQuit.Text.Replace(",", "."):"0";
            
            bool Bar = Modulo.Equals("TakeOut") ? false : true;
            ImpressaoUltra.Impressao Imp = new ImpressaoUltra.Impressao();
            byte[] logo = UltrasoftDAO.Controles.Util.ImageFromAraybyte(DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoLogoNFE"].ToString().Trim());
            string ChavePix = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["ChavePix"].ToString().Trim();
            byte[] QRCode = UltrasoftDAO.Controles.Util.ImageFromAraybyte(DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoImgQrCode"].ToString().Trim());
            DAOSQLSERVER.FontePedidoPdvVendaRetaguarda(0, Convert.ToInt32(tbCodigo.Text), Convert.ToDecimal(Total));
            Imp.ImpressaoPdvRetaGuarda(CmbImpressoras.Text, DAOSQLSERVER.DatasetGenerico, int.Parse(tbQtdCopias.Text), false,Chamador,NomeComprador,logo,QRCode,ChavePix,Bar,Servico);
            this.Close();
        }

        private void btnFiscal_Click(object sender, EventArgs e)
        {
            tbCPF.Visible = true;
            emite();
        }

        private void emite()
        {
            
            tbCPF.SelectAll();
            tbCPF.Focus();
        }
        private void materialExpansionPanel1_Click(object sender, EventArgs e)
        {
            materialExpansionPanel1.Height = 568;
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTotalPrazo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgPlanosAVista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgPlanosAVista.SelectedRows.Count > 0)
                {
                    PegaDadosClicados();
                    tbPagoAVista.SelectAll();
                    tbPagoAVista.Focus();
                }
                
            }
        }
        private void PegaDadosClicados()
        {
            CentroCusto = dgPlanosAVista.SelectedRows[0].Cells["Centrocusto"].Value.ToString().Trim();
            CodigoPlano = dgPlanosAVista.SelectedRows[0].Cells["Codigo"].Value.ToString().Trim();
        }
        private string CentroCusto { get; set; }
        private string CodigoPlano { get; set; }
        private string CodigoVenda { get; set; }
        public void poulaTotal(string Valor)
        {
            tbTotalVista.Text = Valor;
           
        }
        public void PopulaCodigoVenda(string Codigo)
        {
            CodigoVenda = Codigo;
            tbCodigo.Text = Codigo;
           
        }
        private List<decimal> ListaPagos = new List<decimal>();

        private void calculaPagamento()
        {

            decimal TotalVenda = Convert.ToDecimal(tbTotalVista.Text.Substring(2));
            decimal Totalpago = ListaPagos.Sum();//Olhando Pro banco 
            decimal TotalInformado = Convert.ToDecimal(tbPagoAVista.Text);
            if (Totalpago < TotalInformado)
            {
                if (TotalInformado == TotalVenda)
                {
                    tbRestoAVista.Hint = "Resto";
                    tbRestoAVista.Text = "0";
                    tbQuit.Text = TotalInformado.ToString();
                }
                else
                {
                     if(TotalInformado > TotalVenda)
                    {
                        tbRestoAVista.Hint = "Troco";
                        tbRestoAVista.Text = Math.Round((TotalInformado - TotalVenda),2).ToString();
                        tbQuit.Text = TotalVenda.ToString();
                    }
                    if (TotalVenda > TotalInformado)
                    {
                        if (Totalpago < TotalVenda)
                        {
                            decimal SomaPagos = Math.Round((Totalpago + TotalInformado), 2);
                            if(SomaPagos== TotalVenda)
                            {
                                tbRestoAVista.Hint = "Resto";
                                tbRestoAVista.Text = "0";
                                tbQuit.Text = SomaPagos.ToString();
                            }
                            if (SomaPagos < TotalVenda)
                            {
                                tbRestoAVista.Hint = "Resto";
                                tbRestoAVista.Text =(TotalVenda - SomaPagos).ToString() ;
                                tbQuit.Text = SomaPagos.ToString();
                            }
                        }
                        else
                        {
                            decimal Resto = Math.Round((TotalVenda - TotalInformado), 2);
                            tbRestoAVista.Hint = "Resto";
                            tbRestoAVista.Text = Resto.ToString();
                            tbQuit.Text = TotalInformado.ToString();
                        }
                        
                    }
                }

                
                
                //DAOSQLSERVER.AtualisaTotaisVenda(tbCodigo.Text, tbTotalVista.Text.Substring(2));
                tbPagoAVista.Focus();
            }
            else
            {
                if(Totalpago== TotalInformado)
                 
                {
                    decimal Soma = Math.Round(Totalpago+ TotalInformado);
                     if(Soma== TotalVenda)
                    {
                        tbRestoAVista.Text = "0"; //Math.Round((TotalInformado - Totalpago), 2).ToString();
                        tbQuit.Text = TotalVenda.ToString();
                        tbRestoAVista.Hint = "Resto";
                        btnConfirmar.Focus();
                    }
                    if (Soma < TotalVenda)
                    {
                        tbRestoAVista.Text = Math.Round((TotalVenda - Soma), 2).ToString();
                        tbQuit.Text = Soma.ToString();
                        tbRestoAVista.Hint = "Resto";
                        btnConfirmar.Focus();
                    }
                    
                    
                  //  DAOSQLSERVER.AtualisaTotaisVenda(tbCodigo.Text, tbTotalVista.Text.Substring(2));
                }
                else
                {
                    if(Totalpago > TotalInformado)
                    {
                        decimal Soma = Math.Round((TotalInformado + Totalpago), 2);
                         if(Soma == TotalVenda)
                        {
                            tbRestoAVista.Text = "0";
                            tbQuit.Text = Soma.ToString();
                            tbRestoAVista.Hint = "Resto";
                            btnConfirmar.Focus();
                        }
                         if(Soma< TotalVenda)
                        {
                            tbRestoAVista.Text = (TotalVenda- Soma).ToString();
                            tbQuit.Text = Soma.ToString();
                            tbRestoAVista.Hint = "Resto";
                            btnConfirmar.Focus();
                        }
                        
                        
                    //    DAOSQLSERVER.AtualisaTotaisVenda(tbCodigo.Text, tbTotalVista.Text.Substring(2));
                    }
                     
                }
            }
          
        }

        private void tbPagoAVista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPagoAVista.Text.Length > 0)
                {
                    calculaPagamento();
                    btnConfirmar.Focus();
                    
                }
                else
                {
                    MessageBox.Show("Você precisa informar algum valor;");
                }
                

            }
        }
        private void PopulaViewParcelamento()
        {
            ListaPagos.Clear();
            listBoxPago.Items.Clear();
            var lista= DAOSQLSERVER.ListaParcelamento(CodigoVenda, "");
             foreach(Parcelamentos Parc in lista)
             {
                string Codigo = Parc.Plano.ToString();
                string Nomeplano = PegaDescricaoItem(Codigo).Descricao;
                ListaPagos.Add(Convert.ToDecimal(Parc.ValorParc));
                listBoxPago.Items.Add(new MaterialSkin.MaterialListBoxItem {Tag=Parc.Codigo, Text=Nomeplano+"  | "+Parc.ValorParc });
                tbQuit.Text = ListaPagos.Sum().ToString();
               
             }
            
              if(ListaPagos.Sum()< Convert.ToDecimal(tbTotalVista.Text.Substring(2)))
            {
                materialExpansionPanel1.Collapse = false;
            }
            else
            {
                materialExpansionPanel1.Collapse = true;
            }
        }
        private PlanosPGTO PegaDescricaoItem(string Codigo)
        {
            var lt=DAOSQLSERVER.ListaPlano().Where(D => D.Codigo.Equals(Codigo)).ToList();
            return lt[0];
        }
        private int ContEnter { get; set; }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            decimal val = tbPagoAVista.Text.Length>0? Convert.ToDecimal(tbPagoAVista.Text):0;
            decimal Total = Convert.ToDecimal(tbTotalVista.Text.Substring(2));
            decimal quitado = tbQuit.Text.Length>0? Convert.ToDecimal(tbQuit.Text):0;
            if (val <= Total)
            {


                if (CodigoPlano == null)
                {
                    MessageBox.Show("Você precisa selecionar  algum meio de pagamento ");
                }
                else
                {
                     if(quitado< Total || quitado== Total)
                    IsereParcelamentos(CodigoPlano, tbTotalVista.Text, tbPagoAVista.Text);
                 
                }
                
                                         
                

            }
            else
            {
                decimal diferenca =  val - Total;
                decimal ValorPago = val;
                tbRestoAVista.Hint = "Troco";
                //tbRestoAVista.Text = diferenca.ToString();
                tbQuit.Text = tbTotalVista.Text.Substring(2);
                if (quitado < Total || quitado == Total)
                {
                    IsereParcelamentos(CodigoPlano, tbTotalVista.Text, tbTotalVista.Text.Substring(2));

                    ContEnter++;
                }
                
            }
            PoulaImpressorrasnoCombo();
            tbPagoAVista.Text = "0";
            AnalisabtnConfirmar();
            btnNormal.Focus();
        }
        private void IsereParcelamentos(string Plano,string Total,string Parcela)
        {
            string To = string.Empty;
            string Parc = string.Empty;
            To = Total.Substring(2).Trim();
            Parc = Parcela;
          
            DAOSQLSERVER.InsereParcelamentos(tbCodigo.Text, Plano, Parc, To);
            InsereNoCaixa(Parc, Plano);
            PopulaViewParcelamento();
        }
        private void InsereNoCaixa(string VAlor,string plano)
        {
            string Valor = VAlor;
            string Data = string.Format("{0:MM.dd.yyyy}", DateTime.Now);
            string CentroCusto = DAOSQLSERVER.ListaPlano().Where(c => c.Codigo.Equals(plano)).ToList()[0].CentroCusto;
                 switch (CentroCusto)
            {
                case "1":
                    DAOSQLSERVER.InsereLancCaixa(tbCodigo.Text, Valor, Data, tbCodigo.Text, "0", DAOSQLSERVER.ContaCaixaUsuario, "Parcial", CentroCusto, 0);
                    break;
                case "3":
                    DAOSQLSERVER.InsereLancCaixa(tbCodigo.Text, Valor, Data, tbCodigo.Text, "0", DAOSQLSERVER.ContaCaixaUsuario, "Parcial", CentroCusto, 0);
                    DAOSQLSERVER.InsereLancCaixa(tbCodigo.Text, "0", Data, tbCodigo.Text, Valor, DAOSQLSERVER.ContaCaixaUsuario, "Parcial", CentroCusto, 0);
                    break;
                case "4":
                    DAOSQLSERVER.InsereLancCaixa(tbCodigo.Text, Valor, Data, tbCodigo.Text, "0", DAOSQLSERVER.ContaCaixaUsuario, "Parcial", CentroCusto, 0);
                    DAOSQLSERVER.InsereLancCaixa(tbCodigo.Text, "0", Data, tbCodigo.Text, Valor, DAOSQLSERVER.ContaCaixaUsuario, "Parcial", CentroCusto, 0);
                    break;
            }
            
        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            RemoveItem();
        }
        private void RemoveItem()
        {
            if (listBoxPago.SelectedItem!= null)
            {
                
                string Codigo = listBoxPago.SelectedItem.Tag.ToString();
                DAOSQLSERVER.RemoveItemParcelamentoLancado(Codigo);
                ListaPagos.Clear();
                //calculaPagamento();
                PopulaViewParcelamento();
                AnalisabtnConfirmar();
                tbQuit.Text = "0";
            }

        }

        private void dgPlanosAVista_Click(object sender, EventArgs e)
        {
            PegaDadosClicados();
        }

        private void tbCPF_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_2(object sender, EventArgs e)
        {

        }
         private void PoulaImpressorrasnoCombo()
        {
            CmbImpressoras.DataSource = DAOSQLSERVER.impressorasSistema();
        }
        private void AnalisabtnConfirmar()
        {
            decimal qt = Convert.ToDecimal(tbQuit.Text);
            decimal TT = Convert.ToDecimal(tbTotalVista.Text.Substring(2));
            if (listBoxPago.Items.Count>=1)
            {
               
                if (qt < TT)
                {
                    HabilitaCampos(true);
                    PopulaPlanosAvista();
                }
                else
                {
                    if (qt == TT)
                    {
                        HabilitaCampos(false);
                        
                    }
                }
                
            }
            else
            {

                HabilitaCampos(true);
                PopulaPlanosAvista();
            }
        }
        private void HabilitaCampos(bool B)
        {
            btnConfirmar.Enabled = B;
            tbPagoAVista.Enabled = B;
            
        }

        private void tbCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(tbCPF.Text.Length==0 || tbCPF.Text.Equals("0")|| tbCPF.Text.Length==11)
                {
                    DAOSQLSERVER.EmitaCF(tbCodigo.Text, CmbImpressoras.Text, tbCPF.Text);
                    this.Close();
                }
            }
        }

        private void tbPagoAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbPagoAVista.Text.Length > 0)
            {
                btnConfirmar.Enabled = true;
            }
            else
            {
                btnConfirmar.Enabled = false;
            }
        }

        private void btnNormal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
