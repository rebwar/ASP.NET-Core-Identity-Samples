using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Infrastructures
{
    public class CustomPasswordValidator : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            IdentityError error = new IdentityError();
            bool iserror = false;
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                error.Code = "PasswordContainsUserName";
                error.Description = "Password cannot contain Username";
                iserror = true;
            }

            return Task.FromResult(iserror ? IdentityResult.Failed(error) : IdentityResult.Success);
        }
    }
}
