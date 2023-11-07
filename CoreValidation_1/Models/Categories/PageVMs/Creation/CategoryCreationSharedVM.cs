using CoreValidation_1.Models.Categories.RequestModels;

namespace CoreValidation_1.Models.Categories.PageVMs.Creation
{
    public class CategoryCreationSharedVM
    {
        public CreateCategoryRequestModel Category { get; set; } //Buradaki RequestModel Response olarak gidiyor diye kafanızı karıstırmasın biz bu noktada eger kullanıcının gönderdigi şeyden hoslanmadıysak(Validation'a ters ise ) ona tekrar geri gönderiyoruz...
    }
}
