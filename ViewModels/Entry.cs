using CalorieCountingApplication.Models;

namespace CalorieCountingApplication.ViewModels
{
    public class Entry
    {
        //Which data annotations do I need here?
        public IEnumerable<Food> Foods { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
