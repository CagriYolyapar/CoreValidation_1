using System.ComponentModel.DataAnnotations;

namespace CoreValidation_1.Models.Categories.RequestModels
{
    public class CreateCategoryRequestModel
    {
        //DataAnnotation'da yer tutucu operatorleri sayılarla verilir... 0 , ilgili property neyse onu alır...
        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [MaxLength(15,ErrorMessage ="{0} en fazla {1} karakter alabilir")]
        [MinLength(5,ErrorMessage = "{0} minimum {1} karakter alabilir")]
        [Display(Name ="Kategori ismi")]
        public string CategoryName { get; set; }


        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [MinLength(10,ErrorMessage = "{0} en az {1} karakter alabilir")]
        [Display(Name = "Aciklama")]
        public string Description { get; set; }

    }
}
