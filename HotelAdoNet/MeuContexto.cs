using Microsoft.EntityFrameworkCore;

namespace HotelAdoNet
{
    //DBCONTEXT

    class MeuContexto : DbContext
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

