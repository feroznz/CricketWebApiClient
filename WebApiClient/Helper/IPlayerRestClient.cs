using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiClient.Models;

namespace WebApiClient.Helper
{
    public interface IPlayerRestClient
    {
        IEnumerable<PlayerModel> GetAll();
        IEnumerable<TeamModel> GetAllTeam();
        PlayerModel GetPlayerById(int id);

        IEnumerable<PlayerModel> GetPlayerByTeamId();
     }
}