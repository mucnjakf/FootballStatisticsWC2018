using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Weather
    {
        public string Humidity { get; set; }
        public string Temp_celsius { get; set; }
        public string Temp_farenheit { get; set; }
        public string Wind_speed { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"\n\tHumidity: {Humidity}\n\tTemp celsius: {Temp_celsius}\n\tTemp farenheit: {Temp_farenheit}\n\tWind speed: {Wind_speed}\n\tDescription: {Description}";
        }
    }
}
