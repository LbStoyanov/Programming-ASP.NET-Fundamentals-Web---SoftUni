using System.ComponentModel.DataAnnotations;

namespace ASP.NETIntro.Models
{
    public class TestModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="Ooooops!")]
        public string Product { get; set; }
    }
}
