using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFBasics.Models
{
    public abstract class Pet
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Name} ({Age}) says ";
    }
}
