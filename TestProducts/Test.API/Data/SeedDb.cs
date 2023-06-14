using System.Diagnostics.Metrics;
using Test.Shared.Entites;

namespace Test.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckProductAsync();
        }

        private async Task CheckProductAsync()
        {
            if (!_context.Products.Any())
            {
                _context.Products.Add(new Product { Name = "Initial Product", 
                                                    Number=0, 
                                                    Description="Product Test",
                                                    DateArrival=DateTime.Now,
                                                    Dimension=true,
                                                    Width_Product=0,
                                                    High_Product=0,
                                                    Length_Product=0
                                                  });
                //_context.Countries.Add(new Country { Name = "Estados Unidos" });
            }

            await _context.SaveChangesAsync();
        }
    }

}
