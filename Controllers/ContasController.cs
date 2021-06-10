using BankApi.Data;
using BankApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Controllers
{
    [Route("contas")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ContasController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("ConsultarSaldo")]
        public IActionResult ConsultarSaldo(Guid IdCliente)
        {
            Conta conta = _context.Contas.Where(c => c.IdCliente == IdCliente).FirstOrDefault();
            return new OkObjectResult(new { Saldo = conta.Saldo});
        }

    }

}
