using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuario _tipoUsuarioRepository;

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Controller responsável pelo listar do Senatur
        /// </summary>
        /// <response code="200">retorno uma listar de Tipos de usuarios</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">retorna um usuario buscado pelo id</response>
        /// <response code="404">caso não retorna um not found</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var buscar = _tipoUsuarioRepository.BuscarPorId(id);
            if (buscar == null)
            {
                return NotFound("não achado um usuario");
            }
            else
            {
                return Ok("Seu usuario foi encontrado");
            }
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(TiposUsuario tiposUsuario)
        {
            _tipoUsuarioRepository.AdicionarTipoUsuario(tiposUsuario);
            return StatusCode(201);
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult atualizar(TiposUsuario tiposUsuario)
        {
            _tipoUsuarioRepository.AtualizarIdCorpo(tiposUsuario);
            return StatusCode(200, "seu TipoUsuario foi atualizado com sucesso");
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult deletar(int id)
        {
            _tipoUsuarioRepository.Deletar(id);
            return StatusCode(200, "seu TipoUsuario foi deletado com sucesso");
        }
    }
}