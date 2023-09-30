using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ObserverDP.DAL
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        public string? DiscountCode { get; set; }
        public int? DiscountAmount { get; set; }
        public bool? DiscountCodeStatus { get; set; }
    }
}
