class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nome)
    {
       Nome = nome;
    }
    public string Nome { get;  }
    public int DuracaoTotal => musicas.Sum(m=>m.Duracao);

    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}:\n ");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");

        }
        Console.WriteLine($"Para ouvir este album inteiro voce precisa de {DuracaoTotal}");
    }
}