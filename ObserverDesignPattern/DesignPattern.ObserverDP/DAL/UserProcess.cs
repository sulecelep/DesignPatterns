using System.ComponentModel.DataAnnotations;

namespace DesignPattern.ObserverDP.DAL
{
    public class UserProcess
    {
        [Key]
        public int UserProcessID { get; set; }
        public string? NameSurname { get; set; }
        public string? Content { get; set; }
        public string? Magazine { get; set; }
    }
}
