using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("displays")]
    internal class Display
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("display_name", TypeName = "nvarchar(100)")]
        [Required]
        public string DisplayName { get; set; } = null!;

        public IEnumerable<ComponentLayout> Component_Layouts { get; set; }
    }
}
