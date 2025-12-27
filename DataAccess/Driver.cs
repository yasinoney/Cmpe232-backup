namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema; // 1. BU SATIRI EKLEDÝK

    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            this.Trips = new HashSet<Trip>();
        }

        [Key]
        public int EmployeeID { get; set; }
        public string LicenseNumber { get; set; }

        // 2. BU SATIRI EKLEDÝK: SQL'deki gerçek kolon ismini buraya yazýyoruz.
        // Eðer SQL'de kolonun adý farklýysa (örn: Supervisor_ID), týrnak içini ona göre düzelt.
        [Column("SupervisorID")]
        public int SupervisorEmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Supervisor Supervisor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
