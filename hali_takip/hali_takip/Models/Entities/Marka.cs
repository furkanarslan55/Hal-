namespace hali_takip.Models.Entities
{
    public class Marka
    {
        public int Id { get; set; }
        public string Ad { get; set; }
       
        public ICollection<Urun> Urunler { get; set; }
        public ICollection<Koleksiyon> Koleksiyonlar { get; set; }


    }
}
