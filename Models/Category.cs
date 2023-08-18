﻿namespace WTOPMDb.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}