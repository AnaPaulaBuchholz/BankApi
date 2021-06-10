using BankApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Conta> Contas { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }
    }
}
