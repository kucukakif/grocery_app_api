using GroceryAppSql.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string PictureUrl { get; set; }
        public int Categori { get; set; }
        public string Description { get; set; }
        public bool isFavori { get; set; }
        public int Piece { get; set; }
    }
}
