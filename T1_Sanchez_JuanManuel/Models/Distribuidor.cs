using System.ComponentModel.DataAnnotations;

namespace T1_Sanchez_JuanManuel.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La Razon Social es obligatoria")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El año de operación es obligatorio")]
        [Range(1900,3000,ErrorMessage ="El año de operación debe estar en el rango 1900 - 3000")]
        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }

    }
}
