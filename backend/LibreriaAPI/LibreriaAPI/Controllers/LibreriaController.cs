using LibreriaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibreriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaController : ControllerBase
    {
        private readonly LibreriaContext? _context;

        public LibreriaController(LibreriaContext context)
        {
            _context = context;
        }

        //Metodo Get
        [HttpGet]
        [Route("GetLibros")]
        public async Task<ActionResult> GetLibros()
        {
            if (_context == null)
            {
                return NotFound();
            }

            var listaLibros = await _context.Librerias.ToListAsync();
            return Ok(listaLibros);
        }

    }
}
