using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IUsuario
    {
        List<Usuarios> Listar();

        Usuarios BuscarPorId(int id);

        void AdicionarUsuario(Usuarios Novousuario);

        void AtualizarIdCorpo(Usuarios usuarioAtualizado);

        void Deletar(int id);

        Usuarios BuscarEmalSenha(string Email, string Senha);
    }
}
