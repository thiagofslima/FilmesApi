﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório!")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório!")]
    [StringLength(50, ErrorMessage = "O tamanho do campo {0} não pode exceder {1} caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório!")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre {1} e {2} minutos")]
    public int Duracao { get; set; }
}
