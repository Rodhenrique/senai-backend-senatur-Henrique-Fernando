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
    public class UsuarioController : ControllerBase
    {
        private IUsuario _usuarioRepository;

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Controller responsável pelos Listar os usuarios da Senatur
        /// </summary>
        /// <response code="200">retornar um Ok e a listar de usuarios</response>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }


        /// <summary>
        /// Controller responsável pelos buscar usuario pelo Id da Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e o usuario buscado</response>
        /// <response code="404">caso o Id NÃO EXISTE retorna Not Found</response> 
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var buscar = _usuarioRepository.BuscarPorId(id);

            if (buscar == null)
            {
                return StatusCode(404, "usuario não encontrado");
            }
            else
            {
                return StatusCode(202, buscar);
            }
        }

        /// <summary>
        /// Controller responsável pelos Cadastrar um novo usuario na Senatur
        /// </summary>
        /// <response code="201">retorna um criado e criar o usuario</response>
        /// <response code="404">casp algun campo estiver nulo retorna Not Found</response> 
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(Usuarios NovoUsuario)
        {
            if(NovoUsuario == null)
            {
                return StatusCode(404, "algun campo não foi preenchido");
            }
            else
            {
            _usuarioRepository.AdicionarUsuario(NovoUsuario);
            return StatusCode(201,"seu usuario foi criado com sucesso");
            }
        }

        /// <summary>
        /// Controller responsável pelos atualizar um usuario existente na Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e atualizar o seu Usuario</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult atualizar(Usuarios usuarioAtualizado)
        {
            _usuarioRepository.AtualizarIdCorpo(usuarioAtualizado);
            return StatusCode(202, "seu TipoUsuario foi atualizado com sucesso");
        }

        /// <summary>
        /// Controller responsável pelos deletar um usuario na Senatur
        /// </summary>
        /// <response code="202">retorna um aceito e deletar o seu Usuario</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public IActionResult deletar(int id)
        {
            _usuarioRepository.Deletar(id);
            return StatusCode(202, "seu TipoUsuario foi deletado com sucesso");
        }
    }
}