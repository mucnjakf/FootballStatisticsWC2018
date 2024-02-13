using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class TeamEvent
    {
        public int Id { get; set; }
        public string Type_of_event { get; set; }
        public string PlayerName { get; set; }
        public string Time { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} - Type of event: {Type_of_event} - Player: {PlayerName} - Time: {Time}";
        }
    }
}
