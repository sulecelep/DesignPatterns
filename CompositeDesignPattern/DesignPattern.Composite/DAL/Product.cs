using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Composite.DAL
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }
    }
}
