namespace RESTFul
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int empID { get; set; }

        [StringLength(20)]
        public string firstName { get; set; }

        [StringLength(20)]
        public string lastName { get; set; }

        public int? Age { get; set; }

        [StringLength(20)]
        public string address { get; set; }
    }
}
