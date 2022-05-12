using ASTROBIT_BACKEND.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASTROBIT_BACKEND.Models
{
    public class GetResponse
    {
        public string Erro { get; set; }
        public string Success { get; set; }
        public Usuario Usuario { get; set; }
    }
}
