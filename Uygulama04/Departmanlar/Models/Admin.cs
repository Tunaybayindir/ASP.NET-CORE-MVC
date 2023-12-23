using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Departmanlar.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "Varchar(20)")]
        public string Kullanici { get; set; }
        [Column(TypeName = "Varchar (10)")]
        public string Sifre { get; set; }

    }
}
