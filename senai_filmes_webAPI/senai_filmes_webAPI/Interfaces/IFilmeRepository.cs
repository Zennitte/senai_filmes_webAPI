using senai_filmes_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Interfaces
{
    interface IFilmeRepository
    {
        /// <summary>
        /// Lista todos os filmes
        /// </summary>
        /// <returns>Uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Busca um filme através do seu id
        /// </summary>
        /// <param name="idFilme">id do filme que será buscado</param>
        /// <returns>Um gênero buscado</returns>
        FilmeDomain BuscarPorId(int idFilme);

        /// <summary>
        /// Cadastra um novo filme
        /// <param name="novoFilme">Objeto novoFilme com os novos dados</param>
        void Cadastrar(FilmeDomain novoFilme);

        /// <summary>
        /// Atualiza um filme existente
        /// </summary>
        /// <param name="filmeAtualizado">Objeto filmeAtualizado com os novos dados atualizados</param>
        void AtualizarIdCorpo(FilmeDomain filmeAtualiado);

        /// <summary>
        /// Atualiza um filme existente
        /// </summary>
        /// <param name="idFilme">id do filme que será atualizado</param>
        /// <param name="filmeAtualizado">Objeto filmeAtualizado com os novos dados atualizados</param>
        void AtualizarIdUrl(int idFilme,FilmeDomain filmeAtualiado);

        /// <summary>
        /// Deleta um filme existente
        /// </summary>
        /// <param name="idFilme">id do filme que será deletado</param>
        void Deletar(int idFilme);
    }
}
