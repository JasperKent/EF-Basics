using EFBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFBasics
{
    public static class FakeData
    {
        public static IEnumerable<Owner> GetData()
        {
            return new List<Owner>
            {
                new Owner
                {
                    Name = "Thomas",
                    Pets = new List<Pet>
                    {
                        new Dog { Name = "Fido", Age = 4, FavouriteBone = "Beef" },
                        new Dog { Name = "Rover", Age = 5, FavouriteBone = "Lamb" },
                        new Cat { Name = "Tiddles", Age = 3 }
                    }
                },
                new Owner
                {
                    Name = "Richard",
                    Pets = new List<Pet>
                    {
                        new Dog { Name = "Fang", Age = 4, FavouriteBone = "Human" },
                        new Cat { Name = "Tom", Age = 3, Lives = 5 }
                    }
                },
                new Owner
                {
                    Name = "Harriet",
                    Pets = new List<Pet>
                    {
                        new Dog { Name = "Digby", Age = 4, FavouriteBone = "Trom" },
                        new Dog { Name = "Eddie", Age = 5, FavouriteBone = "Big" },
                    }
                },
                new Owner
                {
                    Name = "Charlotte",
                    Pets = new List<Pet>
                    {
                        new Cat { Name = "Tom", Age = 9, Lives = 8 },
                        new Cat { Name = "Sylvester", Age = 2, Lives = 2 }
                    }
                }
            };
        }
    }
}
