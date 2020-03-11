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
        /// Controller responsável por listar os pacotes de viagens da Senatur
        /// </summary>
        /// <response code="200">retorna um ok e uma listar</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_pacoteRepository.Listar());
        }

        /// <summary>
        /// Controller responsável pelos buscar pelo Id Mandar um Id Retorna o pacote daquele Id do Senatur
        /// </summary>
        /// <response code="200">retorna um usuario do Id Solicitando</response>
        /// <response code="404">caso Id não existe retorna um Not Found</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var buscar = _pacoteRepository.BuscarPorId(id);
            if (buscar == null)
            {
                return NotFound("Id não existe");
            }
            else
            {
                return Ok(buscar);
            }
        }

        /// <summary>
        /// Controller responsável pelos Cadastrar um novo pacote de viagens da Senatur
        /// </summary>
        /// <response code="201">retorna um Created caso for criado</response>
        /// <response code="404">caso estiver algun campo nulo retorna um not found</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(Pacotes pacotes)
        {
            if(pacotes == null)
            {
                return NotFound("algun campo não preenchido");
            }else
            {
            _pacoteRepository.AdicionarPacote(pacotes);
            return StatusCode(201);
            }
        }

        /// <summary>
        /// Controller responsável pelos Atualizar um pacote existente na Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e atualizar um pacote</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult atualizar(Pacotes pacotes)
        {
            _pacoteRepository.AtualizarIdCorpo(pacotes);
            return StatusCode(202, "seu TipoUsuario foi atualizado com sucesso");
        }

        /// <summary>
        /// Controller responsável pelos Deletar um pacote da Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e deletar seu pacote</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult deletar(int id)
        {
            _pacoteRepository.Deletar(id);
            return StatusCode(202, "seu TipoUsuario foi deletado com sucesso");
        }
    }
}