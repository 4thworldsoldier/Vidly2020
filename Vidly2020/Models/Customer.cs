using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly2020.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool  IsSubscribedToNewsLetter { get; set; }
        //nav prop from one type to its related types
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}