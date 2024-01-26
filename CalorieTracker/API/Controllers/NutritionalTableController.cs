using API.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NutritionalTableController : Controller
    {
        private INutritionalTableDao _nutritionalTableDao;

        public NutritionalTableController(INutritionalTableDao nutritionalTableDao)
        {
            _nutritionalTableDao = nutritionalTableDao;
        }


        [HttpPost]
        // GET: NutritionalTableController/Create
        public async Task<ActionResult<int>> CreateNutritionalTable([FromBody] NutritionalTable nutritionalTable)
        {
            int result = -1;

            if (nutritionalTable != null)
            {
                result = await _nutritionalTableDao.CreateNutritionalTable(nutritionalTable);
            }

            return (result > 0) ? Ok(result) : BadRequest();
        }



    }
}
