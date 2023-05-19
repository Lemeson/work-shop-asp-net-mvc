using SalesWebMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, double amount, DateTime date, SalesStatus status, Seller seller)
        {
            Id = id;
            Amount = amount;
            Date = date;
            Status = status;
            Seller = seller;
        }
    }
}
