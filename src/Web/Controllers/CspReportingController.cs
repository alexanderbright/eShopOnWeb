using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.eShopWeb.Web.ViewModels.Csp;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class CspReportingController : Controller
    {
        private readonly ILogger<CspReportingController> _logger;

        public CspReportingController(ILogger<CspReportingController> logger)
        {
            _logger = logger;
        }

        [HttpPost("~/cspreport")]
        public IActionResult CspReport([FromBody]CspReportRequest request)
        {
            // TODO: log request to a datastore somewhere
            _logger.LogWarning($"CSP Violation: {request.CspReport.DocumentUri}, {request.CspReport.BlockedUri}");

            return Ok();
        }
    }
}