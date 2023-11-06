using System.ComponentModel.DataAnnotations;

namespace OrFarm.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
        public string? Phone { get; set; }
        public string? Adress { get; set; }
    }
}
