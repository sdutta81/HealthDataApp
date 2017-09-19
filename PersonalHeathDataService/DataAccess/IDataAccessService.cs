using PersonalHeathDataService.Models;
using System.Collections.Generic;

namespace PersonalHeathDataService.DataAccess
{
    public interface IDataAccessService
    {
        AuthUserInfo GetUserGuid(LoginInfo loginInfo);
        UserInfo GetUser(string uid, string guid);
        IEnumerable<UserInfo> GetUsers();
    }
}
