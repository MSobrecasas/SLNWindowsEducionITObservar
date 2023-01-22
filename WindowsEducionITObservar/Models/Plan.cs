using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int IDPlan { get; set; }
        public int IDCarrera { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        [ForeignKey("IDCarrera")]
        public Carrera Carrera { get; set; }
    }
}
