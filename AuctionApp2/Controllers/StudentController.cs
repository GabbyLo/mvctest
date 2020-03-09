using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionApp2.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult ViewStudents() { 
        
            var student = new[]{
            new Models.Student(){
                firstName = "Gabby Darwin",
                lastName = "Lopez",
                birthDate = new DateTime(1993,1,4),
                address = "Cebu City",
                gender = "Male"

            },
             new Models.Student(){
                firstName = "Johnny Darwin",
                lastName = "Doe",
                birthDate = new DateTime(1993,1,4),
                address = "Cebu City",
                gender = "Male"

            },
             new Models.Student(){
                firstName = "Mabby Darwin",
                lastName = "Lopez",
                birthDate = new DateTime(1993,1,4),
                address = "Cebu City",
                gender = "Male"

            } 
            };
            return View(student);
        }

    }
}
