namespace FangKe
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rent")]
    public partial class Rent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rent()
        {
            Rooms = new HashSet<Room>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rentid { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Rentamount { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal Rentdeposit { get; set; }

        [StringLength(10)]
        public string Utilityinclude { get; set; }

        public int Lengthofleaseinmonth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
