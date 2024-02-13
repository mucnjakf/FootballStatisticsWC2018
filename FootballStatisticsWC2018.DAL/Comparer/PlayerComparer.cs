using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Comparer
{
    class PlayerComparer : IEqualityComparer<Player>
    {
        public bool Equals(Player x, Player y) => x.Name == y.Name;

        public int GetHashCode(Player obj) => obj.GetHashCode();
    }
}
