using GerenciadorDePecas.Controller;
using GerenciadorDePecas.Model;
using Microsoft.Identity.Client;
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
    public partial class TelaCadastrasPecas : Form
    {
        public TelaCadastrasPecas()
        {
            InitializeComponent();
        }

        private void btn_cadastrarpecas_Click(object sender, EventArgs e)
        {
            Pecas.Peca = txtbox_pecas.Text;
            Pecas.Marca = txtbox_marca.Text;
            Pecas.Capacidade = txtbox_cap.Text;

            ManipulasPecas mPeca = new ManipulasPecas();
            mPeca.CadPecas();

        }

        public void AbrirCadastro()
        {
            this.ShowDialog();
        }

    }
}


