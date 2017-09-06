using System;
using System.Runtime.Serialization;

namespace PersonalHeathDataService.Models
{
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name ="uid")]
        public string Uid { get; set; }
        [DataMember(Name = "guid")]
        public string Guid { get; set; }
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "middleName")]
        public string MiddleName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }
        [DataMember(Name = "dob")]
        public DateTime Dob { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
        [DataMember(Name = "phone")]
        public string Phone { get; set; }
        [DataMember(Name = "cell")]
        public string Cell { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}