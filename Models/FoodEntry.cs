using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieCountingApplication.Models
{
    public class FoodEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodEntryId { get; set; }
        [Required(ErrorMessage = "A food must be chosen.")]
        public Food Food { get; set; }
        [Required(ErrorMessage = "This field cannot be blank")]
        [Range(0, 9999, ErrorMessage = "Value must be between 0 and 9,999.")]
        public int Amount { get; set; }
        [Required(ErrorMessage = "This field cannot be blank")]
        [Range(0, 9999, ErrorMessage = "Cannot record calories less than 0 or greater than 9,999 for any food.")]
        public int CalorieCount { get; set; }
        [Required(ErrorMessage = "This field cannot be blank")]
        public DateTime DateTime { get; set; }
    }
}
