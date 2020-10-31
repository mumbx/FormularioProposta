using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioProposta.Models
{
    public class Usuario
    {
        [EmailAddress(ErrorMessage = "O campo 'E-mail' recebeu um formato inválido")]
        [Required(ErrorMessage = "O campo 'E-mail' é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório")]
        public string Senha { get; set; }
    }
}
