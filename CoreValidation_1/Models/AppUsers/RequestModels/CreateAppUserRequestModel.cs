using System.ComponentModel.DataAnnotations;

namespace CoreValidation_1.Models.AppUsers.RequestModels
{
    public class CreateAppUserRequestModel
    {
        [Required(ErrorMessage = "{0} zorunlu bir alandır")]
        [Display(Name ="Kullanıcı İsmi")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="{0} zorunlu bir alandır")]
        [MinLength(6,ErrorMessage = "{0} minimum {1} karakter alabilir ")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage ="Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage ="Lütfen Email formatında bir adres giriniz")]
        public string Email { get; set; }

    }
}
