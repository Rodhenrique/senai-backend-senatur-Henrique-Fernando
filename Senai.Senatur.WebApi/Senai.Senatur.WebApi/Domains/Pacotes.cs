using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        public int IdPacote { get; set; }

        [Required(ErrorMessage = "O Nome do pacote é obrigatório")]
        [DataType(DataType.Text)]
        public string NomePacote { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatório")]
        [DataType(DataType.Text)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Data de ida é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime DataIda { get; set; }

        [Required(ErrorMessage = "A data de volta é obrigatório")]
        [DataType(DataType.DateTime)]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "O valor do pacote é obrigatório")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        public bool? Ativo { get; set; }


        [Required(ErrorMessage = "O nome da cidade é obrigatório")]
        [DataType(DataType.Text)]
        public string NomeCidade { get; set; }
    }
}
