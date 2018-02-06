using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fisher.Bookstore.Controllers{

    public class AuthorsController : Controller{
    
        public IActionResult Index(){
            return View();
        }
         [Route("authors/featured")]
        public IActionResult Featured(){
            return Content("This is the books controller's feature");
        }

       

    }

}
