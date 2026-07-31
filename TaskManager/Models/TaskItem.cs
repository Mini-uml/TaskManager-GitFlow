using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models 
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [StringLength(300)]
        public string Description { get; set; } = string.Empty;

        public bool Completed { get; set; }
    }

}