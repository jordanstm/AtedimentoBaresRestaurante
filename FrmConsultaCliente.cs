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
using UltrasoftDAO.Modelos;
using UltrasoftDAO.Controles;

namespace AtendimentoBareseRestaurantes
{
    public partial class FrmConsultaCliente : MaterialForm
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void mtbPesquisaCliente_KeyDown(object sender, KeyEventArgs e)
        {
             if(e.KeyCode == Keys.Enter)
            {
                if (mtbPesquisaCliente.Text.Length > 0)
                {
                    var list = DAOSQLSERVER.ListaClienteFornecedor(mtbPesquisaCliente.Text);
                    if(list.Count > 0)
                    {
                        CriaElementosNaPesquisa(list);
                    }
                }
            }
              if(e.KeyCode == Keys.Down)
            {
                listDadosPesquisa.Focus();
            }
        }
         private void  CriaElementosNaPesquisa(List<ClienteFornecedor> Lista)
        {

            listDadosPesquisa.ForeColor = Color.FromArgb(255, 130, 230, 230);

            listDadosPesquisa.Items.Clear();
            foreach (var It in Lista)
            {
                var Lit = new ListViewItem(It.Codigo.ToString());
                Lit.SubItems.Add(It.Descricao);

                listDadosPesquisa.Items.Add(Lit);
            }

            
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            DAOSQLSERVER.AnalisaSkin(this);
        }

        private void listDadosPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
             if( e.KeyCode == Keys.Enter)
            {
                int Codigo = int.Parse(listDadosPesquisa.SelectedItems[0].SubItems[0].Text);
                string Descricao = listDadosPesquisa.SelectedItems[0].SubItems[1].Text;
               
                Util.Descricao = Descricao;
                Util.CodigoCliente = Codigo;
                this.Close();

            }
            
        }

        
    }
}
