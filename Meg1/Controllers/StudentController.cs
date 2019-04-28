using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Meg1.Models.StudentViewModels;


namespace Meg1.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpGet]
        public IActionResult AddArticles()
        {
            var addarticles = new AddArticleViewModel();
            return View(addarticles);
        }
        [HttpPost]
        public string AddArticles(AddArticleViewModel addarticles)
        {
            AddArticleViewModel ad = new AddArticleViewModel();
            addarticles.Name = ad.Name;
            addarticles.Faculty = ad.Faculty;
            addarticles.Title = ad.Title;
            addarticles.Description = ad.Description;
            addarticles.Document = ad.Document;
            addarticles.Image = ad.Image;


            return AddArticles (ad);
            
        }
        
    }
}