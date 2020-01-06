using Microsoft.AspNetCore.Mvc;
using MadLibs20.Models;

namespace MadLibs20.Controllers
{
    public class FunnyMadlibController : Controller 
    {
        [Route("/funnymadlib")] //rootpath
        public ActionResult FunnyMadLib( string noun, string adjective, string adverb, string verb) { 
        FunnyMadLibVariable myFunnyMadLibVariable = new FunnyMadLibVariable();
        myFunnyMadLibVariable.Noun = noun;//"Lina";
        myFunnyMadLibVariable.Adjective = adjective;//"Hawaii";
        myFunnyMadLibVariable.Adverb = adverb;
        myFunnyMadLibVariable.Verb = verb;//"magnet";
        return View(myFunnyMadLibVariable); 
        }      
    }
}