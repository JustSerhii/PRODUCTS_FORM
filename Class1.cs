using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Good
    {
        public int Price { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public Good(int price, string country, string name, string date, string description)
        {
            Price = price;
            Country = country;
            Name = name;
            Date = date;
            Description = description;
        }
    }
    public class Books : Good
    {
        private readonly int _pageAmount;
        private readonly string _publisher;
        private readonly string _author;

        public Books(string name, int price, string country, string date, string description,
        int pageAmount, string publisher, string author) : base(price, country, name, date, description)
        {
            _pageAmount = pageAmount;
            _publisher = publisher;
            _author = author;
        }
    }
    public class Products : Good
    {
        private readonly string _shelfLife;
        private readonly int _count;
        private readonly string _measure;

        public Products(string name, int price, string country, string date,
        string description, string shelfLife, int count, string measure) : base(price, country, name, date, description)
        {
            _shelfLife = shelfLife;
            _count = count;
            _measure = measure;
        }
    }
}
