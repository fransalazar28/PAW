using APW.Architecture;
using Microsoft.AspNetCore.Mvc;
using PAW.Architecture.Providers;
using PAW.Models;
using PAW.Services;

namespace PAW.Mvc.Controllers;

public class CatalogController(ICatalogService catalogservice) : Controller
{
    public async Task<IActionResult>  Index()
    {
        var catalog = await catalogservice.GetCatalogAsync(1);
      
        return View("Index", catalog);
    }
}
