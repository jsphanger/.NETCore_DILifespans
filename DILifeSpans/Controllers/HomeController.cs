using Microsoft.AspNetCore.Mvc;
using DILifeSpans.MVC.ViewModels;
using DILifeSpans.Core.Models;

namespace DILifeSpans.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService transitentOne, transientTwo;
        private readonly IScopedService scopedOne, scopedTwo;
        private readonly ISingletonService singletonOne, singletonTwo;
        
        public HomeController(ITransientService transientServiceOne, ITransientService transientServiceTwo, 
                              IScopedService scopedServiceOne, IScopedService scopedServiceTwo, 
                              ISingletonService singletonServiceOne, ISingletonService singletonServiceTwo)
        {
            transitentOne = transientServiceOne;
            transientTwo = transientServiceTwo;

            scopedOne = scopedServiceOne;
            scopedTwo = scopedServiceTwo;

            singletonOne = singletonServiceOne;
            singletonTwo = singletonServiceTwo;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel() { TransientOne = transitentOne.GetID(), TransientTwo = transientTwo.GetID(),
                                              ScopedOne = scopedOne.GetID(), ScopedTwo = scopedTwo.GetID(),
                                              SingletonOne = singletonOne.GetID(), SingletonTwo = singletonTwo.GetID() };

            return View(model);
        }
    }
}
