using Microsoft.EntityFrameworkCore;

namespace HotelAdoNet
{
    //DBCONTEXT
    /// <summary>
    ///  EFCore context class for Hotel Wings database schema version 5.0
    /// </summary>
    public class MeuContexto : DbContext
    {
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<FotoQuarto> FotosQuartos { get; set; }
        public DbSet<Tipologia> Tipologias { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Hotel; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

