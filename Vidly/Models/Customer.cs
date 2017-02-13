using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        //Navigation property, allows to naavigate from one type to another.
        public MembershipType MembershipType { get; set; }

        //Convention. Entity framework recognizes it as foreign key.
        public byte MembershipTypeId { get; set; }
    }
}