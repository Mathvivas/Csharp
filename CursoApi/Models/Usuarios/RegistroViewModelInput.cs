using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoApi.Models.Usuarios {

    public class RegistroViewModelInput {

        [Required(ErrorMessage = "O Usuário é obrigatório!")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="A Senha é obrigatória!")]
        public string Senha { get; set; }
    }
}