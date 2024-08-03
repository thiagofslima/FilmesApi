namespace FilmesApi.Data.Dtos;

public class ReadFilmeDto
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public ICollection<ReadSessaoDto> Sessoes { get; set; }
    public string HoraDaConsulta
    {
        get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
    }
}
