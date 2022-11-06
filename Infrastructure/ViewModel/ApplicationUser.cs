﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.ViewModel
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public string? UserImage { get; set; }
        public bool IsActive { get; set; }
    }
}
