using System.ComponentModel.DataAnnotations;

namespace Departmanlar.Models
{
    public class departmanlar
    {
        [Key]
        public int ID { get; set; }
        public string departmanAd { get; set; }
        public List<personel> personel { get; set;}
    }
}
