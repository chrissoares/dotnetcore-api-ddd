using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreate
    {
        [Required(ErrorMessage = "É necessário informar o nome")]
        [StringLength(maximumLength: 50, ErrorMessage = "Tamanho Máximo {1}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "É necessário informar um email válido.")]
        [EmailAddress(ErrorMessage = "O formato do email esta inválido.")]
        [StringLength(200, ErrorMessage = "Tamanho máximo para email é {1} caracteres.")]
        public string Email { get; set; }
    }
}
