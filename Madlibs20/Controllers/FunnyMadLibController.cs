using Microsoft.AspNetCore.Mvc;
using MadLibs20.Models;

namespace MadLibs20.Controllers
{
    public class FunnyMadlibController : Controller 
    {
        // [Route("/funny/")]
        // public ActionResult FunnyMadLib(){
        //     return View();
        // }

        [Route("/funny/new")] //rootpath
        public ActionResult New( string noun, string adjective, string adverb, string verb) { 
        FunnyMadLibVariable myFunnyMadLibVariable = new FunnyMadLibVariable();
        myFunnyMadLibVariable.Noun = noun;//"Lina";
        myFunnyMadLibVariable.Adjective = adjective;//"Hawaii";
        myFunnyMadLibVariable.Adverb = adverb;
        myFunnyMadLibVariable.Verb = verb;//"magnet";
        return View(myFunnyMadLibVariable); 
        }      
    }
}