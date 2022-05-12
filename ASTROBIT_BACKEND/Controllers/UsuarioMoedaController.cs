using ASTROBIT_BACKEND.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASTROBIT_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioMoedaController : ControllerBase
    {
        private readonly Contexto db;

        public UsuarioMoedaController(Contexto contexto)
        {
            db = contexto;
        }

        [HttpGet("[controller]/[action]/{UsuarioId}/{MoedaId}")]
        public MoedaResponse Favoritar(int UsuarioId, int MoedaId)
        {
            Entidades.UsuarioMoeda novo_registro = new Entidades.UsuarioMoeda();
            novo_registro.Moeda_Id = MoedaId;
            novo_registro.Usuario_Id = UsuarioId;
            db.UsuarioMoeda.Add(novo_registro);
            db.SaveChanges();

            return new MoedaResponse { Success = "Favoritado"};
        }
    }
}
