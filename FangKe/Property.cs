namespace FangKe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Property")]
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            Users = new HashSet<User>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Propertyid { get; set; }

        [StringLength(25)]
        public string Streetaddress { get; set; }

        [StringLength(25)]
        public string City { get; set; }

        [StringLength(25)]
        public string State { get; set; }

        [Required]
        [StringLength(25)]
        public string Country { get; set; }

        [Required]
        [StringLength(25)]
        public string PostalCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime Dateavailable { get; set; }

        public int Roomid { get; set; }

        [StringLength(20)]
        public string Propertytype { get; set; }

        [StringLength(20)]
        public string Parking { get; set; }

        [StringLength(5)]
        public string Pets { get; set; }

        public int Numberofoccupants { get; set; }

        [StringLength(5)]
        public string Washerdryer { get; set; }

        [StringLength(5)]
        public string Photoincluded { get; set; }

        public string Notes { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
