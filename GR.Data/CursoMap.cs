using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GR.Data
{
    class CursoMap
    {
        public CursoMap(EntityTypeBuilder<Curso> cursoBuilder)
        {
            cursoBuilder.Property(x => x.Titulo).IsRequired().HasMaxLength(30);
            cursoBuilder.Property(x => x.Creditos).IsRequired();
        }
    }
}
