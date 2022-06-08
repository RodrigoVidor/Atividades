using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class AtividadesController : BaseApiController
    {
        private readonly ContextoDB _contexto;

        public AtividadesController(ContextoDB contexto)
        {
            this._contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Atividade>>> GetAtividades()
        {
            return await _contexto.Atividades.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Atividade>> GetAtividade(Guid Id)
        {
            return await _contexto.Atividades.FindAsync(Id);
        }
    }
}