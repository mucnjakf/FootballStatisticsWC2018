using DataAccessLayer.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAO
{
    public class MatchesAPI
    {
        public static List<Match> GetMatchesAPI(string fifaCode)
        {
            string baseUrl = $"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code={fifaCode.ToUpper()}";

            List<Match> matches = new List<Match>();
            RestClient rClient = new RestClient(baseUrl);
            RestRequest rRequest = new RestRequest(baseUrl);

            rRequest.AddHeader("User-Agent", "Nothing");

            IRestResponse<List<Match>> rResponse = rClient.Execute<List<Match>>(rRequest);

            rResponse.Data.ForEach(match => matches.Add(match));

            return matches;
        }
    }
}
