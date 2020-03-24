using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostForm(string name, bool isCool)
        {
            return Redirect("/home/index");
        }

        public IActionResult ValidationDemo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            //add person to db....
            return Redirect("/home/validationdemo");
        }
    }
}

/* Create an application to manage a list of cars. Each car has the following properties:
 * 
 * Make
 * Model
 * Year
 * Price
 * CarType (this should be an enum of type CarType with the values SUV/Sedan/Supercar
 * HasLeatherSeats (bool)
 * 
 * On the home page, there should be a table of all the cars in the database. In the 
 * column where you show whether or not the car has leather seats, use a glyphicon
 * either a check or x to make it more exciting :) Glyphicons can be found here:
 * 
 * http://getbootstrap.com/docs/3.3/components/#glyphicons
 *
 * On top of the table, have a link that takes you to a page to add a new car.
 * On that form, have textboxes for make/model/year/price. Then, have a select for
 * car type (hardcode the values). Beneath that, have a checkbox for "Has leather seats".
 * 
 * When the form page loads, the submit button should be disabled. Then, using javascript,
 * have some code that only re-enables the button, if the form is valid. A valid form
 * means that all textboxes have a value, and that the car type dropdown has an option
 * chosen.
 * 
 * Next, again via JS, when the user selects Supercar from the CarType dropdown,
 * the has leather seats checkbox should automatically become checked, as well as 
 * disabled, (since all supercars have leather seats).
 *
 * Finally, on the home page, in the header of the table - in the Year column, there should
 * be a link (styled like a button if you want) that when clicked, refreshes the page and
 * displays the cars sorted by year. This time, the button should have an arrow pointing
 * in the opposite direction. When clicked again, it should refresh the page again,
 * and resort it descending.
 * 
 * Good luck! */
