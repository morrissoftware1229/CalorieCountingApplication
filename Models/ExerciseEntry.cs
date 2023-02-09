using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CalorieCountingApplication.Models
{
    public class ExerciseEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExerciseEntryId { get; set; }
        [Required(ErrorMessage = "An exercise must be chosen.")]
        public Exercise Exercise { get; set; }
        [Required(ErrorMessage = "An amount must be entered.")]
        [Range(0, 9999, ErrorMessage = "Value must be between 0 and 9,999 minutes.")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "This field cannot be blank.")]
        [Range(0, 9999, ErrorMessage = "Cannot record calories burned less than 0 or greater than 9,999 for any food.")]
        public int CalorieCount { get; set; }
        [Required(ErrorMessage = "This field cannot be blank")]
        public DateTime DateTime { get; set; }
    }
}
