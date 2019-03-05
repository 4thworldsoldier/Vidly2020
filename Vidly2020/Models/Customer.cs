using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2020.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool  IsSubscribedToNewsLetter { get; set; }
        //nav prop from one type to its related types
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}