﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Unimar.Domain.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public bool Disponivel { get; set; }
        public bool Ead { get; set; }
    }
}
