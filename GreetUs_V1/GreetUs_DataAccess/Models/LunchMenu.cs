using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("lunch_menus")]
    internal class LunchMenu
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("menu_name", TypeName = "nvarchar(100)")]
        [Required]
        public string MenuName { get; set; } = null!;

        [Column("start_date", TypeName = "date")]
        [Required]
        public DateTime StartDate { get; set; }

        [Column("end_date", TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [Column("description", TypeName = "nvarchar(2000)")]
        [Required]
        public string Description { get; set; } = null!;

        [Column("component_layout_id", TypeName = "int")]
        [Required]
        public ComponentLayout ComponentLayout { get; set; }
    }
}
