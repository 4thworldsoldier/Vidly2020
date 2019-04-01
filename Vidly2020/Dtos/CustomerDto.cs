using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2020.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly2020.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
    
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        // [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}