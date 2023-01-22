﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEducionITObservar.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        [Key]
        public int IDEvaluacion { get; set; }
        public int IDTipo { get; set; }
        public int IDEstudiante { get; set; }
        public int IDDetalle { get; set; }
        public double Nota { get; set; }

        [ForeignKey("IDTipo")]    
        public Tipo Tipo { get; set; }

        [ForeignKey("IDEstudiante")]
        public Estudiante Estudiante { get; set; }

        [ForeignKey("IDDetalle")]
        public Detalle Detalle { get; set; }
    }
}
