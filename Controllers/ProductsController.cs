using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ProductsController(ShopContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}