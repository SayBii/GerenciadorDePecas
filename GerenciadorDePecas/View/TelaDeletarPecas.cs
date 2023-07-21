using GerenciadorDePecas.Controller;
using GerenciadorDePecas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDePecas.View
{
    public partial class TelaDeletarPecas : Form
    {
        public TelaDeletarPecas()
        {
            InitializeComponent();
        }

        private void btn_pesquisarpecas_Click(object sender, EventArgs e)
        {

            Pecas.Codigo = Convert.ToInt32(txt_deletar.Text);
            ManipulasPecas mpecas = new ManipulasPecas();
            mpecas.BuscaPecasCod();



            txt_deletarcod.Text = Pecas.Codigo.ToString();
            txt_deletarpecas.Text = Pecas.Peca;
            txt_deletarmarca.Text = Pecas.Marca;
            txt_deletarcap.Text = Pecas.Capacidade;


        }
        

        private void btn_deletarpecas_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(txt_deletarcod.Text);

            ManipulasPecas mpecas = new ManipulasPecas();
            mpecas.DeletarPecas();



        }
    }
}
