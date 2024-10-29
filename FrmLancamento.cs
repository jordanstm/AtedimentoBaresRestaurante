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
using MaterialSkinDataTable.MaterialSkin2DotNet.Controls;
using UltrasoftDAO.Controles;
using UltrasoftDAO.Modelos;

namespace AtendimentoBareseRestaurantes
{
    public partial class FrmLancamento : MaterialForm
    {
        public FrmLancamento()
        {
            InitializeComponent();
            string Nome = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["Descricao"].ToString().Trim();
            this.Text = Nome;
            PopulaPercentualAcrescimo();
        }
        public string CodigoMesa { get; set; }
        public string Modulo { get; set; }
        public MaterialDataTable table = new MaterialDataTable { };
        private async void PopulaPercentualAcrescimo()
        {
            tbAcrescimo.Text = Math.Round(Convert.ToDecimal(DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["VlOutroVenda"].ToString().Trim()),2).ToString();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnInicio.Enabled = false;
            tbNomeNota.Enabled = true;
            tbPesquisa.Enabled = true;
            tbAcrescimo.Enabled = true;
            tbCodigo.Enabled = true;
            string Codig = DAOSQLSERVER.MaximoCodigo("Vendas").ToString();
            if (Modulo.Equals("TakeOut"))
            {
                tbCodigo.Text = Codig;
            }
            else
            {
                tbID.Text = Codig;
                tbCodigo.Text = this.Codigo;
            }
            
            if (analisaEstadoDaVenda() == false)
            {

                PopulaViewItens();
            }
            tbNomeNota.Focus();
            SeqChamadoManual();
        }
        private bool analisaEstadoDaVenda()
        {
            int Cd = Convert.ToInt32(tbID.Text);
            string CodigoPendenteMesa = DAOSQLSERVER.ListaCodigoVendaPendenteMesas(tbCodigo.Text);
            
            string estado = Modulo.Equals("TakeOut")? DAOSQLSERVER.EstadoVenda(tbCodigo.Text).Trim(): DAOSQLSERVER.EstadoVenda(Cd.ToString(),tbCodigo.Text).Trim();

            if (CodigoPendenteMesa.Length > 0)
            {
                estado = "P";
                tbID.Text = CodigoPendenteMesa;
            }

            if (estado.Equals("P"))
                return false;
            else {
                if (estado.Equals("N"))
                {
                    if (Modulo.Equals("TakeOut"))
                    {
                        DAOSQLSERVER.InserePrimariosNaVenda(tbCodigo.Text);
                    }
                    else
                    {
                        DAOSQLSERVER.InserePrimariosNaVenda(tbID.Text,tbCodigo.Text);
                    }
                    
                    return false;
                }
                
                    return true;
            }
        }
      
        private void tbNomeNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (tbNomeNota.Text.Length > 2)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    mtbCliente.Focus();
                    mtbCliente.SelectAll();
                    
                }
            }
           
        }

        private void tbPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbPesquisa.Text.Length > 0)
                {
                    DAOSQLSERVER.ConsultaProdutos(tbPesquisa.Text, true, tbPesquisa.Text, false, "Venda", "", "", false, false, false);
                    var fonte = DAOSQLSERVER.DTConsulProd;
                    dgPesquisa.DataSource = fonte;
                    if (fonte.Rows.Count > 0)
                    {
                        AjustaGridPesquisa();
                    }         
                }
            }
            if( e.KeyCode == Keys.Right)
            {
                tbDesconto.Focus();
            }
            if(e.KeyCode== Keys.Escape)
            {
                this.Close();
            }
        }
        private void AjustaGridPesquisa()
        {
            dgPesquisa.Visible = true;
            dgPesquisa.Enabled = true;
            dgPesquisa.Columns["caracteristicas"].Width = 0;
            dgPesquisa.Columns["Nr.Fab"].Width = 0;
            dgPesquisa.Columns["Grupo"].Width = 0;
            dgPesquisa.Columns["Marca"].Width = 0;
            dgPesquisa.Columns["PrecoCompra"].Width = 0;
            dgPesquisa.Columns["PrecoCompra"].Width = 0;
            dgPesquisa.Columns["Descricao"].Width = 380;
            dgPesquisa.Columns["Codigo"].Width = 98;            
            dgPesquisa.Columns["PrecoVenda"].DefaultCellStyle.Format="C2";
            FormataGridTemaDark(dgPesquisa);
            dgPesquisa.EnableHeadersVisualStyles = false;
        }
        private void FormataGridTemaDark(object data)
        {
            var Dt = (data as DataGridView);
            Dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            for ( int i=0;i< Dt.Columns.Count;i++)
            {
                //Tema DARK
                Dt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 30, 30, 30);
                Dt.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 230, 230, 230);
                Dt.ColumnHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12, FontStyle.Regular);
                Dt.DefaultCellStyle.Font= new Font("SegoeUI", 12, FontStyle.Regular);
                Dt.DefaultCellStyle.ForeColor = Color.FromArgb(255, 230, 230, 230);
                Dt.DefaultCellStyle.BackColor = Color.FromArgb(255, 30, 30, 30);
                Dt.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 70, 70, 70);
                Dt.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 130, 230, 130);
                Dt.RowHeadersVisible = false;
              
                Dt.Focus();
            }
            //Aumentando a altura das linhas

             for (int I = 0; I < Dt.Rows.Count; I++)
            {
                Dt.Rows[I].Height = 50;
            }
            
        }

        private void dgPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                if (dgPesquisa.SelectedRows.Count > 0)
                {
                    ItemSel.Codigo = int.Parse(dgPesquisa.SelectedRows[0].Cells["Codigo"].Value.ToString());
                    ItemSel.Descricao = dgPesquisa.SelectedRows[0].Cells["Descricao"].Value.ToString();
                    ItemSel.Valor = Convert.ToDecimal(dgPesquisa.SelectedRows[0].Cells["PrecoVenda"].Value.ToString());
                    dgPesquisa.Visible = false;
                    InsereItem();
                    PopulaViewItens();
                    tbPesquisa.SelectAll();
                    tbPesquisa.Focus();
                }
                
            }
            if(e.KeyCode == Keys.Escape)
            {
                dgPesquisa.Visible = false;
            }
        }
        private ItemVendaSelecionado ItemSel = new ItemVendaSelecionado();
        private List<ItemVendaSelecionado> ListaItens = new List<ItemVendaSelecionado>();
        private int InsereItem()
        {
            decimal Total = 0;
            decimal qt = 0;
            decimal Valor = 0;
            qt = ItemSel.QTD;
            Valor = ItemSel.Valor;
            Total = Math.Round((qt * Valor), 2);

            string QTD = qt.ToString().Replace(",",".");
            string Preco = Valor.ToString().Replace(",", ".");
            string TT = Total.ToString().Replace(",", ".");
            string Codigo = ItemSel.Codigo.ToString();
            if (Modulo.Equals("TakeOut"))
            {
                return DAOSQLSERVER.InsereItensVenda(tbCodigo.Text, Codigo, ItemSel.Descricao, QTD, Preco, TT);
            }
            else
            {
                //string Co = Modulo.Equals("TakeOut") ? tbCodigo.Text : tbID.Text;
                //decimal To = Convert.ToDecimal(lblTotalLiquido.Text.Substring(2));
                //string ToF = To.ToString().Replace(",",".");
                //decimal desconto = Convert.ToDecimal(lblDesconto.Text.Substring(2));
                //string Desc = desconto.ToString().Replace(",", ".");
                //DAOSQLSERVER.AtualisaTotaisVenda(Co, ToF, ToF,Desc);
                return DAOSQLSERVER.InsereItensVenda(tbID.Text, Codigo, ItemSel.Descricao, QTD, Preco, TT);
            }
           
        }
        private void PopulaViewItens() {
            var listaIten = new List<ItensVenda>();
            var lt =Modulo.Equals("TakeOut")? DAOSQLSERVER.ListaItensVenda(tbCodigo.Text): DAOSQLSERVER.ListaItensVenda(tbID.Text,Codigo);
            if (lt.Rows.Count > 0)
            {
                foreach( DataRow R in lt.Rows)
                {
                    string CodVenda = R["Codigo"].ToString();
                    string CodProd = R["CodProd"].ToString();
                    string Descri = R["Descricao"].ToString();
                    Descri = Descri.Length <= 0 ? DAOSQLSERVER.BuscaDescricaoPorItem(CodProd).ToString().Trim() : Descri;
                    string Cod = R["Cod"].ToString();
                    decimal Desconto = Convert.ToDecimal(R["Desconto"].ToString());
                    decimal ValorVenda = Convert.ToDecimal(R["ValorVenda"].ToString());
                    decimal TotalLiquido = Convert.ToDecimal(R["TotalLiquido"].ToString());
                    decimal TotalBruto = Convert.ToDecimal(R["TotalBruto"].ToString());
                    decimal qtd = Convert.ToDecimal(R["QTD"].ToString());
                    decimal PrecoLiquido = Convert.ToDecimal(R["PrecoLiquido"].ToString());
                    var item = new ItensVenda()
                    {
                        Codigo = CodVenda,
                        Descricao = Descri,
                        CodProd = CodProd,
                        Desconto = Desconto,
                        TotalLiquido = TotalLiquido,
                        ValorBruto = TotalBruto,
                        ValorVenda = ValorVenda,
                        QTD = qtd,
                        Cod = Cod,
                        
                    };
                    listaIten.Add(item);
                }


                dgItensLancados.DataSource = listaIten;
                AjustaGridItensVendidos(dgItensLancados);
                ConfereTotaldeItens();
            }
            else
            {
                dgItensLancados.DataSource = null;
            }


        }
        private void AjustaGridItensVendidos(object data)
        {
            var Dt = (data as DataGridView);
            Dt.EnableHeadersVisualStyles = false;
            for (int i = 0; i < Dt.Columns.Count; i++)
            {
                //Tema DARK
                Dt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 30, 30, 30);
                Dt.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 230, 230, 230);
                Dt.ColumnHeadersDefaultCellStyle.Font = new Font("SegoeUI", 12, FontStyle.Regular);
                Dt.DefaultCellStyle.Font = new Font("SegoeUI", 12, FontStyle.Regular);
                Dt.DefaultCellStyle.ForeColor = Color.FromArgb(255, 230, 230, 230);
                Dt.DefaultCellStyle.BackColor = Color.FromArgb(255, 30, 30, 30);
                Dt.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 70, 70, 70);
                Dt.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 130, 230, 130);
                Dt.RowHeadersVisible = false;
                Dt.Focus();
                Dt.Columns["Desconto"].Visible = true;
                Dt.Columns["Unidade"].Visible = false;
                Dt.Columns["PrecoLiquido"].Visible = false;
                Dt.Columns["DescontoP"].Visible = false;
                Dt.Columns["Codigo"].Width = 0;
                Dt.Columns["Descricao"].Width = 380;

            }
            //Aumentando a altura das linhas

            for (int I = 0; I < Dt.Rows.Count; I++)
            {
                Dt.Rows[I].Height = 30;
               
            }
            CalculaTotais(Dt);
        }
        private void CalculaTotais(DataGridView Dg)
        {
            decimal Total = 0;
            decimal TLiquido = 0;
            decimal Desconto = 0;
            decimal Acresimo = DAOSQLSERVER.ValorOutroVenda( Modulo.Equals("TakeOut")?tbCodigo.Text : tbID.Text  );
            var lista = new List<decimal>();
            var ListaTLiquido = new List<decimal>();
            var ListaDesconto = new List<decimal>();
            foreach (DataGridViewRow R in Dg.Rows)
            {
                Total = Convert.ToDecimal(R.Cells["ValorVenda"].Value.ToString())* Convert.ToDecimal(R.Cells["qtd"].Value.ToString());
                TLiquido = Convert.ToDecimal(R.Cells["TotalLiquido"].Value.ToString());
                Desconto = Convert.ToDecimal(R.Cells["Desconto"].Value.ToString());
                
                string Tt = Total.ToString().Replace(",", ".");
                string Tl = TLiquido.ToString().Replace(",", ".");
                string Cod = R.Cells["Cod"].Value.ToString();
               
                lista.Add(Total);
                ListaTLiquido.Add(TLiquido);
                ListaDesconto.Add(Desconto);
            }
            decimal totalGeral = lista.Sum();
            decimal DescontoTOtal = ListaDesconto.Sum();
            Acresimo =Acresimo==0 ? CalculaVlrOutro(totalGeral, Convert.ToDecimal(tbAcrescimo.Text)):Acresimo;
            lblTotalLiquido.Text = ((totalGeral - DescontoTOtal) + Acresimo).ToString("c");
            lblTotal.Text= totalGeral.ToString("c");
            lblDesconto.Text = ListaDesconto.Sum().ToString("c");
            lblGarcon.Text = Math.Round(Acresimo, 2).ToString("c");
            string Cd = Modulo.Equals("TakeOut")? tbCodigo.Text:tbID.Text;
            DAOSQLSERVER.AtualisaTotaisVenda(Cd, (totalGeral + Acresimo).ToString(), totalGeral.ToString(), ListaDesconto.Sum().ToString());
            
        }

        private decimal CalculaVlrOutro(decimal Total ,decimal Percentual)
        {
            Total = Total * (Percentual / 100);
            return Total;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            removeItem();
        }
        private void removeItem()
        {
            string Cod = dgItensLancados.SelectedRows[0].Cells["Cod"].Value.ToString();
            DAOSQLSERVER.RemoveItemVenda(Cod);
            PopulaViewItens();
        }
        private void ConfereTotaldeItens()
        {
            lblTotalItens.Text = "Total Itens =" + dgItensLancados.RowCount;
        }

        private void btnFin_Click(object sender, EventArgs e)
           
        {
            MaterialDialog materialDialog = new MaterialDialog(this, "Atenção!", "Gostaria de Finalizar?", "SIM", true, "NÃO");
            DialogResult result = materialDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string CD = Modulo.Equals("TakeOut")?tbCodigo.Text: tbID.Text;
                DAOSQLSERVER.FinalizaVenda(CD,lblTotal.Text);              
                this.Close();
            }

        }

        private void btnTiket_Click(object sender, EventArgs e)
        {
            FormPagamento pag = new FormPagamento();
                pag.poulaTotal(lblTotalLiquido.Text);
                pag.Modulo = Modulo;
            pag.Comprador = tbNomeNota.Text.Trim() + "| Mesa :" + tbCodigo.Text;
            pag.Servico =  Convert.ToDecimal(lblGarcon.Text.Substring(2));
            pag.PopulaCodigoVenda(Modulo.Equals("TakeOut") ? tbCodigo.Text : tbID.Text);
            marcaImpressao();
            pag.ShowDialog();
            
            this.Close();
            
        }
        private void marcaImpressao()
        {
            DAOSQLSERVER.SetaEstadoImpressao(true, tbCodigo.Text);
            
            

        }
        private void SeqChamadoManual()
        
        {
            int TM = tbSeqChamado.Text.Length > 0 ? Convert.ToInt32(tbSeqChamado.Text) : 0;
            bool T = DAOSQLSERVER.ValidaCodigoVendaEmChamador(tbCodigo.Text);
            if (T == false)
            {
                DAOSQLSERVER.InsereChamadorInico(tbCodigo.Text, TM);
            }
        }
        private void FrmLancamento_Load(object sender, EventArgs e)
        {
            btnInicio.PerformClick();
            if (Codigo!=null & Modulo.Equals("TakeOut")){
                populaDadosNota();            
            }

            tbNomeNota.Text = Modulo.Equals("TakeOut") ? DAOSQLSERVER.NomeComprador(Codigo).Trim() :DAOSQLSERVER.NomeComprador(tbID.Text).Trim();
            DAOSQLSERVER.AnalisaSkin(this);
            tbDescMax.Text =DAOSQLSERVER.DescontoMaximoEmpresa();
        }
        private void populaDadosNota()
        {
            
           
            tbCodigo.Text = Codigo;
            PopulaViewItens();
            tbNomeNota.Enabled = true;
            tbPesquisa.Enabled = true;
            
            tbNomeNota.Focus();
            if (!lblTotalItens.Text.Equals("0"))
            {
                btnInicio.Enabled = false;
            }
            //tbDesconto.Text = DAOSQLSERVER.TempoMedioAtendimento(tbCodigo.Text);
        }
        public string Codigo { get; set; }

        private void dgItensLancados_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string Cod = dgItensLancados.SelectedRows[0].Cells["Cod"].Value.ToString();
            string qtd = dgItensLancados.SelectedRows[0].Cells["QTD"].Value.ToString();
            DAOSQLSERVER.AlteraQtdItem(Cod, qtd.Replace(",","."));
            CalculaTotais(dgItensLancados);
            PopulaViewItens();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tbTempoMedio_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public static DataTable Lancados = new DataTable();
        public static List<double> Descontos = new List<double>();
        private void CalcularDescontosTotais()
        {
            try
            {
                Lancados.Clear();
                Lancados.Columns.Clear();
                Descontos.Clear();
                string descmx = tbDescMax.Text;
                double maxDesc = Double.Parse(descmx);
                var table = new DataTable();
                if (tbDesconto.Text.Length > 0)
                {
                    if (tbDesconto.Text.Contains("%"))
                    {
                        DescontoPercentual();
                        RateiaDesconto();
                    }
                    else
                    {
                        DescontoReal();
                        RateiaDesconto();
                    }
                    if (tbDesconto.Text.Equals("0") || tbDesconto.Text.Equals(" "))
                    {
                        resetaDescontoIten();
                        Descontos.Clear();
                        Precovenda.Clear();
                        //QtdVedna.Clear();                    
                        table =
                        DAOSQLSERVER.ConsultaGenerica("ItensVenda", tbCodigo.Text, "C", 0);


                    }

                }

                PopulaViewItens();

            }
            catch(Exception ex)
            {
                DAOSQLSERVER.GravaErroLog(ex.Message, "CalcularDescontosTotais");
            }
           
        }
        private double TotalAntesDoDesconto { get; set; }
        private void resetaDescontoIten()
        {
            bool VENDA = true;
            lblTotal.Text = Math.Round(TotalAntesDoDesconto, 2).ToString();
            var itens = DAOSQLSERVER.ConsultaGenerica("ItensVenda", tbCodigo.Text, "1", 0);
            for (int I = 0; I < itens.Rows.Count; I++)
            {
                string Preco = itens.Rows[I]["ValorVenda"].ToString();
                string Codprod = itens.Rows[I]["CodProd"].ToString();
                DAOSQLSERVER.RatDesc(tbCodigo.Text, Codprod, 0, VENDA, Preco);
            }
        }
        public void DescontoPercentual()
        {
            double Dmx = Convert.ToDouble(tbDescMax.Text.Replace("%", ""));
            double Totalvenda = Convert.ToDouble(lblTotal.Text);
            double DescontoApl = Convert.ToDouble(tbDesconto.Text.Replace("%", ""));
            double Percentual = DescontoApl / 100;
            double ValDesc = 0;
            double TotalComDesconto = 0;
            if (Percentual <= Dmx)
            {
                ValDesc = Percentual * Totalvenda;
                tbDesconto.Text = Math.Round(ValDesc, 2).ToString();
                TotalComDesconto = Totalvenda - ValDesc;
                lblTotalLiquido.Text = Math.Round(TotalComDesconto, 2).ToString();
                Descontos.Add(ValDesc);
            }
            else
            {
                DAOSQLSERVER.Valida = false;
                
                FrmValidaSenhaSuper super = new FrmValidaSenhaSuper
                    (Observador.TiposEventos.EventosValidativos, ObservadorEventos.EventosSupervisor.PermiteDesconto,
                    "Verificacao de desconto Percentual Permitido", tbCodigo.Text);
                super.ShowDialog();
                if (DAOSQLSERVER.Valida)
                {
                    ValDesc = Percentual * Totalvenda;
                    tbDesconto.Text = Math.Round(ValDesc, 2).ToString();
                    TotalComDesconto = Totalvenda - ValDesc;
                    lblTotalLiquido.Text = Math.Round(TotalComDesconto, 2).ToString();
                    Descontos.Add(ValDesc);
                }
            }

        }
        public void DescontoReal()
        {

            Descontos.Clear();
            double Dmx = Convert.ToDouble(tbDescMax.Text.Replace("%", ""));
            double Percentual = 0;
            double Totalvenda = Convert.ToDouble(lblTotal.Text.Substring(2));
            double DescontoApl = Convert.ToDouble(tbDesconto.Text.Replace("%", ""));
            double TotalComDesconto = 0;
            if (DescontoApl > 0)
            {
                Percentual = (DescontoApl / Totalvenda) * 100;
                if (Percentual <= Dmx)
                {
                    tbDesconto.Text = Math.Round(DescontoApl, 2).ToString();
                    TotalComDesconto = Totalvenda - DescontoApl;
                    lblTotalLiquido.Text = Math.Round(TotalComDesconto, 2).ToString();
                    Descontos.Add(DescontoApl);
                }
                else
                {
                    DAOSQLSERVER.Valida = false;
                    FrmValidaSenhaSuper super = new FrmValidaSenhaSuper
                        (Observador.TiposEventos.EventosValidativos, ObservadorEventos.EventosSupervisor.PermiteDesconto,
                        "Validacao de desconto em valor real na venda", tbCodigo.Text);
                    super.ShowDialog();
                    if (DAOSQLSERVER.Valida)
                    {
                        tbDesconto.Text = Math.Round(DescontoApl, 2).ToString();
                        TotalComDesconto = Totalvenda - DescontoApl;
                        lblTotalLiquido.Text = Math.Round(TotalComDesconto, 2).ToString();
                        Descontos.Add(DescontoApl);
                        lblDesconto.Text = Math.Round(Descontos.Sum(),2).ToString();
                    }
                }
            }


        }
        public static List<double> Precovenda = new List<double>();
        public void Descontozerado()
        {

            var table = new DataTable();
            if (tbDesconto.Text.Equals("0"))
            {
                resetaDescontoIten();
                Descontos.Clear();
                Precovenda.Clear();               
                
                    table =
                    DAOSQLSERVER.ConsultaGenerica("ItensVenda", tbCodigo.Text, "C", 0);
                
                
                foreach (DataRow row in table.Rows)
                {
                    double vlr = double.Parse(row["ValorBruto"].ToString());
                    double qtd = double.Parse(row["qtd"].ToString());
                    double desc = double.Parse(row["Desconto"].ToString());
                   
                        double vOutro = double.Parse(row["vOutro"].ToString());
                        Precovenda.Add((vlr - desc + vOutro) * qtd);
                   
                   

                }
                double valorvenda = Precovenda.Sum();
                lblTotal.Text = valorvenda.ToString();
                lblTotalLiquido.Text = valorvenda.ToString();
                if (Lancados.Columns.Count == 0)
                {
                    PopulaViewItens();
                }

            }
        }
        private void RateiaDesconto()
        {

            var itens =Modulo.Equals("TakeOut") ? DAOSQLSERVER.ConsultaGenerica("ItensVenda", tbCodigo.Text, "1", 0) : DAOSQLSERVER.ListaItensVenda(tbID.Text, tbCodigo.Text);
            bool VENDA = true;
            string[] TIt = lblTotalItens.Text.Split('=');
            int TotalDeItensLAncados = Convert.ToInt32(TIt[1]);
            double Valorliquido = 0;
            double ValorUnComDesconto = 0;
            if (TotalDeItensLAncados == 1)// calcular desconto para 1 item lancado observando a qtd aplicada
            {

                double Qtd = Double.Parse(itens.Rows[0]["QTD"].ToString());
                double Vdesc = Descontos.Sum();
                
                    double totalVendaBruto = Convert.ToDouble(lblTotal.Text.Substring(2));
                    double percentualDesc = Vdesc / totalVendaBruto * 100;
                    double valprod = Double.Parse(itens.Rows[0]["ValorVenda"].ToString());
                 if(Qtd==1)
                ValorUnComDesconto = Math.Round(valprod * (percentualDesc / 100), 3);
                  else
                    ValorUnComDesconto = Math.Round((valprod * Qtd)* (percentualDesc / 100), 3);
                Valorliquido = totalVendaBruto - ValorUnComDesconto;
                lblDesconto.Text = Vdesc.ToString();
                lblTotalLiquido.Text = Valorliquido.ToString();
                
                

                
                string Codigo = Modulo.Equals("TakeOut")? tbCodigo.Text: tbID.Text;
                string Codprod = itens.Rows[0]["Cod"].ToString();

                DAOSQLSERVER.RatDesc(Codigo, Codprod, Vdesc, VENDA, Valorliquido.ToString());
            }
            else
            {
                double Vdesc = Descontos.Sum();
                List<double> DescApl = new List<double>();
               
                for (int I = 0; I < itens.Rows.Count; I++)
                {
                    double QTD = Double.Parse(itens.Rows[I]["qtd"].ToString());
                    double valprod = Double.Parse(itens.Rows[I]["ValorVenda"].ToString());
                    double totalVenda = Double.Parse(lblTotal.Text.Substring(2));
                    double TotComDesc = totalVenda;
                    double aliqDesc = Vdesc / TotComDesc;
                    double ValDesc = ((valprod * QTD) * aliqDesc);
                    ValDesc = ValDesc > 0 ? Math.Round(ValDesc, 4) : Math.Round(ValDesc, 4);
                    double ValorVendaComDesconto = Math.Round((valprod - ValDesc),4);
                    DescApl.Add(ValDesc);
                    string Codigo = tbCodigo.Text;
                    string Codprod = itens.Rows[I]["Cod"].ToString();
                    double Qtd = Double.Parse(itens.Rows[I]["QTD"].ToString());
                    DAOSQLSERVER.RatDesc(Codigo, Codprod, ValDesc, VENDA, ValorVendaComDesconto.ToString());
                }
                double TotDesc1 = Descontos.Sum();
                double TotDesc2 = DescApl.Sum();
                decimal T2 = Convert.ToDecimal(DescApl.Sum());
                //VERIFICAÇÃO PARA O DIFERENÇA RESIDUAL DO CALCULO INVERSO DO DESCONTO APLICADO 
                if (TotDesc1 > TotDesc2)
                {

                    double vldDesc1 = Descontos.Sum();
                    double VldDesc2 = Math.Round(DescApl.Sum(), 2);
                    double Resultado = Math.Round(VldDesc2 - vldDesc1, 2);
                    if (Resultado < 0)
                    {
                        Resultado = Math.Round(vldDesc1 - VldDesc2, 2);
                    }
                    int codPAlterar = DAOSQLSERVER.BuscadorMaxPreco(tbCodigo.Text);
                    double DescIten = DAOSQLSERVER.BuscaDescontoUnit(codPAlterar.ToString(), tbCodigo.Text);
                    double NewDesc = Resultado + DescIten;
                    double ValorVendaComDesconto = DAOSQLSERVER.ValorItemPraAlterar - NewDesc;
                    DAOSQLSERVER.RatDesc(tbCodigo.Text, codPAlterar.ToString(), NewDesc, VENDA, ValorVendaComDesconto.ToString());
                }
                else
                {
                    if (TotDesc2 > TotDesc1)
                    {
                        double Resultado = Math.Round(TotDesc2 - TotDesc1, 4);
                        int codPAlterar = DAOSQLSERVER.BuscadorMaxPreco(tbCodigo.Text);
                        double DescIten = DAOSQLSERVER.BuscaDescontoUnit(codPAlterar.ToString(), tbCodigo.Text);
                        double NewDesc = DescIten - Resultado;
                        double ValorVendaComDesconto = DAOSQLSERVER.ValorItemPraAlterar - NewDesc;
                        DAOSQLSERVER.RatDesc(tbCodigo.Text, codPAlterar.ToString(), NewDesc, VENDA, ValorVendaComDesconto.ToString()
                            );
                    }
                }
            }

        }
        public double VlrTotalSdesc;
        public double VlrTotalVenda;

        private void tbSeqChamado_KeyDown(object sender, KeyEventArgs e)
        
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (tbSeqChamado.Text.Length > 0)
                {
                    if(tbCodigo.Text.Length==0)
                    btnInicio.PerformClick();
                    else
                    {
                        btnInicio.Enabled = false;
                        tbNomeNota.Enabled = true;
                        tbPesquisa.Enabled = true;
                        tbNomeNota.Focus();
                        PopulaViewItens();
                    }
                    
                }
            }
        }

        private void tbDesconto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            CalcularDescontosTotais();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string Codigo = "0";
            var empres = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["Modulo"].ToString().Trim();
             if(empres.Equals("TakeOut-Mesas"))
            {
                Codigo = tbID.Text;
            }
              else
            {
                Codigo = tbCodigo.Text;
            }
            FrmValidaSenhaSuper Super = new FrmValidaSenhaSuper(Observador.TiposEventos.EventosValidativos, ObservadorEventos.EventosSupervisor.PermiteDesconto,
                    "Verificacao de desconto Percentual Permitido", Codigo);
            Super.ShowDialog();
            if (DAOSQLSERVER.Valida)
            {
                DAOSQLSERVER.CancelaAtendimento(Codigo);
                tbCodigo.Text = "0";
                this.Close();
            } DAOSQLSERVER.Valida = false;
           
        }

        private void tbNomeNota_Leave(object sender, EventArgs e)
        {
            string Codigo = Modulo.Equals("TakeOut") ? tbCodigo.Text : tbID.Text;
           
            
            DAOSQLSERVER.GravaCompradorVenda(tbNomeNota.Text, Codigo);
        }

        private void tbSeqChamado_Leave(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbSeqChamado.Text);
            if (numero > 999)
            {
                MessageBox.Show("Não são permitidos numeros maiores que 999");
                tbSeqChamado.SelectAll();
                tbSeqChamado.Focus();
            }
        }

        private void FrmLancamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lblTotalItens.Text.Equals(".")& !tbCodigo.Text.Equals("0"))
            {
                MessageBox.Show("Você precisa lancar aumenos um item apos iniciar a venda");
                e.Cancel = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void tbAcrescimo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Modulo.Equals("TakeOut"))
                {
                    string valor = tbAcrescimo.Text.Replace(",", ".");
                    DAOSQLSERVER.InsereVlOutroVenda(tbCodigo.Text, valor);
                }
                else
                {
                    decimal tLiq = Convert.ToDecimal(lblTotalLiquido.Text.Substring(2));
                    decimal AliqOutro = Convert.ToDecimal(tbAcrescimo.Text);
                    decimal VlOutro = AliqOutro / 100;
                    decimal valorF = Math.Round(tLiq * (VlOutro ), 2);
                    if (AliqOutro == 0)
                    {
                        valorF = 0;
                    }
                    string valor = valorF.ToString().Replace(",", ".");
                    DAOSQLSERVER.InsereVlOutroVenda(tbID.Text, valor);
                }
                PopulaViewItens();
            }
           
           
        }

        private void ImprimeCupomNormal()

        {
            string CaminhoLogoNfe = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoLogoNfe"].ToString().Trim();
            string CD = Modulo.Equals("TakeOut") ? tbCodigo.Text : tbID.Text;
            string Chamador = DAOSQLSERVER.CodigoChamado(tbCodigo.Text);
            string NomeComprador = Modulo.Equals("TakeOut") ? DAOSQLSERVER.PegaNomeComprador(tbCodigo.Text): DAOSQLSERVER.PegaNomeComprador(tbID.Text)+"| Mesa:" +tbCodigo.Text;
            decimal servico = Convert.ToDecimal(lblGarcon.Text.Substring(2));
            string Total =  "0";
            
            bool Bar = Modulo.Equals("TakeOut") ? false : true;
            byte[] logo = UltrasoftDAO.Controles.Util.ImageFromAraybyte(DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoLogoNFE"].ToString().Trim());
            ImpressaoUltra.Impressao Imp = new ImpressaoUltra.Impressao();

            byte [] QRCode = UltrasoftDAO.Controles.Util.ImageFromAraybyte(DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["CaminhoImgQrCode"].ToString().Trim());
            string ChavePix = DAOSQLSERVER.CfgDadosEmpresa().Rows[0]["ChavePix"].ToString().Trim();
            DAOSQLSERVER.FontePedidoPdvVendaRetaguarda(0, Convert.ToInt32(CD), Convert.ToDecimal(Total));
            Imp.ImpressaoPdvRetaGuarda("", DAOSQLSERVER.DatasetGenerico, 1, false, Chamador, NomeComprador,logo,QRCode,ChavePix,Bar,servico);
           
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimeCupomNormal();
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void mtbCliente_KeyDown(object sender, KeyEventArgs e)
        {
             if( e.KeyCode == Keys.Enter)
            {
                if (mtbCliente.Text.Length == 0)
                {
                    var cli = new FrmConsultaCliente();
                    cli.ShowDialog();
                     if(Util.CodigoCliente.ToString().Length > 0)
                    {
                        mtbCliente.Text = Util.CodigoCliente.ToString() + " - " + Util.Descricao;
                    }
                }
                else
                {
                    if (mtbCliente.Text.Length > 0)
                    {
                        tbPesquisa.Focus();
                    }
                }
            }
        }

        private void mtbCliente_Leave(object sender, EventArgs e)
        {
            string Codigo = tbID.Text.Length > 0 ? tbID.Text : tbSeqChamado.Text;
            string[] parte = mtbCliente.Text.Split('-');
            DAOSQLSERVER.AlteraClienteVenda(parte[0], Codigo);

        }

        private void mtbOBS_Leave(object sender, EventArgs e)
        {
            string Codigo = tbID.Text.Length > 0 ? tbID.Text : tbSeqChamado.Text;
            DAOSQLSERVER.AlteraOBSVenda(mtbOBS.Text, Codigo);
        }
    }
}
