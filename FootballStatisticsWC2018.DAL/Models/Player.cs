using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Player
    {
        public string Name { get; set; }
        public bool Captain { get; set; }
        public int Shirt_number { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} Captain: {Captain} Shirt number: {Shirt_number} Position: {Position}";
        }
    }
}