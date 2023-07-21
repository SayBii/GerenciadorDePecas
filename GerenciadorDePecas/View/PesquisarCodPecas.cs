using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciadorDePecas.Controller;
using GerenciadorDePecas.Model;

namespace GerenciadorDePecas.View
{
    public partial class PesquisarCodPecas : Form
    {
        public PesquisarCodPecas()
        {
            InitializeComponent();
        }

        private void btn_buscarpecas_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txt_cod.Text);
            ManipulasPecas mpecas = new ManipulasPecas();
            mpecas.BuscaPecasCod();



            txt_cod.Text = Pecas.Codigo.ToString();
            txtbox_pecas.Text = Pecas.Peca;
            txtbox_marca.Text = Pecas.Marca;
            txtbox_cap.Text = Pecas.Capacidade.ToString();


        }
    }
}
