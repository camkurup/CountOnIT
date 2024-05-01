using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int CountInStorage { get; set; }

        public Product(int id, string name, string description, string imageName, int countInStorage)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageName = imageName;
            CountInStorage = countInStorage;
        }

    }
}
