using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(ContextoDB context)
        {
            if (context.Atividades.Any()) return;
            
            var atividades = new List<Atividade>
            {
                new Atividade
                {
                    Titulo = "Past Activity 1",
                    Data = DateTime.Now.AddMonths(-2),
                    Descricao = "Activity 2 months ago",
                    Categoria = "drinks",
                    Cidade = "London",
                    Local = "Pub",
                },
                new Atividade
                {
                    Titulo = "Past Activity 2",
                    Data = DateTime.Now.AddMonths(-1),
                    Descricao = "Activity 1 month ago",
                    Categoria = "culture",
                    Cidade = "Paris",
                    Local = "Louvre",
                },
                new Atividade
                {
                    Titulo = "Future Activity 1",
                    Data = DateTime.Now.AddMonths(1),
                    Descricao = "Activity 1 month in future",
                    Categoria = "culture",
                    Cidade = "London",
                    Local = "Natural History Museum",
                },
                new Atividade
                {
                    Titulo = "Future Activity 2",
                    Data = DateTime.Now.AddMonths(2),
                    Descricao = "Activity 2 months in future",
                    Categoria = "music",
                    Cidade = "London",
                    Local = "O2 Arena",
                },
                new Atividade
                {
                    Titulo = "Future Activity 3",
                    Data = DateTime.Now.AddMonths(3),
                    Descricao = "Activity 3 months in future",
                    Categoria = "drinks",
                    Cidade = "London",
                    Local = "Another pub",
                },
                new Atividade
                {
                    Titulo = "Future Activity 4",
                    Data = DateTime.Now.AddMonths(4),
                    Descricao = "Activity 4 months in future",
                    Categoria = "drinks",
                    Cidade = "London",
                    Local = "Yet another pub",
                },
                new Atividade
                {
                    Titulo = "Future Activity 5",
                    Data = DateTime.Now.AddMonths(5),
                    Descricao = "Activity 5 months in future",
                    Categoria = "drinks",
                    Cidade = "London",
                    Local = "Just another pub",
                },
                new Atividade
                {
                    Titulo = "Future Activity 6",
                    Data = DateTime.Now.AddMonths(6),
                    Descricao = "Activity 6 months in future",
                    Categoria = "music",
                    Cidade = "London",
                    Local = "Roundhouse Camden",
                },
                new Atividade
                {
                    Titulo = "Future Activity 7",
                    Data = DateTime.Now.AddMonths(7),
                    Descricao = "Activity 2 months ago",
                    Categoria = "travel",
                    Cidade = "London",
                    Local = "Somewhere on the Thames",
                },
                new Atividade
                {
                    Titulo = "Future Activity 8",
                    Data = DateTime.Now.AddMonths(8),
                    Descricao = "Activity 8 months in future",
                    Categoria = "film",
                    Cidade = "London",
                    Local = "Cinema",
                }
            };

            await context.Atividades.AddRangeAsync(atividades);
            await context.SaveChangesAsync();
        }
    }
}