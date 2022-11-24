using System.ComponentModel.DataAnnotations;

namespace AdzuInfluencerMarketing.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}