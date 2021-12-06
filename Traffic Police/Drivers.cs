namespace Traffic_Police
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(25)]
        public string Passport { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress_registration { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress_life { get; set; }

        [StringLength(100)]
        public string WorkingPlace { get; set; }

        [StringLength(50)]
        public string JobName { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Photo { get; set; }

        [StringLength(100)]
        public string Descriphion { get; set; }
    }
}
