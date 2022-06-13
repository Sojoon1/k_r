namespace k_r.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Listener")]
    public partial class Listener
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [Required]
        [StringLength(50)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаРождения { get; set; }

        [Required]
        [StringLength(50)]
        public string Телефон { get; set; }

        [Required]
        [StringLength(50)]
        public string Почта { get; set; }

        public int ID_Курсы { get; set; }

        public int ID_Группа { get; set; }

        public int ID_Role { get; set; }

        public virtual Groups Groups { get; set; }

        public virtual Role Role { get; set; }

        public virtual Сourses Сourses { get; set; }
    }
}
