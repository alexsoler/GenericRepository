using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GR.Data
{
    class EstudianteMap
    {
        public EstudianteMap(EntityTypeBuilder<Estudiante> estudianteBuilder)
        {
            estudianteBuilder.Property(x => x.Nombre).IsRequired();
            estudianteBuilder.Property(x => x.Apellido).IsRequired();
            estudianteBuilder.Property(x => x.FechaMatricula).IsRequired();
        }
    }
}
