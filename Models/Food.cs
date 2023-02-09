using CalorieCountingApplication.Enumerators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieCountingApplication.Models
{
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodId { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }
        public UnitOfMeasurement? UnitOfMeasurement { get; set; }
        public int? CalorieCount { get; set; }
    }
}
