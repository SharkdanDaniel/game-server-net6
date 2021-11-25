using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.API.Domain.Dtos.Login
{
    public class LoginDto
    {   
        [Required(ErrorMessage = "Email é obrigatório!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        [StringLength(255)]
        public string Password { get; set; }
    }
}
