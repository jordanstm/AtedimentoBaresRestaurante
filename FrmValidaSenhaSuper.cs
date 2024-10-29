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
    public partial class FrmValidaSenhaSuper : MaterialForm
    {
        public FrmValidaSenhaSuper(Observador.TiposEventos TipoValidacao, ObservadorEventos.EventosSupervisor TipoEvento,string DescricaoEvento,string CodigoVenda)
        {
            InitializeComponent();
        }

        private void FrmValidaSenhaSuper_Load(object sender, EventArgs e)
        {
            DAOSQLSERVER.AnalisaSkin(this);
            tbSenha.SelectAll();
            tbSenha.Focus();
        }

        private void tbSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbSenha.Text.Length > 1)
                {
                    btnConfirmar.Focus();
                }
            }
        }
        private void ValidaSenha()
        {
            DAOSQLSERVER.ValidadorSenhaSuper(tbSenha.Text);
            if (DAOSQLSERVER.Valida)
            {
                this.Close();
            }
            else
            {
                tbSenha.ForeColor = Color.Red;
                tbSenha.BackColor = Color.Red;
                tbSenha.SelectAll();
                tbSenha.Focus();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ValidaSenha();
        }
    }
}
