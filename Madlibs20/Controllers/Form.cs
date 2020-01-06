using Microsoft.AspNetCore.Mvc;
using MadLibs20.Models;

namespace MadLibs20.Controllers
{
    public class FunnyMadLibController : Controller 
    {
        [Route("/form")]
        public ActionResult Form() 
        { 
        return View(); 
        }
    }
}