using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseBook.Core.Core
{
    public class ExpenseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; } = "INR";
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public string? Merchant { get; set; }
        public string? Notes { get; set; }
        public string? ReceiptUrl { get; set; }
    }
}
