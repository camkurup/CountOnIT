using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOnIT.Models
{
    public class ProductModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int CountOnStage { get; set; }

        public ProductModel(int id, string name, string description, string img, int countOnStage)
        {
            Id = id;
            Name = name;
            Description = description;
            Img = img;
            CountOnStage = countOnStage;
        }

        public ProductModel()
        {
        }
    }
}
