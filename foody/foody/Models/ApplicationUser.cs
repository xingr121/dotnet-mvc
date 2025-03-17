﻿using Microsoft.AspNetCore.Identity;

namespace foody.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
