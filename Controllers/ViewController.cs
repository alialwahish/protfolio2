using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace views{
public class viewsController :Controller{

    


    // [HttpGet]
    // [Route("redirect/{id}")]
    // public IActionResult NewIndex(int id){
    //     ViewBag.id=id;
    //     ViewBag.name="Ali";
    //     Console.WriteLine($"redirected from {id}");
    //     return View();
    // }


     [HttpGet]
    [Route("")]
    public IActionResult index(){
        
        return RedirectToAction("home");
        
    }

        [HttpGet]
        [Route("home")]
        public IActionResult home(){
             return View("index");
        }

            
        [HttpGet]
        [Route("projects")]
        public IActionResult projects()
        {
            
            return View("projects");
        }


        [HttpGet]
        [Route("contact")]
        public IActionResult contact()
        {
            return View("contact");
        }
    



}


}