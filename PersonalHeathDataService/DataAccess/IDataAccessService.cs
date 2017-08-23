using PersonalHeathDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalHeathDataService.DataAccess
{
    interface IDataAccessService
    {
        UserInfo GetUser(string uid);
        IEnumerable<UserInfo> GetUsers();
    }
}
