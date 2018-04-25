using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine.Domain
{
    public class User
    {
        public string Id { get; set; }

        public string UserLink { get; set; }

        public string FirstName {get;set;}

        public string LastName { get; set; }

        public string MaidenName { get; set; }

        public string City { get; set; }

        public string BDate { get; set; }

        public string Age { get; set; }

        public string Sex { get; set; }

        public string Status { get; set; }

        public string HomePhone { get; set; }

        public string MobilePhone { get; set; }

        public string PhotoId { get; set; }

        public string Relation { get; set; }

        public bool IsLiked { get; set; }

        public string Ineterests { get; set; }

        public string Music { get; set; }

        public string Movies { get; set; }

        public string Activities { get; set; }

        public string Books { get; set; }

        public string Games { get; set; }

        public string About { get; set; }
    }
}
