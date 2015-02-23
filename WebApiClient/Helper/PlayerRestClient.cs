using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Web;
using RestSharp;
using WebApiClient.Models;

namespace WebApiClient.Helper
{
    public class PlayerRestClient:IPlayerRestClient
    {
        private readonly RestClient _client;
        //getting base url from config
        private readonly string _url = ConfigurationManager.AppSettings["webapibaseurl"];

        public PlayerRestClient()
        {
            _client = new RestClient(_url);
        }
        public IEnumerable<PlayerModel> GetAll()
        {
            var request = new RestRequest("api/player", Method.GET) {RequestFormat = DataFormat.Json};
            var response = _client.Execute<List<PlayerModel>>(request);

            if (response.Data == null) 
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }
        public IEnumerable<TeamModel> GetAllTeam()
        {
            var request = new RestRequest("api/Team", Method.GET) { RequestFormat = DataFormat.Json };
            var response = _client.Execute<List<TeamModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public PlayerModel GetPlayerById(int id)
        {
            var request = new RestRequest("api/player/{id}", Method.GET) {RequestFormat = DataFormat.Json};
            request.AddParameter("id", id, ParameterType.UrlSegment);
            var response = _client.Execute<PlayerModel>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }


        public IEnumerable<PlayerModel> GetPlayerByTeamId()
        {
            string TeamId = "Brisbane heat";
            var request = new RestRequest("api/player/GetPlayerByTeamId/{id}", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddParameter("TeamName", TeamId, ParameterType.UrlSegment);
            var response = _client.Execute<List<PlayerModel>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

    }
}