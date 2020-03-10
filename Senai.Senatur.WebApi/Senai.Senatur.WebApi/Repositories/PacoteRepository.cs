using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Repositories
{
    public class PacoteRepository : IPacote
    {
        SenaturContext ctx = new SenaturContext();

        public void AdicionarPacote(Pacotes pacotes)
        {
            ctx.Pacotes.Add(pacotes);
            ctx.SaveChanges();
        }

        public void AtualizarIdCorpo(Pacotes pacoteAtualizado)
        {
            Pacotes pacote = new Pacotes();

            pacote = BuscarPorId(pacoteAtualizado.IdPacote);

            pacote.NomeCidade = pacoteAtualizado.NomeCidade;
            pacote.NomePacote = pacoteAtualizado.NomePacote;
            pacote.Valor = pacoteAtualizado.Valor;
            pacote.Descricao = pacoteAtualizado.Descricao;
            pacote.DataIda = pacoteAtualizado.DataIda;
            pacote.DataVolta = pacoteAtualizado.DataVolta;
            pacote.Ativo = pacoteAtualizado.Ativo;

            ctx.Pacotes.Update(pacote);

            ctx.SaveChanges();
        }

        public Pacotes BuscarPorId(int id)
        {
            return ctx.Pacotes.FirstOrDefault(p => p.IdPacote == id);
        }

        public void Deletar(int id)
        {
            Pacotes pacotes = new Pacotes();

            pacotes = BuscarPorId(id);

            ctx.Pacotes.Remove(pacotes);

            ctx.SaveChanges();
        }

        public List<Pacotes> Listar()
        {
            return ctx.Pacotes.ToList();
        }
    }
}
