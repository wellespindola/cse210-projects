using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Criar a lista principal de vídeos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Aprenda C# em 10 Minutos", "Dev Academy", 600);
        video1._comments.Add(new Comment("Carlos", "Excelente explicação, muito claro!"));
        video1._comments.Add(new Comment("Ana", "Me ajudou muito na aula de POO."));
        video1._comments.Add(new Comment("Pedro", "Faz um vídeo sobre listas agora!"));
        videos.Add(video1);

        
        Video video2 = new Video("Como Fazer Bolo de Cenoura Perfeito", "Cozinha Rápida", 450);
        video2._comments.Add(new Comment("Maria", "Fiz a receita e ficou fofinho!"));
        video2._comments.Add(new Comment("João", "Pode substituir o óleo por manteiga?"));
        video2._comments.Add(new Comment("Fernanda", "A melhor cobertura de chocolate!"));
        videos.Add(video2);

       
        Video video3 = new Video("Dicas de Produtividade no VS Code", "Code Tips", 300);
        video3._comments.Add(new Comment("Lucas", "Não conhecia esse atalho, valeu!"));
        video3._comments.Add(new Comment("Beatriz", "Vídeo direto ao ponto, nota 10."));
        video3._comments.Add(new Comment("Gabriel", "Uso o VS Code todo dia e aprendi algo novo."));
        videos.Add(video3);

        
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}