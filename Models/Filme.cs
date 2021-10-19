using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [Required (ErrorMessage ="O campo Título é obrigatório")]
        public string Titulo { get; set; }

        [Required (ErrorMessage ="O campo Diretor é obrigatório")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage ="O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range (1,600, ErrorMessage = "A duração deve ter no minimo 1 e no máximo 600 minutos de duração")]
        public int Duracao { get; set; }
    }
}