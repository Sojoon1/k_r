namespace k_r
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Autotizations = new HashSet<Autotization>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ФИО { get; set; }

        public int ID_Office { get; set; }

        public int ID_Роль { get; set; }

        [Required]
        [StringLength(50)]
        public string Почта { get; set; }

        public int ID_Авторизация { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autotization> Autotizations { get; set; }

        public virtual Listener Listener { get; set; }

        public virtual Role Role { get; set; }
    }
}
