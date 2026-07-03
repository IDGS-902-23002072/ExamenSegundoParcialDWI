using LibreriaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibreriaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly LibreriaContext _context;

        public CategoriaController(LibreriaContext context)
        {
            _context = context;
        }

        [HttpGet("GetCategorias")]
        public async Task<ActionResult> GetCategorias()
        {
            var listaCategorias = await _context.Categorias.ToListAsync();
            return Ok(listaCategorias);
        }
    }
}