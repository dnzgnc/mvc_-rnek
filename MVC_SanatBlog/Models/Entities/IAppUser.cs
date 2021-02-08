using System.Collections.Generic;

namespace MVC_SanatBlog.Models.Entities
{
    public interface IAppUser
    {
        List<AppUserAndRole> AppUserAndRoles { get; set; }

        int AppUserId { get; set; }

        string Email { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Password { get; set; }

        string UserName { get; set; }




    }
}