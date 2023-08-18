namespace WTOPMDb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Field> Fields { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}