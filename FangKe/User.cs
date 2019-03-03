namespace FangKe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userid { get; set; }

        [Required]
        [StringLength(20)]
        public string Fristname { get; set; }

        [Required]
        [StringLength(20)]
        public string Lastname { get; set; }

        [StringLength(70)]
        public string Emailaddress { get; set; }

        [Required]
        [StringLength(15)]
        public string Phonenumber { get; set; }

        public int Propertyid { get; set; }

        public int Roomid { get; set; }

        public virtual Property Property { get; set; }

        public virtual Room Room { get; set; }

        public virtual UserSignIn UserSignIn { get; set; }
    }
}
