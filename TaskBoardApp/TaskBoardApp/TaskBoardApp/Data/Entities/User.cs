using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static TaskBoardApp.Data.DataConstants.User;

namespace TaskBoardApp.Data.Entities
{
    public class User : IdentityUser
    {
        //public Guid Id { get; set; }

        [Required]
        [MaxLength(MaxUserFirstName)]
        public string FirstName { get; init; } = null!;

        [Required]
        [MaxLength(MaxUserLastName)]
        public string LastName { get; init; } = null!;
    }
}
