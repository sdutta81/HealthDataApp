using System.Runtime.Serialization;

namespace PersonalHeathDataService.Models
{
    [DataContract]
    public class LoginInfo
    {
        [DataMember(Name = "uid")]
        public string Uid { get; set; }
        [DataMember(Name = "pwd")]
        public string Pwd { get; set; }
    }
}