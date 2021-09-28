using System.Linq;
using System.Threading.Tasks;
using JetCommerceApi.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JetCommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;



        public CartController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarts()
        {
            return Ok(await  _appDbContext.Carts.ToListAsync());
        }

        [HttpGet("{idItem}/{idProduct}")]
        public async Task<IActionResult> GetCartsByIdWithAmount(int idItem, int idProduct)
        {
            var cart = await _appDbContext.Carts.FindAsync(idItem);
            var produto = await _appDbContext.Produtos.FindAsync(idProduct);
            
            return Ok(new{
                idItem = cart.idItem,
                idProduto = produto.idProduto,
                quantidade = cart.quantidadeProduto,
                nameof = produto.nomeProduto,
                urlImg = produto.urlImg,
                valor = produto.valorProduto,
            });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduto(Cart cart)
        {
            _appDbContext.Carts.Add(cart);
            await _appDbContext.SaveChangesAsync();
            return Ok(new 
            {
                success = true,
                data = cart
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemCart(int id)
        {
            var cart = await _appDbContext.Carts.FindAsync(id);
            if (cart == null){
                return NotFound();
            }

            _appDbContext.Carts.Remove(cart);
            await _appDbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Cart cart)
        {
            if (id != cart.idItem)
            {
                return BadRequest();
            }
            _appDbContext.Entry(cart).State = EntityState.Modified;

            try
            {
                await _appDbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool cartExists(int id)
        {
            return _appDbContext.Carts.Any(e => e.idItem == id);
        }
    }
}