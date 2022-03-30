using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using DemoMVC_Omar.Models;

// Instalar Microsoft.EntityFrameworkCore.SqlServer 5.0.0
// Instalar Microsoft.EntityFrameworkCore.Tools 5.0.0

namespace DemoMVC_Omar.Context
{
    public class CarteraDatabaseContext:DbContext //Hereda las propiedades de DBContext ****** Importante *****
    {
        public CarteraDatabaseContext(DbContextOptions<CarteraDatabaseContext>options):base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
