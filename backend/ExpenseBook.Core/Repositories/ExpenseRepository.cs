using ExpenseBook.Core.Interfaces;
using ExpenseBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseBook.Core.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;
        public ExpenseRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Expense> AddAsync(Expense expense)
        {
            var ent = (await _context.Expenses.Add(expense)).Entity;
            await _context.SaveChangesAsync();
            return ent;
        }
        public async Task DeleteAsync(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense != null)
            {
                _context.Expenses.Remove(expense);
                await _context.SaveChangesAsync();
            }
        }

    }
}
