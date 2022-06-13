namespace k_r.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Groups = new HashSet<Groups>();
        }

        [Key]
        public int ID_Расписания { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаЗанятия { get; set; }

        [Required]
        [StringLength(50)]
        public string ВремяЗанятия { get; set; }

        [StringLength(50)]
        public string Кабинет { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groups> Groups { get; set; }
    }
}
