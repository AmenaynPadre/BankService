using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public interface IUser
    {
        public int Id { get; set; }
        string Name { get; }
        public decimal Balance { get; set; }
        public int Rating { get; set; }
    }

    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; } = 0;
        public int Rating { get; set; }

        public User(int id, string name, decimal balance, int rating)
        {
            Id = id;
            Name = name;
            Balance = balance;
            Rating = rating;
        }

    }
}
