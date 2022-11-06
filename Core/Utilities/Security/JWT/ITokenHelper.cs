using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        /// <summary>
        /// Kullanı id şifre girdikten sonra çalışacak. 
        /// İlgili kullanıcı için veritabanına gider. 
        /// O kullanıcının claimlerini alır ve client tarafına gönderir.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="operationClaims"></param>
        /// <returns></returns>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
