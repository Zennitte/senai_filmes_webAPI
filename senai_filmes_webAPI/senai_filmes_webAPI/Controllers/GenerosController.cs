using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_filmes_webAPI.Domains;
using senai_filmes_webAPI.Interfaces;
using senai_filmes_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webAPI.Controllers
{
    //Define que tipo de resposta da API será no formato json 
    [Produces("application/json")]

    //Define que rota a requisição será no formato domino/api/nomecontroller.
    [Route("api/[controller]")]

    //Define que é um controller de API
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private IGeneroRepository _generoRepository { get; set; }
        public GenerosController()
        {
            _generoRepository = new GeneroRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<GeneroDomain> listaGeneros = _generoRepository.ListarTodos();

            return Ok(listaGeneros);
        }

        /// <summary>
        /// Cadastra um novo genero
        /// </summary>
        /// <returns>Status code 201 - Created</returns>
        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            //Faz a chamada para o metodo cadastrar
            _generoRepository.Cadastrar(novoGenero);

            return StatusCode(201);
        }

        /// <summary>
        /// Deleta um genero existente
        /// </summary>
        /// <param name="id">id do genero a ser deletado</param>
        /// <returns>Um status code No Content</returns>
        [HttpDelete("excluir")]
        public IActionResult Delete(GeneroDomain generoDeletado)
        {
            _generoRepository.Deletar(generoDeletado.idGenero);

            return NoContent();
        }
    }
}
