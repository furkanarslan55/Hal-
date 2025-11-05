namespace hali_takip.Models.Entities
{
    public class Product
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public string Quality { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }    

    }
}
