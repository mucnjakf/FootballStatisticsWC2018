using DataAccessLayer.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAO
{
    public class TeamsAPI
    {
        public static List<Team> GetTeamsAPI()
        {
            const string BASE_URL = "https://world-cup-json-2018.herokuapp.com/teams/results";

            List<Team> teams = new List<Team>();
            RestClient rClient = new RestClient(BASE_URL);
            RestRequest rRequest = new RestRequest(BASE_URL);

            rRequest.AddHeader("User-Agent", "Nothing");

            IRestResponse<List<Team>> rResponse = rClient.Execute<List<Team>>(rRequest);

            rResponse.Data.ForEach(team => teams.Add(team));

            return teams;
        }
    }
}
