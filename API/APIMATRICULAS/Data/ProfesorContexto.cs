using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class ProfesorContexto : DbContext
    {
        public ProfesorContexto(
            DbContextOptions<ProfesorContexto> options) : base(options)
        {

        }
        //Agregar nuestro DbSet

        public DbSet <Profesor> ProfesorItems { get; set; }
            


    }
}
