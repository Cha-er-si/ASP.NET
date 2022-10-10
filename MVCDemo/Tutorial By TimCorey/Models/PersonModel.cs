using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Web;

namespace Tutorial_By_TimCorey.Models
{
    public class PersonModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; } = 0;
        public bool isALive { get; set; } = true;
    }
}