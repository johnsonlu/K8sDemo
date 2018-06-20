using System;
using Microsoft.AspNetCore.Mvc;

namespace K8sDemo.Api.Controllers
{
    [Route("api/v1/environments")]
    [ApiController]
    public class EnvironmentsController : ControllerBase
    {
        [HttpGet("version")]
        public IActionResult GetVersion()
        {
            return Ok($"k8s-demo-api v2 is running on {Environment.GetEnvironmentVariable("HOSTNAME")}");
        }
    }
}
