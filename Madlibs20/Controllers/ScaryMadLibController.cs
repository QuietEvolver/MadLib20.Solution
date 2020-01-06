using Microsoft.AspNetCore.Mvc;
using MadLibs20.Models;

namespace MadLibs20.Controllers
{
    public class ScaryMadLibController : Controller 
    {
        [Route("/scary")]
        public ActionResult ScaryMadLib(string recipient, string sender, string souvenir)
        {
            ScaryMadLibVariable myScaryMadLibVariable = new ScaryMadLibVariable();
            myScaryMadLibVariable.Recipient = recipient;
            myScaryMadLibVariable.Sender = sender;
            myScaryMadLibVariable.Souvenir = souvenir;
            return View(myScaryMadLibVariable);
        }
        
    }
}