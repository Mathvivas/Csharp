using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CursoApi.Models.Usuarios;
using CursoApi.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace CursoApi.Controllers {

    [Route("api/v1/usuario")]
    [ApiController]

    public class UsuarioController : ControllerBase {

        // dotnet run --urls=http://localhost:5000/
        // Para entrar no swagger --> /swagger

        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </summary>
        /// <param name="loginViewModelInput">View Model do Login</param>
        /// <returns>Retorna status ok, dados do usuário e o token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao Autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput) {
            
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput) {
            
            return Created("", registroViewModelInput);
        }
    }
}