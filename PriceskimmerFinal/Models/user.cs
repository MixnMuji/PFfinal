using System;
using System.Collections.Generic;
using System.Text;

namespace PriceskimmerFinal.Models
{
    internal class user: IdentyUser
    {
        Guid id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
