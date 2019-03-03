using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FangKe
{
    public class UserSignIn
    {
        [Key]
        public int userId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}