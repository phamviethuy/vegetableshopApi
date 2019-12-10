using Microsoft.AspNetCore.Mvc;
using System.Linq;
using vegetableshop.DataAccess.Entities;
using vegetableshop.ViewModel;

namespace vegetableshop.Controllers
{
    [ApiController]
    public class VegetableController : ControllerBase
    {
        private readonly vegetableshopContext _context;

        public VegetableController(vegetableshopContext context)
        {
            this._context = context;
        }

        [HttpGet]
        [Route("api/vegetable/get")]
        public JsonResult GetAllVegetable()
        {
            string baseUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/";
            var listVegetable = _context.Vegetables.Select(v => new ListVegetableViewModel
            {
                Id = v.Id,
                Avatar = $"{baseUrl}{v.Vegetableimages.FirstOrDefault().Path.Trim().Replace("wwwroot","")}",
                Nickname = v.Nickname,
                Phonenumber = v.Phonenumber,
                Wokingareas = v.Wokingareas
            });
            JsonResult result = new JsonResult(listVegetable);
            return result;
        }
    }
}