using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFBasics.Models
{
    public class Dog : Pet
    {
        [Column("Bone")]
        public string FavouriteBone { get; set; }

        public override string ToString() => $"{base.ToString()} I like {FavouriteBone} bones.";
    }
}
