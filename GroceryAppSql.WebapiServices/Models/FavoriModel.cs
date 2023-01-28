using System.ComponentModel.DataAnnotations;

namespace GroceryAppSql.WebapiServices.Models
{
    public class FavoriModel
    {
        [Required(ErrorMessage = "Number boş geçilemez!")]
        public int Number { get; set; }
    }
}
