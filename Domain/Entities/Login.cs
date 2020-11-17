using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Login : Base
    {
        public string user { get; set; }
        public string password { get; set; }
    }
}
