using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C_Randomware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomwareController : ControllerBase
    {
        // POST: RandomwareController/Create
        [Authorize]
        [HttpPost("Add")]
        public string Create(IFormCollection collection)
        {
            return "";
        }

        // PUT: RandomwareController/Edit/5
        [HttpPut]
        public string Edit(int id, IFormCollection collection)
        {
            return "";
        }

        // POST: RandomwareController/Delete/5
        [HttpDelete]
        public string Delete(int id, IFormCollection collection)
        {
            return "";
        }
    }
}
