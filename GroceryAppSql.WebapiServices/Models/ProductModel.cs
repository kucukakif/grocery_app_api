using System.ComponentModel.DataAnnotations;

namespace GroceryAppSql.WebapiServices.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Name boş geçilemez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price boş geçilemez!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Picture boş geçilemez!")]
        public string PictureUrl { get; set; }
        public int Categori { get; set; }
        public string Description { get; set; }
        public bool isFavori { get; set; }
        public int Piece { get; set; }
    }
}
