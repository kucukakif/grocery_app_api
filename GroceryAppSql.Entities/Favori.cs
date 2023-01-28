using GroceryAppSql.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryAppSql.Entities
{
    public class Favori : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
    }
}
