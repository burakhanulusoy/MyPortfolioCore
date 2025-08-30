using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proje1Denemesi.Context;

namespace Portfolio.Web.Controllers
{
    public class StatisticsController(PortfolioContext context) : Controller
    {
       
        public IActionResult Index()
        {

            ViewBag.TotalProject = context.Projects.Count();

            ViewBag.TotalSkill = context.Skills.Count();

            ViewBag.AvarageSkill = context.Skills.Any() ? context.Skills.Average(x=>x.Value).ToString("00.00") : 0.0.ToString("00.00");

            ViewBag.UnReadMessage=context.UserMessages.Count(x=>x.IsRead==false);
            ViewBag.readMessage=context.UserMessages.Count(x=>x.IsRead==true);


            ViewBag.LastMessageOwner=context.UserMessages.OrderByDescending(x=>x.UserMessageId).Select(x=>x.Name).FirstOrDefault();

            ViewBag.ReferanceAvarage = context.Testimonials.Any() ? context.Testimonials.Average(x => x.Review).ToString("0.0") : "Değerlendirme Bulunamadı";


            var minStartYear = context.Expreinces.Min(x => x.StartYear);
            ViewBag.WorkYear=DateTime.Now.Year-minStartYear;


            ViewBag.companyCount = context.Expreinces.Select(x=>x.Company).Distinct().Count();

            ViewBag.TheMostMaxReview = context.Testimonials.OrderByDescending(x => x.Review).Select(x => x.Name).FirstOrDefault();

            ViewBag.SkillCount=context.Skills.Count();

            ViewBag.ReadMessage = context.UserMessages.Count(x => x.IsRead == true);

            ViewBag.messagaCount=context.Testimonials.Select(x=>x.Name).Distinct().Count();


            int longatime = 0;
            int year = 0;
            string company = "";

            foreach(var item in context.Expreinces)
            {

                if(string.IsNullOrEmpty(item.EndYear))
                {
                    year = DateTime.Now.Year;
                }
                else
                {
                    year = int.Parse(item.EndYear) ;
                }



                if (longatime <= year-item.StartYear)
                {
                    longatime = year - item.StartYear;
                    company = item.Company;
                    
                }



            }

            ViewBag.longCompany=company;
            ViewBag.longtime=longatime;



            ViewBag.Review = context.Testimonials.OrderBy(x=>x.Review).Select(x=>x.Name).FirstOrDefault();



            ViewBag.admin = context.Users.Count();



            return View();
        }




    }
}
