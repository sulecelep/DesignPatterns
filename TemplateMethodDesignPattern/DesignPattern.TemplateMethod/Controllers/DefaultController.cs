using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans basicPlans = new BasicPlan();
            ViewBag.v1 = basicPlans.PlanType("Temel Plan");
            ViewBag.v2 = basicPlans.CountPerson(1);
            ViewBag.v3 = basicPlans.Price(59.99);
            ViewBag.v4 = basicPlans.Content("Film/Dizi");
            ViewBag.v5 = basicPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandartPlanIndex()
        {
            NetflixPlans standartPlan = new StandartPlan();
            ViewBag.v1 = standartPlan.PlanType("Standart Plan");
            ViewBag.v2 = standartPlan.CountPerson(3);
            ViewBag.v3 = standartPlan.Price(99.99);
            ViewBag.v4 = standartPlan.Content("Film/Dizi/Animasyon");
            ViewBag.v5 = standartPlan.Resolution("720px");
            return View();
        }
        public IActionResult PremiumPlanIndex()
        {
            NetflixPlans premiumPlan = new PremiumPlan();
            ViewBag.v1 = premiumPlan.PlanType("Premium Plan");
            ViewBag.v2 = premiumPlan.CountPerson(6);
            ViewBag.v3 = premiumPlan.Price(149.99);
            ViewBag.v4 = premiumPlan.Content("Film/Dizi/Animasyon/Belgesel");
            ViewBag.v5 = premiumPlan.Resolution("1080px");
            return View();
        }
    }
}
