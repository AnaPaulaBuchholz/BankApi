using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models
{
    public class Conta
    {
        [Key]
        public Guid IdConta { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal Saldo { get; set; }

        public bool EstaAtivo { get; set; }

        public TipoConta TipoConta { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal LancamentosFuturos { get; set; }

        [ForeignKey("Cliente")]
        public Guid IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }

    public enum TipoConta
    { 
        Corrente,
        Poupanca,
        Investimento
    }
}
