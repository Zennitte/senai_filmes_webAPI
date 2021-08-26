using senai_filmes_webAPI.Domains;
using senai_filmes_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string stringConexao = "Data Source = NOTE0113F1\\SQLEXPRESS; initial catalog = catalogo; user Id = sa; pwd = Senai@132";
        public void AtualizarIdCorpo(FilmeDomain filmeAtualiado)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int idFilme, FilmeDomain filmeAtualiado)
        {
            throw new NotImplementedException();
        }

        public FilmeDomain BuscarPorId(int idFilme)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(FilmeDomain novoFilme)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idFilme)
        {
            throw new NotImplementedException();
        }

        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> listaFilmes = new List<FilmeDomain>();

            //Declara a SQLConection passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string querySelectAll = "SELECT idFilme, nomeFilme, nomeGenero FROM FILME";

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
                        FilmeDomain filme = new FilmeDomain()
                        {
                            idFilme = Convert.ToInt32(rdr[0]),
                            idGenero = Convert.ToInt32(rdr[1]),
                            tituloFilme = rdr[2].ToString()
                        };

                        listaFilmes.Add(filme);
                    }
                }
            };
            return listaFilmes;
        }
    }
}
