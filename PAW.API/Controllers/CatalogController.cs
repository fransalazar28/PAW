using Microsoft.AspNetCore.Mvc;
using PAW.Business;
using PAW.Models;


namespace PAW.API.Controllers;   // ← file-scoped namespace (C# 10+)

[ApiController]
[Route("[controller]")]
public class CatalogController(IBusinessCatalog businessCatalog) : Controller
{
    [HttpGet(Name = "GetCatalogs")]
    public async Task<IEnumerable<Catalog>> GetAll()
    {
        return await businessCatalog.GetAllCatalogsAsync();
    }

    /* [HttpGet(Name = "GetCatalogById")]
     public async Task<Catalog> Get([FromQuery] int id)
     {
        var catalog = await businessCatalog.GetCatalogAsync(id);
         return catalog;
     }*/

    //Fix

    [HttpGet("{id:int}", Name = "GetCatalogById")]
    public async Task<ActionResult<Catalog>> GetById(int id)
    {
        var catalog = await businessCatalog.GetCatalogAsync(id);
        return catalog;
    }

		
    [HttpPost]
    public async Task<bool> Save([FromBody] Catalog catalog)
    {
        return await businessCatalog.SaveCatalogAsync(catalog);
    }

    [HttpDelete]
    public async Task<bool> Delete(Catalog catalog)
    {
        return await businessCatalog.DeleteCatalogAsync(catalog);
    }
}
