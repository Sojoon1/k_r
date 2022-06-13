namespace k_r.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Сourses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сourses()
        {
            Listener = new HashSet<Listener>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string Длительность { get; set; }

        [Required]
        [StringLength(50)]
        public string Цена { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Listener> Listener { get; set; }
    }
}
