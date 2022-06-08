using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Atividade
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public DateTime Data { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        public string Cidade { get; set; }

        public string Local { get; set; }
    }
}