using System.ComponentModel.DataAnnotations;

namespace PersonalExpenseTracker.Persistence.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public required string CategoryName { get; set; }
    }
}