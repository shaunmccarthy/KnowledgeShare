using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace KODemo.Models
{
    [DataContract(Name="user")]
    public class User
    {
        [DataMember(Name="username")]
        public string Username { get; set; }

        [DataMember(Name = "masterCompany")]
        public string MasterCompany { get; set; }

        [DataMember(Name = "assignedSalesPerson")]
        public string AssignedSalesPerson { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "comment")]
        public string Comment { get; set; }
    }
}