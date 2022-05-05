using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker
{
    
    public class SkillsController : Controller
    {
        [HttpGet]
        // GET: /<controller>/

        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn</h2>" +
                "<ol>" +
                "<li>Java</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";
            return Content(html, "text/html");
        }

        [HttpGet("/skills/form")]
        public IActionResult SkillForm()
        {
            string html = "<form method='post'>" +
                "<label for='date'>Date: </label>" +
                "<br>" +
                "<input type='date' name='date'>" +
                "<br>" +
                "<label for='C#'>Java:</label>" +
                "<br>" +
                "<select name='Java'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='JavaScript'>JavaScript:</label>" +
                "<br>" +
                "<select name='JavaScript'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<label for='Python'>Python:</label>" +
                "<br>" +
                "<select name='Python'>" +
                "<option value='beginner' selected>Beginner</option>" +
                "<option value='intermediate'>Intermediate</option>" +
                "<option value='advanced'>Advanced</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";
            return Content(html, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult SkillFormPost(string date, string Java, string JavaScript, string Python)
        {
            string html = $"<h1>Skills Tracker</h1>" +
                $"<h2>{date}</h2>" +
                "<ol>" +
                $"<li>Java Skill Level: {Java}</li>" +
                $"<li>JavaScript Skill Level: {JavaScript}</li>" +
                $"<li>Python Skill Level: {Python}</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
    }
}
