﻿using Microsoft.AspNetCore.Mvc;

namespace sodoff.Controllers.Common
{
    public class AnalyticsController : Controller
    {
        [HttpPost]
        [Produces("application/xml")]
        [Route("AnalyticsWebService.asmx/LogEvent")]
        public IActionResult LogEvent()
        {
            // placeholder to prevent a ton of 404's
            return Ok(true);
        }

        [Route("ping")]
        [Route("ContentWebService.asmx")] // ping URL used by SoD
        public IActionResult Ping()
        {
            return Ok();
        }
    }
}
