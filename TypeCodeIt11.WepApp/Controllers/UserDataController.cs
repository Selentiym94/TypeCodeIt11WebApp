using Microsoft.AspNetCore.Mvc;
using TypeCodeIt11.Logic.Models;
using TypeCodeIt11.Logic.Processors;

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

        [HttpGet("get")]
        public async Task<IActionResult> GetUserData(string userName) 
        {
            TypeCodeData result = await _dataProcessor.Get(userName);
            return Ok(result);  
        }
    }
}