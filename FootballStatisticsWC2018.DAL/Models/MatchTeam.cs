﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class MatchTeam
    {
        public string Country { get; set; }
        public string Code { get; set; }
        public int Goals { get; set; }
        public int Penalties { get; set; }

        public override string ToString()
        {
            return $"\n\tCountry: {Country}\n\tCode: {Code}\n\tGoals: {Goals}\n\tPenalties: {Penalties}";
        }
    }
}
