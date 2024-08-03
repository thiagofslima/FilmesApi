namespace FilmesApi.Data.Dtos;

public class ReadEnderecoDto
{
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string HoraDaConsulta
    {
        get { return DateTime.Now.ToString("s"); }
    }
}
