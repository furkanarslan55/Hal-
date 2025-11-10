namespace hali_takip.Models.Entities
{
    public class Koleksiyon
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public ICollection<Urun> Urunler { get; set; }
        public Marka Marka { get; set; }

    }
}
