using Microsoft.AspNetCore.Mvc;
using Prototype_test.Models;
using System.Collections.Generic;


namespace Prototype_test.Controllers
{
    public class ObstacleController : Controller
    {
       

        [HttpGet]
        public ActionResult DataForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DataForm(ObstacleData obstacleData)
        {
            if(!ModelState.IsValid)
            {
                return View(obstacleData);
            }
                
            // Add the submitted obstacle to the list
            DatabaseModel._obstacles.Add(obstacleData);

            return View("Overview", obstacleData);
        }
    }
}
