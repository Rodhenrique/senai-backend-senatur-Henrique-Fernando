using Senai.Senatur.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.Interfaces
{
    interface IPacote
    {
        List<Pacotes> Listar();

        Pacotes BuscarPorId(int id);

        void AdicionarPacote(Pacotes pacotes);

        void AtualizarIdCorpo(Pacotes pacotes);

        void Deletar(int id);
<<<<<<< HEAD:backend/Senai.Senatur.WebApi/Senai.Senatur.WebApi/Interfaces/IPacote.cs
=======

        List<Pacotes> ListarPacoteAtivos();

        List<Pacotes> ListarPacoteInativo();

>>>>>>> parent of 9d51f02... 32 commit:Senai.Senatur.WebApi/Senai.Senatur.WebApi/Interfaces/IPacote.cs
    }
}
