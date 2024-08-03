using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateCinemaDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Nome { get; set; }
}
