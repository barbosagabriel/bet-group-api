using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Data de Criação' é obrigatório.")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "O campo 'Data de Atualizacao' é obrigatório.")]
        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
