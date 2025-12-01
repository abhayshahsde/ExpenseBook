using ExpenseBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseBook.Core.Interfaces
{
    public interface IExpenseRepository
    {
        Task<Expense?> GetByIdAsync(int id);
        Task<IEnumerable<Expense>> GetAllAsync();
        Task<IEnumerable<Expense>> GetByUserAsync(int userId);
        Task<Expense> AddAsync(Expense expense);
        Task UpdateAsync(Expense expense);
        Task DeleteAsync(int id);
    }
}
