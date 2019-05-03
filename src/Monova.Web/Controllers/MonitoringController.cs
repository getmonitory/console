using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Monova.Entity;

namespace Monova.Web.Controllers
{
    public class MonitoringController : ApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await DB.Monitors.ToListAsync();
            return Success(null,list);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]MVDMonitor model)
        {
            if (string.IsNullOrEmpty(model.Name))
            {
                return Error("Name is required.");
            }

            var dataObj = new MVDMonitor
            {
                CreatedDate = DateTime.UtcNow,
                Name = model.Name
            };

            DB.Monitors.Add(dataObj);
            var result = await DB.SaveChangesAsync();
            if (result > 0)
            {
                return Success("Monitoring saved successfully.", new {
                    Id = dataObj.MonitorId
                });
            }
            else{
                return Error("Something is wrong with your model.");
            }
        }
    }

    public class MonitoringModel
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}