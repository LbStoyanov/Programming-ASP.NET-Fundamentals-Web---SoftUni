using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models
{
    public class PostViewModel
    {
        [UIHint("hidden")]
        
        public int Id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "The field {0} is requiered!")]
        [StringLength(50, MinimumLength = 10,ErrorMessage = "The field {0} is between {2} and {1}")]
        public string Title { get; set; } = null!;

        [Display(Name = "Content")]
        [Required(ErrorMessage = "The field {0} is requiered!")]
        [StringLength(1500, MinimumLength = 30, ErrorMessage = "The field {0} is between {2} and {1}")]
        public string Content { get; set; } = null!;
    }
}
