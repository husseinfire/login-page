using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace WebApplication3.Models
{
    [DataContract]
    public class RegistrationUser
    {
        [Key] public int id { get; set; }
        public string Login { get; set; }
        
        public string Password { get; set; }

         public string RePassword { get; set; }

    }
}