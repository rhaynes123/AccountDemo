using System;
namespace CustomerAccountDemo
{
    public class Transaction
    {
        public decimal TransAmount { get; }
        public DateTime TransDate { get; }
        public string TransNotes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            TransAmount = amount;
            TransDate = date;
            TransNotes = note;
        }
    }
}
