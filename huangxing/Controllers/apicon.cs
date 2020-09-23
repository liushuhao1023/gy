using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using _0921Api.models;
using Microsoft.EntityFrameworkCore;

namespace _0921Api.Controllers
{
   
    [ApiController]
    public class apicon : ControllerBase
    {
       

        private readonly context _context;

        public apicon(context context)
        {
            _context = context;
        }

       

        [HttpGet("getInfo/{name}")]

        public async Task<ActionResult<Account>> GetAccount(string name)
        {
            var account = await _context.accounts.FirstOrDefaultAsync(p=>p.name == name);

            if (account == null)
            {
                return NotFound();
            }

            function.sql = "update accounts set loginTime = '" + DateTime.Now.ToString() + "' where name ='" + name + "'";
            function.execute(function.sql);






            return account;
        }


        [HttpGet("userOrders/{userId}")]
        public IEnumerable<Order> userOrders(string userId)
        {
            var order =  _context.orders.Where(p=>p.userId == userId);

            if (order == null)
            {
                return null;
            }

            return order;
        }

    }
}
