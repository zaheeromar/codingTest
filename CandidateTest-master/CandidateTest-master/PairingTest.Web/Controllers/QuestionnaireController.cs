using System.Web.Mvc;
using PairingTest.Web.Models;
using System.Collections.Generic;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
          /* ASYNC ACTION METHOD... IF REQUIRED... */
//        public async Task<ViewResult> Index()
//        {
//        }

        public ViewResult Index()
        {
            QuestionnaireViewModel data =  new QuestionnaireViewModel
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>
                                           {
                                               "What is the capital of Cuba?",
                                               "What is the capital of France?",
                                               "What is the capital of Poland?",
                                               "What is the capital of Germany?"
                                           }
            };

            return View(data);
        }
    }
}
