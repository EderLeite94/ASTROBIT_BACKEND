using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASTROBIT_BACKEND.Entidades
{
    public class Permissoes
    {
        public int Id { get; set; }
        public string Tipo_permicao { get; set; }
        public string Data_inicio { get; set; }
        public string Data_fim { get; set; }
    }
}
