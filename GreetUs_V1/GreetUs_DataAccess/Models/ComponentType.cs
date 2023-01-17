using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("component_types")]
    internal class ComponentType
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("component_name", TypeName = "nvarchar")]
        public string ComponentName { get; set; } = null!;
        public ICollection<ComponentLayout> ComponentLayout { get; set; }
        public ICollection<ComponentOption> ComponentOptions { get; set; }
    }
}
