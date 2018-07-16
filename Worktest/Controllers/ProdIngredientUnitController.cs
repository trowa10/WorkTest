using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Worktest.Business;
using Worktest.Models;

namespace Worktest.Controllers
{
    [Route("api/[controller]")]
    public class ProdIngredientUnitController : Controller
    {    

        private readonly IProductIngredientUnit _prodIngredirntRepo;

        public ProdIngredientUnitController(IProductIngredientUnit prodIngredirntRepo)
        {
            this._prodIngredirntRepo = prodIngredirntRepo;
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<ProductIngredientUnitModel>> GetProdIngredientUnits()
        {
            var data = await this._prodIngredirntRepo.GetAllProductIngredientUnit();
            return data;
        }


        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
