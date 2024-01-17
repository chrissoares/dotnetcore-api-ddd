using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email é obrigatório para o login")]
        [EmailAddress(ErrorMessage = "Formato inválido para email.")]
        [StringLength(255, ErrorMessage = "Tamanho do endereço de Email não pode ser superior a {1} caracteres.")]
        public string Email { get; set; }
    }
}
