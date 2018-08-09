using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CompetitionController : Controller
    {
        // 
        // GET: /Competition/

        public string Index()
        {
            return "This is my Competition action...";
        }

        // 
        // GET: /Competition/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome Competition action method...";
        }
    }
}