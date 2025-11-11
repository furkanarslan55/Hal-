namespace hali_takip.Models.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int MarkaId { get; set; }
        public string UrunKodu { get; set; }
        public string UrunFotografi { get; set; }
        public Koleksiyon Koleksiyon { get; set; }

        public Marka Marka { get; set; }    
    }
}
