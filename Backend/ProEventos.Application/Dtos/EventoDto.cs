using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório."),
            StringLength(50, MinimumLength = 3, ErrorMessage = "O {0} precisa ter entre 3 a 50 caracteres.")]
        public string Local { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório."),
            StringLength(50, MinimumLength = 3, ErrorMessage = "O {0} precisa ter entre 3 a 50 caracteres.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]

        [Range(10, 100, ErrorMessage = "A quantidade de pessoas deve ser no mínimo 10 pessoas")]
        public int QtdPessoa { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$", ErrorMessage ="Imagem inválida")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo {0} precisa ser valido.")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; }

    }
}
