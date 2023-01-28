namespace GroceryAppSql.WebapiServices.Models
{
    public abstract class BaseResponse
    {
        public List<string> Errors { get; set; }
        public bool HasError { get; set; }
        public bool IsSuccessFul { get; set; }
    }
}
