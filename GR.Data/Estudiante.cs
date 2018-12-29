using System;
using System.Collections.Generic;
using System.Text;

namespace GR.Data
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaMatricula { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }

    }
}
