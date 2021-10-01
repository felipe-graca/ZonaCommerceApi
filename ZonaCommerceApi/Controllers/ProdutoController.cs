using System.Threading.Tasks;
using ZonaCommerceApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ZonaCommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;



        public ProdutoController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProdutos()
        {
            return Ok(await _appDbContext.Produtos.ToListAsync());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetProdutos(int id)
        {
            var produto = await _appDbContext.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduto(Produto produtos)
        {
            _appDbContext.Produtos.Add(produtos);
            await _appDbContext.SaveChangesAsync();
            return Ok(new 
            {
                success = true,
                data = produtos
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(int id)
        {
            var produto = await _appDbContext.Produtos.FindAsync(id);
            if (produto == null){
                return NotFound();
            }

            _appDbContext.Produtos.Remove(produto);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }
    }
}