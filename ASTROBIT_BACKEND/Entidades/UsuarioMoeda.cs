using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASTROBIT_BACKEND.Entidades
{
    public class UsuarioMoeda
    {
        public int Id { get; set; }
        public int Usuario_Id { get; set; }
        public Usuario Usuario { get; set; }
        public int Moeda_Id { get; set; }
        public Moeda Moeda { get; set; }
    }
}
