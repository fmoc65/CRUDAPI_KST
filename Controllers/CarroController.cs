using System.Collections.Generic;
using System.Threading.Tasks;
using CRUDAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly Contexto _contexto;

        public CarroController (Contexto contexto) {
            _contexto = contexto;
        }

         [HttpGet]
        public async Task<ActionResult<IEnumerable<Carro>>> PegarTodosAsync () {
            return await _contexto.Carros.ToListAsync ();
        }



        [HttpPost]
        public async Task<ActionResult<Carro>> SalvarPessoaAsync (Carro carro) {

            carro.DistanciaPercorrida = carro.Tempo * carro.VelocidadeMedia;
            carro.ConsumoCombustivel = carro.DistanciaPercorrida / carro.KmLitro;
            await _contexto.Carros.AddAsync (carro);
            await _contexto.SaveChangesAsync ();

            return Ok ();
        }
        
    }
}