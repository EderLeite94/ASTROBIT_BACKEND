using ASTROBIT_BACKEND.Entidades;
using ASTROBIT_BACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASTROBIT_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly Contexto db;

        public UsuarioController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: api/<UsuarioController>
        [HttpGet]
        public List<Usuario> Get()
        {
            return db.USUARIO.ToList();
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> Get(int id)
        {
            var usuario = await db.USUARIO.FindAsync(id);
            if( usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }


        // POST api/Usuario
        [HttpPost]
        public int Post(Usuario usuario)
        {
            db.USUARIO.Add(usuario);
            db.SaveChanges();
            return usuario.Id;
        }

        // PUT api/Usuario/5
        [HttpPut("{id}")]
        public async Task<UpdateResponse> Put(int id, [FromBody] Usuario usuario)
        {
            if(id != usuario.Id)
            {
                return new UpdateResponse { Erro = "Não foi possivel alterar!" };
            }

            db.USUARIO.Update(usuario);

            try
            {
                await db.SaveChangesAsync();
            }
            catch
            {
                return new UpdateResponse { Erro = "Não foi possivel salvar!" };
            }

            return new UpdateResponse { Success = "Usuario alterado com sucesso!" };
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<RegisterResponse> Delete(int id)
        {
            var remove = await db.USUARIO.FindAsync(id);
            if (remove == null)
            {
                return new RegisterResponse { Erro = "Não foi possivel registrar!" };
            }

            db.USUARIO.Remove(remove);
            await db.SaveChangesAsync();

            return (new RegisterResponse
            {
                Success = "Usuario registrado com sucesso!"
            });
        }

        [HttpPost("login")]
        public LoginResponse Login([FromBody]Credencial credencial)
        {
            var usuario = db.USUARIO.Where(a => a.Login == credencial.Login && a.Senha == credencial.Senha).FirstOrDefault();
            if(usuario == null)
            {
                return new LoginResponse { Erro = "Credenciais Invalidas" };
            }
            return (new LoginResponse
            {
                Success = "Usuario logado com sucesso!"
            });
        }
    }
}
