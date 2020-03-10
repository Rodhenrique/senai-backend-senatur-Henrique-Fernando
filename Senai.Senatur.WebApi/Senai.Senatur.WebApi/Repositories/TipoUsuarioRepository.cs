using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuario
    {
        SenaturContext ctx = new SenaturContext();

        public void AdicionarTipoUsuario(TiposUsuario tipos)
        {
            ctx.TiposUsuario.Add(tipos);

            ctx.SaveChanges();
        }

        public void AtualizarIdCorpo(TiposUsuario tiposAtulizados)
        {
            TiposUsuario atual = new TiposUsuario();

            atual = BuscarPorId(tiposAtulizados.IdTiposUsuario);

            atual.Titulo = tiposAtulizados.Titulo;

            ctx.TiposUsuario.Update(atual);

            ctx.SaveChanges();
        }

        public TiposUsuario BuscarPorId(int id)
        {
            return ctx.TiposUsuario.FirstOrDefault(t => t.IdTiposUsuario == id);
        }

        public void Deletar(int id)
        {
            TiposUsuario del = new TiposUsuario();

            del = BuscarPorId(id);

            ctx.TiposUsuario.Remove(del);

            ctx.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return ctx.TiposUsuario.ToList();
        }
    }
}
