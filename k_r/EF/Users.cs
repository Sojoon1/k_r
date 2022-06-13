namespace k_r.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_User { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [Required]
        [StringLength(50)]
        public string Отчество { get; set; }

        public int ID_Role { get; set; }

        [Required]
        [StringLength(50)]
        public string ДатаРождения { get; set; }

        [Required]
        [StringLength(50)]
        public string Телефон { get; set; }

        [Required]
        [StringLength(50)]
        public string Почта { get; set; }

        [Key]
        [StringLength(50)]
        public string Логин { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        public virtual Role Role { get; set; }
    }
}
