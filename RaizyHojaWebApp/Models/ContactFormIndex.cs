using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RaizyHojaWebApp.Models
{
    public class ContactFormIndex
    {
        // Id para cada entrada del formulario
        [Key]
        public int Id { get; set; }

        // nombre obligatorio con un maximo de 100 caracteres
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string Name { get; set; }

        // email obligatorio con un maximo de 100 caracteres y validador de formato
        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(100, ErrorMessage = "El email no puede tener más de 100 caracteres")]
        public string Email { get; set; }

        // el mensje es obligatorio y tiene un maximo de 1000 caracteres
        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(1000, ErrorMessage = "El mensaje no puede tener más de 1000 caracteres")]
        public string Message { get; set; }

        // Fecha de creación automática con el valor actual al momento de guardar el formulario
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}