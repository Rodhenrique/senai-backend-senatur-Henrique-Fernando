using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Senha é obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "A senha deve conter entre 5 e 30 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O tipo do usuario é obrigatório")]
        public int? IdTiposUsuario { get; set; }

        public TiposUsuario IdTiposUsuarioNavigation { get; set; }
    }
}
