﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class UpdateEnderecoDto
{
    [Required]
    public string Logradouro { get; set; }
    public int Numero { get; set; }
}
