using Assignment_Crud_Oprations.Data;
using Assignment_Crud_Oprations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Crud_Oprations.Controllers
{
    public class OrderController : Controller
    {
        private readonly StoreContext _context;
           public OrderController (StoreContext context)
        {
            _context = context;
        }
       [HttpGet]
        public IActionResult Add()

        {

            return View();
        }

        [HttpPost]
      
        public IActionResult Add(OrderModel os)

        {
            try
            {
                if (ModelState.IsValid)
                { _context.OrderModels.Add(os);
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Add)); }

                return View(os);
            }
            catch (Exception)
            {
                return RedirectToAction("Add");
            }
           
        }
        public async Task<IActionResult>Index()
        {
            var store = await _context.OrderModels.ToListAsync();
            return View(store);
        }
       
        public async Task<IActionResult> Delete(int?id)
        {
            if (id == null || id <= 0)
                return BadRequest();
            var orderModelInDb = await _context.OrderModels.FirstOrDefaultAsync(os => os.Id == id);
            if (orderModelInDb == null)
                return NotFound();
            _context.OrderModels.Remove(orderModelInDb);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = await _context.OrderModels.FirstOrDefaultAsync(os => os.Id == id);
            if (order == null)
            {
                
                return NotFound();
            }
            return View(order);
        }
    }
}
