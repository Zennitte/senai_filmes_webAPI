﻿using senai_filmes_webAPI.Domains;
using senai_filmes_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// String de conexã como o banco de dados recebe os parametros.
        /// Data Source = Nome do servidor
        /// 
        /// </summary>
        private string stringConexao = "Data Source = NOTE0113F1\\SQLEXPRESS; initial catalog = catalogo; user Id = sa; pwd = Senai@132";
        //private string stringConexao = "Data Source = NOTE0113F1\\SQLEXPRESS; initial catalog = catalogo; integrated security = true";
        public void AtualizarIdCorpo(GeneroDomain generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idGenero, GeneroDomain generoAtualizado)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int idGenero)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idGenero)
        {
            throw new NotImplementedException();
        }

        public List<GeneroDomain> ListarTodos()
        {
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            //Declara a SQLConection passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idGenero, nomeGenero FROM GENERO";

                //Abre a conexão com o banco de dados
                con.Open();

                //Declarando o rdr que ira percorrer a tabela do banco de dados
                SqlDataReader rdr;

                //Declara o SqlCommand passando os parametrod
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    //Enquanto houverem registros a serem lidos os dados se repetem
                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            idGenero = Convert.ToInt32(rdr[0]),
                            nomeGenero = rdr[1].ToString()
                        };

                        listaGeneros.Add(genero);
                    }
                }
            };
            return listaGeneros;
        }
    }
}
