using Microsoft.AspNetCore.Mvc;
using MadLibs20.Models;

namespace MadLibs20.Controllers
{
    public class ScaryMadLibController : Controller 
    {
        [Route("/scary")]
        public ActionResult ScaryMadLib(string recipient, string sender, string location1, string location2, string souvenir)
        {
            ScaryMadLibVariable myScaryMadLibVariable = new ScaryMadLibVariable();
            myScaryMadLibVariable.Recipient = recipient;
            myScaryMadLibVariable.Sender = sender;
            myScaryMadLibVariable.Location = location1;
            myScaryMadLibVariable.Location = location2;
            myScaryMadLibVariable.Souvenir = souvenir;
            return View(myScaryMadLibVariable);
        }
        
    }
}