using System.ComponentModel.DataAnnotations;

namespace GroceryAppSql.WebapiServices.Models
{
    public class CartModel
    {
        [Required(ErrorMessage = "Name boş geçilemez!")]
        public string Name { get; set; }
        public int Number { get; set; }
        public int Price { get; set; }
        public string PictureUrl { get; set; }
        public string Description { get; set; }
        public int Piece { get; set; }
    }
}
