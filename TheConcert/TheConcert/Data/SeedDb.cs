using TheConcert.Data.Entities;

namespace TheConcert.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeddAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntrancesAsync();
            await CheckTicketsAsync();
        }

        private Task CheckTicketsAsync()
        {
            throw new NotImplementedException();
        }

        private async Task CheckEntrancesAsync()
        {
            _context.Entrances.Add(new Entrance { Description = "Norte" });
            _context.Entrances.Add(new Entrance { Description = "Sur" });
            _context.Entrances.Add(new Entrance { Description = "Oriental" });
            _context.Entrances.Add(new Entrance { Description = "Occidental" });
        }


    }
}
