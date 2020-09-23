using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _0921Api.models;

namespace _0921Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly context _context;

        public OrdersController(context context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> Getorders()
        {
            return await _context.orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            

            

            _context.orders.Add(order);
            await _context.SaveChangesAsync();

            if (order.id < 10)
            {
                order.orderId = "D00" + order.id;
            }
            else if (10 < order.id && order.id < 100)
            {
                order.orderId = "D0" + order.id;
            }
            else
            {
                order.orderId = "D0" + order.id;
            }

            function.sql = "update orders set orderId= '" + order.orderId + "' where id ='" + order.id + "' ";
            function.execute(function.sql);

            string orderId = order.orderId;
            string type = order.productType;
            string storePos = order.storePos;
            string num = order.num;
            string matId;
            string color;
            if(type == "C110")
            {
                matId = "1";
                color = "RDPO";

                function.sendOrder(matId,storePos,num,orderId, type, color);
            }
            else if (type == "C120")
            {
                matId = "2";
                color = "BKPO";
                function.sendOrder(matId,storePos, num, orderId, type, color);
            }

            

            return CreatedAtAction("GetOrder", new { id = order.id }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.orders.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return _context.orders.Any(e => e.id == id);
        }
    }
}
