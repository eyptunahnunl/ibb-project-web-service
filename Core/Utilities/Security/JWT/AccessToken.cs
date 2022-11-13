﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public int UserId { get; set; }
        public DateTime Expiration { get; set; } //token bitiş zamanını veren değer.
    }
}
