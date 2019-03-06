using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly2020.Models;

namespace Vidly2020.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}