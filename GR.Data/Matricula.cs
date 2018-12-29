using System;
using System.Collections.Generic;
using System.Text;

namespace GR.Data
{
    public enum Grado { A, B, C, D, E, F }

    public class Matricula
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int CursoId { get; set; }
        public Grado? Grado { get; set; }

        public virtual Estudiante Estudiante { get; set; }
        public virtual Curso Curso { get; set; }
    }
}
