using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class MyIdentityDbContext : IdentityDbContext<AppUser>
    {
        public MyIdentityDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
