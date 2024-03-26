using Microsoft.AspNetCore.Mvc;
using TypeCodeIt11.Logic.Models;
using TypeCodeIt11.Logic.Processors;
using TypeCodeIt11.WepApp.Requests;

namespace TypeCodeIt11.WepApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserDataController : ControllerBase
    {
        private readonly TypeCodeDataProcessor _dataProcessor;

        public UserDataController(TypeCodeDataProcessor dataProcessor)
        {
                _dataProcessor = dataProcessor;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetUserData([FromBody]GetUserByNameRequest userName) 
        {
            TypeCodeData result = await _dataProcessor.Get(userName.Name);
            return Ok(result);  
        }
    }
}