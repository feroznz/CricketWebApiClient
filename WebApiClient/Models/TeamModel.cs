using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiClient.Models
{
    public class TeamModel
    {
        public string TeamName { get; set; }
        public PlayerModel player { get; set; }
    }
}