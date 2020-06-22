using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        [HttpGet]        
        public IActionResult Index()
        {
            string html = "<form method='post' action='/welcome'>" +
               "<input type='text' name='name'/>" +
               "<label for= 'Langs'> Choose a Language:</label>" +
                   "<select name = 'value' id = 'Langs'>  " +
                     "<option value = 'English' > English </option> " +
                     "<option value = 'French' > French </option>" +    
                     "<option value = 'Georgian' > Georgian </option>"  +    
                     "<option value = 'Spanish' > Spanish </option>" +
                     "<option value = 'C#' > C# </option>" +
                   "</select>" +
                "<input type='submit' value='Greet Me!'/>" +
              "</form>";

            return Content(html, "text/html");
        }

        // GET: /<controller>/welcome
        [HttpPost("/welcome")]
        //[HttpGet("/welcome/{name?}")]
        //[HttpGet("/welcome/{name,value?}")]

        public IActionResult Welcome(string name = "World",string value = "English")
        {
            string modified = CreateMessage(value);
            
            return Content("<h1>" + modified + name + "!</h1>", "text/html");
        }

        public static string CreateMessage(string language)
        {
            if (language == "English")
            {
                return "Hello ";
            }
            else if (language == "French")
            {
                return "Bonjour ";
            }
            else if (language == "Georgian")
            {
                return "Gagamarjos ";
            }
            else if (language == "Spanish")
            {
                return "Hola ";
            }
            else return "0110100001100101011011000110110001101111 ";
        }

    }
}
