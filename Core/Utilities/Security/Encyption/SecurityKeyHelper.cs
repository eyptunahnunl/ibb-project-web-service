using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        //Securitykey i byte array formatına getirir ve simetrik anahtar oluşturmaya yarar.
        public static SecurityKey CreateSecurityKey(string securityKey)
        {

            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            
        }
    }
}
