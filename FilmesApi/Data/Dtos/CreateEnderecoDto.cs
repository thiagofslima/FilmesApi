using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateEnderecoDto
{
    [Required]
    public string Logradouro { get; set; }
    public int Numero { get; set; }
}
