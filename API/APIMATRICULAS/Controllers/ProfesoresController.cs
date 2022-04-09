using APIMATRICULAS.Data;
using APIMATRICULAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Controllers
{
    public class ProfesoresController : ControllerBase
    {
        // creaamos el objeto que apiunta a la clase profesorContexto para poder tener acceso a todos los campos de la tabla
        //
        private readonly ProfesorContexto _context;

        public ProfesoresController(ProfesorContexto contexto)
        {
            //Cargamos la variable objeto con los campos de la tabla
            //
            _context = contexto;
        }
        [HttpGet]
        public async Task <ActionResult<IEnumerable<Profesor>>> GetProfesorItems()
        {
            return await _context.ProfesorItems.ToListAsync();
        }
       
    }
}
