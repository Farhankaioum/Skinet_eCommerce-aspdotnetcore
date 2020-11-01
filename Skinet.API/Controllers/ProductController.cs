using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skinet.API.Data;

namespace Skinet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;

        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var datas = await _context.Products.ToListAsync();

            return Ok(datas);
        }

        [HttpGet("{id}")]
        public async  Task<IActionResult> GetProductById(int id)
        {
            var data = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            return Ok(data);
        }
    }
}
