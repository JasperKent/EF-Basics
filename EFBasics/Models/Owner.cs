using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasics.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pet> Pets { get; set; }

        public override string ToString() => $"I'm {Name}.";
    }
}
