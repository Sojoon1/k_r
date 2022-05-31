namespace k_r
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Group")]
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            Listeners = new HashSet<Listener>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string НазваниеГруппы { get; set; }

        [Required]
        [StringLength(50)]
        public string КоличествоСлушателей { get; set; }

        [Required]
        [StringLength(50)]
        public string Преподаватель { get; set; }

        public int ID_Курса { get; set; }

        public int Кабинет { get; set; }

        public int ID_Расписания { get; set; }

        public virtual Schedule Schedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Listener> Listeners { get; set; }
    }
}
