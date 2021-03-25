using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFBasics.Models
{
    public class Cat : Pet
    {
        public int Lives { get; set; } = 9;

        public override string ToString() => $"{base.ToString()} I have {Lives} lives left.";
    }
}
