

using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace skynet.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private readonly StoreContext _db;
    public ProductsController(StoreContext db, ILogger<ProductsController> logger)
    {
        _db = db;
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts() {
        return Ok(await _db.Products.ToListAsync());
    }

    [HttpGet("{id}")]
    public string GetProduct(int id){
        return("Single product");
    }


}