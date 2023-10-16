namespace Lab17Extry.ShopResources
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Img { get; set; }
        public List<Product> Products { get; set; }= new List<Product>();
      

        public List<Manufacturer> Manufacturers { get; set; } = new List<Manufacturer>();
        // public Manufacturer Manufacturer { get; set; }
        public override string ToString()
        {
            return $"Name of category:{Name}";
        }
    }
}
