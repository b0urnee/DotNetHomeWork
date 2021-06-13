using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext OrderDb;

        public OrdersController(OrderContext context)
        {
            OrderDb = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Getorders()
        {
            return await OrderDb.orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await OrderDb.orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.ID)
            {
                return BadRequest();
            }

            OrderDb.Entry(order).State = EntityState.Modified;

            try
            {
                await OrderDb.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            OrderDb.orders.Add(order);
            await OrderDb.SaveChangesAsync();
            //引用 GetTodoItem 操作以创建 Location 标头的 URI。 C# nameof 关键字用于避免在 CreatedAtAction 调用中硬编码操作名称。
            return CreatedAtAction(nameof(GetOrder), new { id = order.ID }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await OrderDb.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            OrderDb.orders.Remove(order);
            await OrderDb.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return OrderDb.orders.Any(e => e.ID == id);
        }
    }
}
