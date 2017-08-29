using System.Runtime.Serialization;

namespace PersonalHeathDataService.Models
{
    [DataContract]
    public class AuthUserInfo
    {
        [DataMember]
        public string Uid { get; set; }
        [DataMember]
        public string Guid { get; set; }
    }
}