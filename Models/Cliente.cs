using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Cliente
    {

        [Key]
        public Guid IdCliente { get; set; }

        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
