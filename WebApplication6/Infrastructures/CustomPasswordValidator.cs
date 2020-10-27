using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Infrastructures
{
    public class CustomPasswordValidator : PasswordValidator<AppUser>
    {
        
        

        public override async Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            IdentityResult result=await  base.ValidateAsync(manager, user, password);
            List<IdentityError> errors = result.Succeeded ? new List<IdentityError>() : result.Errors.ToList();
            if (password.ToLower().Contains(user.UserName.ToLower()))
            {
                errors.Add(new IdentityError
                {
                    Code = "PasswordContainsUserName",
                     Description = "Password cannot contain Username"

            });
            }
            return errors.Count==0 ? IdentityResult.Success :IdentityResult.Failed(errors.ToArray())  ;
        }
    }
}
