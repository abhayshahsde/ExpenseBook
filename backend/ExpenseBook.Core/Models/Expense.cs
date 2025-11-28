using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseBook.Core.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int UserId { get; set; }                // FK to User
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "INR";
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public int CategoryId { get; set; }
        public string? Merchant { get; set; }
        public string? Notes { get; set; }
        public string? ReceiptUrl { get; set; }       // optional file path or URL
    }
}
