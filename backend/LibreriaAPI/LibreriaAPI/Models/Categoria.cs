using System.Text.Json.Serialization;

namespace LibreriaAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public  string? Descripcion { get; set; }
        [JsonIgnore]
        public virtual ICollection<Libreria> Librerias { get; set; } = new List<Libreria>();
    }
}
