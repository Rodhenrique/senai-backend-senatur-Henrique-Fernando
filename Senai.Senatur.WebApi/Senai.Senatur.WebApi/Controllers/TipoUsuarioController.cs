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
        /// Controller responsável pelo listar os tipos de usuarios da Senatur
        /// </summary>
        /// <response code="200">retorno uma listar de Tipos de usuarios</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());
        }

        /// <summary>
        /// Controller responsável pelos buscar um tipo de usuario pelo Id Senatur
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
        /// Controller responsável pelos Cadastrar um novo tipo usuario da Senatur
        /// </summary>
        /// <response code="201">retorna um criado e criar um novo tipo de usuario</response>
        /// <response code="404">caso estiver um campo nulo retorna um Not Found</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(TiposUsuario tiposUsuario)
        {
            if(tiposUsuario == null)
            {
                return NotFound("Seu Tipo Usuario esta com algun campo não preencido");
            }else
            {
            _tipoUsuarioRepository.AdicionarTipoUsuario(tiposUsuario);
            return StatusCode(201,"seu tipo usuario foi criado");
            }
        }

        /// <summary>
        /// Controller responsável pelos atualizar um tipo usuario existente Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e atualizar o seu Tipo Usuario</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult atualizar(TiposUsuario tiposUsuario)
        {
            _tipoUsuarioRepository.AtualizarIdCorpo(tiposUsuario);
            return StatusCode(202, "seu TipoUsuario foi atualizado com sucesso");
        }

        /// <summary>
        /// Controller responsável pelos deletar um tipo usuario Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e deletar o seu Tipo Usuario</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult deletar(int id)
        {
            _tipoUsuarioRepository.Deletar(id);
            return StatusCode(202, "seu TipoUsuario foi deletado com sucesso");
        }
    }
}