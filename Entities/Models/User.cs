using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("user")]
    public class User : BaseEntity
    {

        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(45)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo 'Email' é obrigatório.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido.")]
        [StringLength(45)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(45)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(45)]
        public string Password { get; set; }
    }
}
