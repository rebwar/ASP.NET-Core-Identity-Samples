﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class AppUser:IdentityUser
    {
        public string TwitterId { get; set; }

    }
   
}
