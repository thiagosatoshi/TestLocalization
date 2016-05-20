using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestLocalization.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        public string Provider { get; set; }

        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        [Display(Name = "Code")]
        //[Display(Name = "Code", ResourceType = typeof(ViewRes.Names))] ????
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        //[Display(Name = "Remember this browser?")]
        [Display(Name = "RememberBrowser", ResourceType = typeof(ViewRes.Names))]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        //[EmailAddress]
        [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        public string Email { get; set; }

        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Password", ResourceType = typeof(ViewRes.Names))]
        public string Password { get; set; }

        //[Display(Name = "Remember me?")]
        [Display(Name = "RememberMe", ResourceType = typeof(ViewRes.Names))]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[EmailAddress]
        [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        public string Email { get; set; }

        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [StringLength(100, ErrorMessageResourceName = "PasswordMinLength", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings), MinimumLength = 6)]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Password", ResourceType = typeof(ViewRes.Names))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(ViewRes.Names))]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Compare("Password", ErrorMessageResourceName = "PasswordMustMatch", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[EmailAddress]
        [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        public string Email { get; set; }

        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [StringLength(100, ErrorMessageResourceName = "PasswordMinLength", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings), MinimumLength = 6)]
        [DataType(DataType.Password)]
        //[Display(Name = "Password")]
        [Display(Name = "Password", ResourceType = typeof(ViewRes.Names))]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(ViewRes.Names))]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Compare("Password", ErrorMessageResourceName = "PasswordMustMatch", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        //[Required]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[EmailAddress]
        [EmailAddress(ErrorMessageResourceName = "EmailAddress", ErrorMessageResourceType = typeof(ViewRes.ValidationStrings))]
        //[Display(Name = "Email")]
        [Display(Name = "Email", ResourceType = typeof(ViewRes.Names))]
        public string Email { get; set; }
    }
}
