using System;
using System.Threading.Tasks;
using Byte1.WolSharp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Byte1.WolSharp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WakeController : ControllerBase
    {
        private readonly IAwakener _awakener;

        public WakeController(IAwakener awakener)
        {
            _awakener = awakener;
        }

        [HttpGet("{macAddress}")]
        public async Task<WakeOnLanResponse> Get(string macAddress)
        {
            try
            {
                await _awakener.WakeAsync(macAddress);
            }
            catch (Exception e)
            {
                return new WakeOnLanResponse(e.Message);
            }

            return new WakeOnLanResponse();
        }

        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        public async Task<WakeOnLanResponse> Post([FromForm] string macAddress)
        {
            try
            {
                await _awakener.WakeAsync(macAddress);
            }
            catch (Exception e)
            {
                return new WakeOnLanResponse(e.Message);
            }

            return new WakeOnLanResponse();
        }
    }
}
