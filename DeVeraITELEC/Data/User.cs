using System;
using Microsoft.AspNetCore.Identity;

namespace DeVeraITELEC.Data
{
    public class User : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
    }
}
