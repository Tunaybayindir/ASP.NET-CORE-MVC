namespace Departmanlar.Models
{
    public class Birim
    {
        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public IList<Personel> Personels { get; set; }

    }
}
