using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ZBudget.Models.ZBudget;


namespace ZBudget.Controllers
{
    public class ZBudgetController : Controller
    {
        public Person person = new Person { IsAdmin = false, Name = "Nick", Balance = 500.00 };
        

        public ZBudgetController()
        {
            
            
        }

        /// <summary>
        /// Is the default page shown for each user.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View(person);
        }

        
        public IActionResult Board()
        {
            
            return View(GetAllJobs());
        }

        
        public IActionResult Transactions()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Transactions(Person p)
        {
            return View(p);
        }
       

        public IEnumerable<Job> GetAllJobs() => new List<Job>
        {
            new Job {Id = 1, Title = "Vacuum", Description="Vacuuming house", Pay = 5.0},
            new Job {Id = 2, Title = "Walk Dog", Description = "Walk dog around the block", Pay = 4.0},
            new Job {Id = 3, Title = "Bathroom cleaning", Description = "Clean bathrooms", Pay = 10.0}
        };


    }
}
