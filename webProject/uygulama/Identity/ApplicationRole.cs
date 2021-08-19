using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace uygulama.Entity
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; }
        
        
        public ApplicationRole()
        {

        }
        public ApplicationRole(string rolename, string description)
        {
            this.Description = description;

        }

    }
}