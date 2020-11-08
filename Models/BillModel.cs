using System;
using System.Collections.Generic;

namespace budzet_domowy.Models
{
    public class BillModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Receiver { get; set; }
        public string Account { get; set; }
        public string Status { get; set; }
        public static List<BillModel> Examples()
        {
            var stan = new List<string> { "Paid", "Unpaid" };
            int r1;
            var random = new Random();
            var bill = new List<BillModel>();
            var startWith = "32";
            for (int i = 1; i <= 100; i++)
            {
                r1 = random.Next(stan.Count);
                string r = random.Next(0, 999999).ToString("D6");
                var account = startWith + r;
                bill.Add(new BillModel
                {
                    Id = i,
                    Date = new DateTime(2021, random.Next(1, 12), random.Next(1, 29), random.Next(1, 24), random.Next(1, 59), random.Next(1, 59)),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    Receiver = "Company " + random.Next(1, 100),
                    Account = account,
                    Status = stan[r1]
                });
            }
            return bill;
        }
    }
}