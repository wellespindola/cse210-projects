using System.Collections.Generic;

// Video.cs
public class Video
{
    public string _title = "";
    public string _author = "";
    public int _length; // em segundos
    public List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Método exigido para retornar o número total de comentários
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Método para exibir as informações do vídeo e seus comentários
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Título: {_title}");
        Console.WriteLine($"Autor: {_author}");
        Console.WriteLine($"Duração: {_length} segundos");
        Console.WriteLine($"Número de comentários: {GetCommentCount()}");
        Console.WriteLine("Comentários:");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($" - {comment._name}: \"{comment._text}\"");
        }
        Console.WriteLine(new string('-', 40)); // Linha divisória
    }
}