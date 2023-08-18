using WTOPMDb.Helpers;

namespace WTOPMDb.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TypeField Type { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}