using GerenciadorDePecas.Model;
using GerenciadorDePecas.View;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDePecas.Controller
{
    internal class ManipulasPecas
    {
        public void CadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());

            SqlCommand cmd = new SqlCommand("pcadastrarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidades", Pecas.Capacidade);


                SqlParameter nv = cmd.Parameters.Add("IdPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça Cadastrada com sucesso, Deseja cadastrar outra peça?",
                    "Novo registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes) ;
                TelaCadastrasPecas telaCadastras = new TelaCadastrasPecas();
                telaCadastras.AbrirCadastro();

            }
            catch (Exception)
            {

                throw;
            }

        }


        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                var registros = cmd.ExecuteReader();

                if (registros.Read()) 
                {
                    Pecas.Codigo = Convert.ToInt32(registros["IdPecas"]);
                    Pecas.Peca = (string)registros["Pecas"];
                    Pecas.Marca = (string)registros["Marcas"];
                    Pecas.Capacidade = (string)registros["Capacidades"];

                }
            

                else
                {

                    Pecas.Codigo = 0;
                    Pecas.Peca   = "";
                    Pecas.Marca  = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisa Código");

                }
            }
            catch (Exception)
            {

            }
        }

        public void DeletarPecas()


        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça deletada com sucesso", 
                    "Deletar Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);




            }
            catch (Exception)
            {

                throw;
            }
        }


        public void AlterarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());

            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cmd.Parameters.AddWithValue("Pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("Marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("Capacidade", Pecas.Capacidade);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Peça Alterada com sucesso.");
                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";

            }
            catch (Exception)
            {

                throw;
            }
        }


        
    }


}


