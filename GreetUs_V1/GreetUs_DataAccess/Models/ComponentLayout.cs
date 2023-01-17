using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetUs_DataAccess.Models
{
    [Table("component_layouts")]
    internal class ComponentLayout
    {
        [Key]
        [Column("guid", TypeName = "uniqueidentifier")]
        public Guid Guid { get; set; }

        [Column("width", TypeName = "int")]
        public int Width { get; set; }

        [Column("height", TypeName = "int")]
        public int Height { get; set; }

        [Column("position_x", TypeName = "int")]
        public int PositionX { get; set; }

        [Column("position_y", TypeName = "int")]
        public int PositionY { get; set; }

        [Column("position_allignment_x", TypeName = "int")]
        public int PositionAllignmentX { get; set; }

        [Column("position_allignment_y", TypeName = "int")]
        public int PositionAllignmentY { get; set; }

        [Column("component_position", TypeName = "varchar(50)")]
        public string ComponentPosition { get; set; }

        public Display Display { get; set; }
        public ComponentType ComponentType { get; set; }
        public object DBComponent { get; set; } = null;
    }
}
