using backend.Context;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/v1/pontos-de-interesse")]
    public class PontoDeInteresseController( PontoDeInteresseContext context ) : ControllerBase
    {
        private readonly PontoDeInteresseContext _context = context;

        // Listar todos os pontos de interesse
        [HttpGet]
        public async Task<IActionResult> ListarPontosDeInteresse()
        {
            var pontosDeInteresse = await _context.PontosDeInteresse.ToListAsync();

            return Ok(pontosDeInteresse);
        }

        // Listar um ponto de interesse específico por id
        [HttpGet("{id}")]
        public async Task<IActionResult> ListarPontoDeInteressePorId( int id )
        {
            var pontoDeInteresse = await _context.PontosDeInteresse.FirstOrDefaultAsync(p => p.Id == id);

            if ( pontoDeInteresse == null )
            {
                return NotFound();
            }

            return Ok(pontoDeInteresse);
        }

        // Adicionar um novo ponto de interesse
        [HttpPost]
        public async Task<IActionResult> AdicionarPontoDeInteresse( [FromBody] PontoDeInteresse pontoDeInteresse )
        {
            if ( pontoDeInteresse.Nome == string.Empty || pontoDeInteresse.CoordenadaX < 0 || pontoDeInteresse.CoordenadaY < 0 )
            {
                return BadRequest();
            }

            await _context.PontosDeInteresse.AddAsync(pontoDeInteresse);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // Deletar um ponto de interesse
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarPontoDeInteresse( int id )
        {
            var pontoDeInteresse = await _context.PontosDeInteresse.FirstOrDefaultAsync(p => p.Id == id);

            if ( pontoDeInteresse == null )
            {
                return NotFound();
            }

            _context.PontosDeInteresse.Remove(pontoDeInteresse);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}