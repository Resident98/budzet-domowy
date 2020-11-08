using System;
using System.Collections.Generic;

namespace budzet_domowy.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public static List<PersonModel> Examples()
        {
            var random = new Random();
            int r1;
            int r2;
            var names = new List<string> { "Kamil", "Grzegorz", "Bartłomiej", "Bartosz", "Krzysztof", "Mikolaj" };
            var surnames = new List<string> { "Kowalski", "Nowak", "Kaczynski", "Kwiatkowski", "Maciejewski", "Zimnicki" };
            var person = new List<PersonModel>();
            for (int i = 1; i <= 100; i++)
            {
                r1 = random.Next(names.Count);
                r2 = random.Next(surnames.Count);
                person.Add(new PersonModel
                {
                    Id = i,
                    Name = names[r1],
                    Surname = surnames[r2],
                    Age = random.Next(18, 100),
                    Email = $"test{i}@gmail.com"
                });
            }
            return person;
        }
    }
}