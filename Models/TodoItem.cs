using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        // El ID del usuario que creó la tarea (para que cada quien vea solo lo suyo)
        [Required]
        public string UserId { get; set; } = string.Empty;

        [Required]
        public string Titulo { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        [Required]
        public string Prioridad { get; set; } = "Media"; // Valores: Alta, Media, Baja

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}