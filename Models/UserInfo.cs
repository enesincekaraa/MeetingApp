using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Ad Alanı Zorunlu")]
        public string? Name { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email Alanı Zorunlu")]
        [EmailAddress(ErrorMessage ="Hatalı Email")]
        public string? Email { get; set; }
        [Required]
        public bool WillAttend {  get; set; }

    }
}
