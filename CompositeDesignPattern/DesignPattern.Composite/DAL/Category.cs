using System.ComponentModel.DataAnnotations;

namespace DesignPattern.Composite.DAL
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public int? ParentCategoryID { get; set; } //Hoca UpperId yaptı burayı
        public List<Product>? Products { get; set; }
    }
}
