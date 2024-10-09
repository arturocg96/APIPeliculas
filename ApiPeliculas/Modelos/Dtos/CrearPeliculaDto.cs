using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPeliculas.Modelos.Dtos
{
    public class CrearPeliculaDto
    {       
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public string? RutaIMagen { get; set; }
        public IFormFile Imagen {  get; set; }
        public enum CrearTipoClasificacion { Siete, Trece, Dieciseis, Diechiocho }
        public CrearTipoClasificacion Clasificacion { get; set; }       
        public int categoriaId { get; set; }       
    }
}
