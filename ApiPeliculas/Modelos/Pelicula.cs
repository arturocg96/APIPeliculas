using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPeliculas.Modelos
{
    public class Pelicula
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public string? RutaIMagen { get; set; }
        public string? RutaLocalIMagen { get; set; }
        public enum TipoClasificacion { Siete, Trece, Dieciseis, Diechiocho }
        public TipoClasificacion Clasificacion {  get; set; }
        public DateTime? FechaCreacion { get; set; }

        //Relación con Categoria
        public int categoriaId { get; set; }
        [ForeignKey("categoriaId")]
        public Categoria Categoria { get; set; }
    }
}
