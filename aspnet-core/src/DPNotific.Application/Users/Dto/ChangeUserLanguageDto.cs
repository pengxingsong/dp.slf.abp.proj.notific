using System.ComponentModel.DataAnnotations;

namespace DPNotific.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}