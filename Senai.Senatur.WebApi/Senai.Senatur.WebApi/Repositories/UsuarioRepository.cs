using Microsoft.EntityFrameworkCore;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        SenaturContext ctx = new SenaturContext();

        public void AdicionarUsuario(Usuarios Novousuario)
        {
            ctx.Usuarios.Add(Novousuario);

            ctx.SaveChanges();
        }

        public void AtualizarIdCorpo(Usuarios usuarioAtualizado)
        {
            Usuarios atual = new Usuarios();

            atual = BuscarPorId(usuarioAtualizado.IdUsuario);

            atual.Email = usuarioAtualizado.Email;
            atual.Senha = usuarioAtualizado.Senha;
            atual.IdTiposUsuario = usuarioAtualizado.IdTiposUsuario;

            ctx.Usuarios.Update(atual);

            ctx.SaveChanges();
        }

        public Usuarios BuscarEmalSenha(string email, string senha)
        {
           return ctx.Usuarios.FirstOrDefault(us => us.Email == email && us.Senha == senha); 
        }


        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(us => us.IdUsuario == id);
        }

        public void Deletar(int id)
        {
            Usuarios del = new Usuarios();

            del = BuscarPorId(id);

            ctx.Usuarios.Remove(del);

            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.Include(us => us.IdTiposUsuarioNavigation).ToList();
        }
    }
}
