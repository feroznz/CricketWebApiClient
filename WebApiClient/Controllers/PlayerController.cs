using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiClient.Helper;

namespace WebApiClient.Controllers
{
    public class PlayerController : Controller
    {
        static readonly IPlayerRestClient RestClient = new PlayerRestClient();

        //
        // GET: /Player/
        public ActionResult Index(string searchString)
        {
            var players = RestClient.GetAll();//.Take(50);

            if (!string.IsNullOrEmpty(searchString))
            {
                players = players.Where(s => s.FirstName.Equals(searchString, StringComparison.OrdinalIgnoreCase) || s.LastName.Equals(searchString, StringComparison.OrdinalIgnoreCase));
            }

            return View(players);
        }

        public ActionResult Details(int id)
        {
            return View(RestClient.GetPlayerById(id));
        }


        public ActionResult GetAllTeam()
        {
            return View(RestClient.GetAllTeam());
        }

        public ActionResult GetPlayerByTeam()
        {
            return View(RestClient.GetPlayerByTeamId());
        }
	}
}