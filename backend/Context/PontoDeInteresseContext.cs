using backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Context
{
    public class PontoDeInteresseContext( DbContextOptions<PontoDeInteresseContext> options ) : DbContext(options)
    {
        public DbSet<PontoDeInteresse> PontosDeInteresse { get; set; }
    }
}