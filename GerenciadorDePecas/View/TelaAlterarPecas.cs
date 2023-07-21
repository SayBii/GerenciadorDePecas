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
    public partial class TelaAlterarPecas : Form
    {
        public TelaAlterarPecas()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Pecas.Codigo = Convert.ToInt32(btn_alterar.Text);
            ManipulasPecas mpecas = new ManipulasPecas();
            mpecas.BuscaPecasCod();



            txt_pesquisaalterar.Text = Pecas.Codigo.ToString();
            txt_pesquisaalterar.Text = Pecas.Peca;
            txt_alterarmarca.Text = Pecas.Marca;
            txt_alterarcap.Text = Pecas.Capacidade;
        }

        private void btn_alterardados_Click(object sender, EventArgs e)
        {
            txt_pesquisaalterar.Text = Pecas.Codigo.ToString();
            Pecas.Peca = txt_pesquisaalterar.Text;
            Pecas.Marca = txt_alterarmarca.Text;
            Pecas.Capacidade = txt_alterarcap.Text;



            ManipulasPecas mPeca = new ManipulasPecas();
            mPeca.AlterarPecas();




        }
        public void abriraltera()
        {
            this.ShowDialog();
        }
    }

    
}
