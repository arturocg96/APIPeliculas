using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPeliculas.Modelos.Dtos
{
    public class ActualizarPeliculaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public string? RutaIMagen { get; set; }
        public string? RutaLocalIMagen { get; set; }
        public IFormFile Imagen { get; set; }
        public enum TipoClasificacion { Siete, Trece, Dieciseis, Diechiocho }
        public TipoClasificacion Clasificacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
       
        public int categoriaId { get; set; }       
    }
}
