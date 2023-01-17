using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("component_options")]
    internal class ComponentOption
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("option_name", TypeName = "nvarchar(100)")]
        public string OptionName { get; set; }
        public ComponentType ComponentType { get; set; }
    }
}
