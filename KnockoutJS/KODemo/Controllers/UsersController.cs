using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KODemo.Models;

namespace KODemo.Controllers
{
    // NB: WebAPI
    public class UsersController : ApiController
    {
        List<User> Users = new List<User>()
        { 
            new User { Username = "bsmith", MasterCompany = "UBS", Status = "Subscriber", AssignedSalesPerson = "Charles Moran", Comment = "Need to call"}, 
            new User { Username = "jones", MasterCompany = "UBS", Status = "Free Trial", AssignedSalesPerson = "Charles Moran", Comment = "Will buy"}, 
            new User { Username = "jim", MasterCompany = "Bank of America", Status = "Subscriber", AssignedSalesPerson = "Charles Moran", Comment = ""}, 
            new User { Username = "cory", MasterCompany = "Bank of America", Status = "Free Trial", AssignedSalesPerson = "Charles Moran", Comment = "No Comment"}, 
            new User { Username = "miles", MasterCompany = "CreditSights", Status = "Subscriber", AssignedSalesPerson = "Charles Moran", Comment = "When he's own the phone he tends to drown out"}, 
            new User { Username = "david", MasterCompany = "CreditSights", Status = "Subscriber", AssignedSalesPerson = "Jim Sullivan", Comment = ""}, 
            new User { Username = "calvin", MasterCompany = "CreditSights", Status = "Subscriber", AssignedSalesPerson = "Jim Sullivan", Comment = "Goes by the name Yoda"}, 
            new User { Username = "loscalzo", MasterCompany = "CreditSights", Status = "Subscriber", AssignedSalesPerson = "Jim Sullivan", Comment = ""}, 
            new User { Username = "jean", MasterCompany = "UBS", Status = "Subscriber", AssignedSalesPerson = "Jim Sullivan", Comment = "Call now!"}, 
            new User { Username = "jane", MasterCompany = "Cobb Enterprizes", Status = "Subscriber", AssignedSalesPerson = "Jim Finn", Comment = "Called last week"}, 
            new User { Username = "sarah", MasterCompany = "McCarthy Wealth Advisors", Status = "FreeTrial", AssignedSalesPerson = "Selina Strong", Comment = "The wife"}, 
            new User { Username = "kendra", MasterCompany = "McCarthy Wealth Advisors", Status = "FreeTrial", AssignedSalesPerson = "Selina Strong", Comment = "Owner's sister"}, 
            new User { Username = "shaun", MasterCompany = "McCarthy Wealth Advisors", Status = "FreeTrial", AssignedSalesPerson = "Selina Strong", Comment = "The owner"}, 
        };


        public User GetUserById(string id)
        {
            return Users.FirstOrDefault(p => p.Username.Equals(id));
        }

        public IEnumerable<User> GetUserByType(string type)
        {
            if ("all".Equals(type, StringComparison.CurrentCultureIgnoreCase))
                return Users.OrderBy(p => p.Username.ToLower());

            return Users.Where(p => p.Status.Equals(type, StringComparison.CurrentCultureIgnoreCase)).OrderBy(p=>p.Username.ToLower());
        }

    }
}
