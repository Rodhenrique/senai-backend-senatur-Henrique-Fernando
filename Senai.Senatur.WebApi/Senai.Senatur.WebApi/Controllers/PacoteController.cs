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
    public class PacoteController : ControllerBase
    {
        private IPacote _pacoteRepository;

        public PacoteController()
        {
            _pacoteRepository = new PacoteRepository();
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            return Ok(_pacoteRepository.Listar());
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            return Ok(_pacoteRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Controller responsável pelos login Senatur
        /// </summary>
        /// <response code="200">Returns the newly Accepted item</response>
        /// <response code="404">If the item is null</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(Pacotes pacotes)
        {
            _pacoteRepository.AdicionarPacote(pacotes);
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
        public IActionResult atualizar(Pacotes pacotes)
        {
            _pacoteRepository.AtualizarIdCorpo(pacotes);
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
            _pacoteRepository.Deletar(id);
            return StatusCode(200, "seu TipoUsuario foi deletado com sucesso");
        }
    }
}