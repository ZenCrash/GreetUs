using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("people")]
    internal class Person
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("full_name", TypeName = "nvarchar(100)")]
        [Required]
        public string FullName { get; set; } = null!;

        [Column("birthday", TypeName = "date")]
        [Required]
        public DateTime Birthday { get; set; }

        [Column("hiring_date", TypeName = "date")]
        [Required]
        public DateTime HiringDate { get; set; }

        [Column("email", TypeName = "varchar(100)")]
        [Required]
        public string Email { get; set; } = null!;
    }
}
