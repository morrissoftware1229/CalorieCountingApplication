using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieCountingApplication.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseId { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Length of name must be between 3 and 50 characters.")]
        public string Name { get; set; }

    }
}
