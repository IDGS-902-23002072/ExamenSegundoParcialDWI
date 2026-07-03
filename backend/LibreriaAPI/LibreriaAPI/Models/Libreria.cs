using System.Globalization;

namespace LibreriaAPI.Models
{
    public class Libreria
    {
        public int IdLibro { get; set; }
        public string? NombreLibro { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string? ImagURL { get; set; }
        public string? Autor { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }
    }
}
