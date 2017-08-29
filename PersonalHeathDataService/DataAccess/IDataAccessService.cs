using PersonalHeathDataService.Models;
using System.Collections.Generic;

namespace PersonalHeathDataService.DataAccess
{
    interface IDataAccessService
    {
        AuthUserInfo GetUserGuid(string uid, string pwd);
        UserInfo GetUser(string uid);
        IEnumerable<UserInfo> GetUsers();
    }
}
