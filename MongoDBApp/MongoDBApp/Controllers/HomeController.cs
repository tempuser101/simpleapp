using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoDBApp.Models;

namespace MongoDBApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "All the users in the mongoDB";

            MongoServer server = new MongoClient(WebConfigurationManager.ConnectionStrings["MongoDBConnectionString"].ConnectionString).GetServer();
            MongoDatabase database = server.GetDatabase(MongoUrl.Create(WebConfigurationManager.ConnectionStrings["MongoDBConnectionString"].ConnectionString).DatabaseName);

            MongoCollection itemCollection = database.GetCollection<User>(typeof(Models.User).Name);

           List<User> users=  itemCollection.FindAllAs<User>().ToList();

           ViewBag.Users = users;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}
