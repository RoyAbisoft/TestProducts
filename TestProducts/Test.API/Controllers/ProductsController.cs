using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using Test.API.Data;
using Test.Shared.Entites;

namespace Test.API.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var country = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (country is null)
            {
                return NotFound();
            }

            return Ok(country);
        }
        [HttpPost]
        public async Task<ActionResult> AddAsync(Product product)
        {

            _context.Add(product);

            try
            {
                await _context.SaveChangesAsync();
                return Ok(product);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("There is already a Product with the same name.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }

        }
        [HttpPut]
        public async Task<ActionResult> UpdateAsync(Product product)
        {
            _context.Update(product);
            try
            {
                await _context.SaveChangesAsync();
                return Ok(product);
            }
            catch (DbUpdateException dbUpdateException)
            {
                if (dbUpdateException.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("There is already a Product with the same name.");
                }
                else
                {
                    return BadRequest(dbUpdateException.InnerException.Message);
                }
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var afectedRows = await _context.Products
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (afectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
