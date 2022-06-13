namespace k_r.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Groups()
        {
            Listener = new HashSet<Listener>();
        }

        [Key]
        public int ID_Группы { get; set; }

        [Required]
        [StringLength(50)]
        public string Название { get; set; }

        [Required]
        [StringLength(50)]
        public string КолисествоСлушателей { get; set; }

        public int ID_Расписания { get; set; }

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Listener> Listener { get; set; }
    }
}
