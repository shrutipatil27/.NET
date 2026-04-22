using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    /// <summary>
    /// API controller for managing products (CRUD operations).
    /// Uses an in-memory list as the data store.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // In-memory data store shared across requests (static)
        private static readonly List<Product> _products = new()
        {
            new Product { Id = 1, Name = "Laptop",      Price = 999.99m,  Quantity = 50 },
            new Product { Id = 2, Name = "Smartphone",   Price = 699.49m,  Quantity = 120 },
            new Product { Id = 3, Name = "Headphones",   Price = 149.99m,  Quantity = 200 },
            new Product { Id = 4, Name = "Keyboard",     Price = 79.99m,   Quantity = 300 },
            new Product { Id = 5, Name = "Mouse",        Price = 49.99m,   Quantity = 500 }
        };

        private static int _nextId = 6;

        // ───────────────────────── GET ALL ─────────────────────────
        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>List of all products</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            return Ok(_products);
        }

        // ───────────────────── GET BY ID ───────────────────────
        /// <summary>
        /// Retrieves a single product by its ID.
        /// </summary>
        /// <param name="id">Product ID</param>
        /// <returns>The matching product or 404</returns>
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            return Ok(product);
        }

        // ──────────────────────── POST ─────────────────────────
        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="product">Product data</param>
        /// <returns>The created product with a 201 status</returns>
        [HttpPost]
        public ActionResult<Product> CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            product.Id = _nextId++;
            _products.Add(product);

            // Returns 201 Created with a Location header pointing to the new resource
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // ──────────────────────── PUT ──────────────────────────
        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="id">ID of the product to update</param>
        /// <param name="updatedProduct">Updated product data</param>
        /// <returns>The updated product or 404</returns>
        [HttpPut("{id}")]
        public ActionResult<Product> UpdateProduct(int id, [FromBody] Product updatedProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingProduct = _products.FirstOrDefault(p => p.Id == id);

            if (existingProduct == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            // Update fields
            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Quantity = updatedProduct.Quantity;

            return Ok(existingProduct);
        }

        // ─────────────────────── DELETE ────────────────────────
        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="id">ID of the product to delete</param>
        /// <returns>204 No Content or 404</returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(new { message = $"Product with ID {id} not found." });
            }

            _products.Remove(product);

            return NoContent(); // 204
        }
    }
}
