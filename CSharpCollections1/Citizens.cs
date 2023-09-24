using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class Citizens
    {
        public class Citizen
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public DateTime BirthDate { get; set; }
            public string Address { get; set; }

            public Citizen(string firstName, string lastName, string middleName, DateTime birthDate, string address)
            {
                FirstName = firstName;
                LastName = lastName;
                MiddleName = middleName;
                BirthDate = birthDate;
                Address = address;
            }

            public override string ToString()
            {
                return $"{LastName} {FirstName} {MiddleName}, Address: {Address}, Birth Date: {BirthDate.ToShortDateString()}";
            }
        }

        public static List<Citizen> GetVotersByAddress(List<Citizen> citizens, string address)
        {
            var voters = citizens.Where(c => c.Address == address && (DateTime.Now.Year - c.BirthDate.Year) >= 18)
                                .OrderBy(c => c.LastName)
                                .ToList();

            return voters;
        }
    }
}