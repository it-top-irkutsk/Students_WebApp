using Microsoft.AspNetCore.Mvc;

namespace Students.WebApp.Controllers;

public class AboutController : Controller
{
    // GET
    public IActionResult Index(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            return View("Index");
        }
        if (int.TryParse(id, out var Id))
        {
            return View("Index", Id.ToString());
        }

        return BadRequest("Неверный запрос");
    }
}