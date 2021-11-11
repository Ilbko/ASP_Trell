using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trello_API.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(127)")]
        public string FullName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(max)")]
        public string Info { get; set; }
    }
}
