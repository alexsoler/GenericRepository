using System;
using System.Collections.Generic;
using System.Text;

namespace GR.Data
{
    public class Curso
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Creditos { get; set; }
        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}
