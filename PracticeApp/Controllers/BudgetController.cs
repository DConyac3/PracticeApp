using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PracticeApp.Data;
using PracticeApp.Models;
using System.Security.Claims;

namespace PracticeApp.Controllers
{
    public class BudgetController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BudgetController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Budget
        public async Task<IActionResult> Index()
        {
            return View(await _context.Budget.ToListAsync());
        }

        // GET: Budget/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budget = await _context.Budget
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budget == null)
            {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(User);
            //if (budget.User != user)
            //{
            //    return NotFound();
            //}

            return View(budget);
        }

        // GET: Budget/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Budget/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,User,NetSalary,AdditionalIncome,TotalIncome,HousingExpense,UtilitiesExpense,FoodExpense,DebtExpense,AdditionalExpense,TotalExpenses")] Budget budget)
        {
            if (ModelState.IsValid)
            {
                budget.Id = Guid.NewGuid().ToString();
                //budget.User = await _userManager.GetUserAsync(User);
                _context.Add(budget);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), new { budget.Id });
            }
            return View(budget);
        }

        // GET: Budget/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budget = await _context.Budget.FirstOrDefaultAsync(m => m.Id == id);
            if (budget == null)
            {
                return NotFound();
            }
            var user = await _userManager.GetUserAsync(User);
            //if (budget.User != user)
            //{
            //    return NotFound();
            //}
            return View(budget);
        }

        // POST: Budget/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,User,NetSalary,AdditionalIncome,TotalIncome,HousingExpense,UtilitiesExpense,FoodExpense,DebtExpense,AdditionalExpense,TotalExpenses")] Budget budget)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(budget);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BudgetExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { budget.Id });
            }
            return View(budget);
        }

        // GET: Budget/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var budget = await _context.Budget
                .FirstOrDefaultAsync(m => m.Id == id);
            if (budget == null)
            {
                return NotFound();
            }

            var user = await _userManager.GetUserAsync(User);
            //if (budget.User != user)
            //{
            //    return NotFound();
            //}

            return View(budget);
        }

        // POST: Budget/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var budget = await _context.Budget.FindAsync(id);
            _context.Budget.Remove(budget);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }

        private bool BudgetExists(string id)
        {
            return _context.Budget.Any(e => e.Id == id);
        }
    }
}
