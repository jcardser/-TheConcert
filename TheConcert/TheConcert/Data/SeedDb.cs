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

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for(int i=1; i<=5000;i++)
                {
                    _context.Tickets.Add(new Ticket { Id = i + 1 });
                    await _context.SaveChangesAsync();
                }
                
            }
        }

        private async Task CheckEntrancesAsync()
        {
            if(!_context.Entrances.Any())
            {
                _context.Entrances.Add(new Entrance { Description = "Norte" });
                _context.Entrances.Add(new Entrance { Description = "Sur" });
                _context.Entrances.Add(new Entrance { Description = "Oriental" });
                _context.Entrances.Add(new Entrance { Description = "Occidental" });
                await _context.SaveChangesAsync();
            }

        }


    }
}
