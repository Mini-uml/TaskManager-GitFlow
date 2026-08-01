using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El título es obligatorio")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El título debe tener entre 3 y 50 caracteres")]
        public string Title { get; set; } = string.Empty;


        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(300)]
        public string Description { get; set; } = string.Empty;


        public bool Completed { get; set; }
    }
}