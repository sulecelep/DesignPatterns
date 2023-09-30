using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ObserverDP.DAL
{
    public class WelcomeMessage
    {
        [Key]
        public int WelcomeMessageID { get; set; }
        public string? NameSurname  { get; set; }
        public string? Content  { get; set; }
    }
}
