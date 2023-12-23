namespace Basics.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public String Ad { get; set; } = string.Empty;
        public String Soyad { get; set; } = string.Empty;
        public String AdSoyad => $"{Ad}{Soyad.ToUpper()}";
        public int Yas { get; set; } 
    }
}