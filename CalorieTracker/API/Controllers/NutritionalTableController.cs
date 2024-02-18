using API.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class NutritionalTableController : Controller
    {
        [HttpPost]
        // POST: NutritionalTableController/Create
        public async Task<ActionResult<int>> CreateNutritionalTable([FromBody] NutritionalTable nutritionalTable)
        {
            int result = -1;
            IDao<NutritionalTable, int> nutritionalTableDao = DaoFactory.CreateNutritionalTableDao();

            if (nutritionalTable != null)
            {
                result = await nutritionalTableDao.CreateItem(nutritionalTable);
            }

            return (result > 0) ? Ok(result) : BadRequest();
        }

        [HttpPut]
        [Route("{id}")]
        // PUT: NutritionalTableController/Update

        public async Task<ActionResult<bool>> UpdateNutritionalTable([FromBody] NutritionalTable nutritionalTable, int id)
        {
            bool result = false;
            IDao<NutritionalTable, int> nutritionalTableDao = DaoFactory.CreateNutritionalTableDao();

            if (nutritionalTable != null)
            {
                result = await nutritionalTableDao.UpdateItem(nutritionalTable, id);
            }

            return result ? Ok(result) : BadRequest();
        }

        [HttpGet]
        // GET: NutritionalTableController/Get
        public async Task<ActionResult<NutritionalTable>> GetNutritionalTable(int id)
        {
            NutritionalTable result = null;
            IDao<NutritionalTable, int> nutritionalTableDao = DaoFactory.CreateNutritionalTableDao();

            if (id > 0)
            {
                try
                {
                    result = await nutritionalTableDao.GetItemById(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return (result != null) ? Ok(result) : BadRequest();
        }

        [HttpDelete]
        // DELETE: NutritionalTableController/Delete
        public async Task<ActionResult<bool>> DeleteNutritionalTableById(int id)
        {
            bool result = false;
            IDao<NutritionalTable, int> nutritionalTableDao = DaoFactory.CreateNutritionalTableDao();

            if (id > 0)
            {
                result = await nutritionalTableDao.DeleteItem(id);
            }

            return result ? Ok(result) : BadRequest();
        }
    }
}
