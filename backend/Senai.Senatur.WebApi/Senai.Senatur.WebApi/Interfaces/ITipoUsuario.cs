using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface ITipoUsuario
    {
        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(int id);

        void AdicionarTipoUsuario(TiposUsuario tipos);

        void AtualizarIdCorpo(TiposUsuario tipos);

        void Deletar(int id);
    }
}
