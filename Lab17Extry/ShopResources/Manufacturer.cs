namespace Lab17Extry.ShopResources
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CUI { get; set; }
        public List<Category> Categories { get; set; }=new List<Category>();
        public override string ToString()
        {
            return $"Name of Manufactuer:{Name}, Address:{Address}";
        }
    }
}
