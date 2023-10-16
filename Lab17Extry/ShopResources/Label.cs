namespace Lab17Extry.ShopResources
{
    public class Label
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Guid BarCode { get; set; }= Guid.NewGuid();
        public double Price { get; set; }
        public override string ToString()
        {
            return $"BarCode:{BarCode} Price:{Price}";
        }
    }
}
