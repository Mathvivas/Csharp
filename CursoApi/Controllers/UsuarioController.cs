namespace CursoApi.Controllers {

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase {

        [HttpPost]
        public IActionResult logar(LoginViewModelInput loginViewModelInput) {
            
            return Created("", loginViewModelInput);
        }
    }
}