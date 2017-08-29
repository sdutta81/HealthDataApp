using System;
using System.Runtime.Serialization;

namespace PersonalHeathDataService.Models
{
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string Uid { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime Dob { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Cell { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}