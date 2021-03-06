﻿using System.Collections.Generic;

namespace Registone.LogCenter.Domain.Models
{
    public class User
    {       
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual IList<Log> Logs { get; set; }
    }
}
