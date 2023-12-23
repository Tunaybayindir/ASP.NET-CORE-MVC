using System.ComponentModel.DataAnnotations;

namespace Departmanlar.Models
{
    public class personel
    {
        [Key]
        public int perId { get; set; }
        public string perAd { get; set; }
        public string perSoyad { get; set; }
        public string perSehir { get; set; }
        //nullable: true, false geliyor true yapınca hata düzeliyor
        public departmanlar departmanlars { get; set; }

    }
}
