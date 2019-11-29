using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using QueryCS;

namespace ApplicationAPI.Controller
{
    [Route("api/route")]
    [ApiController]
    public class RouteController : ControllerBase
    {
        public readonly IQRouteService iQRouteService;

        public RouteController(IQRouteService _iQRouteService)
        {
            iQRouteService = _iQRouteService ?? throw new ArgumentNullException(nameof(IQRouteService));
        }

        [HttpGet]
        public IEnumerable<Route> GetAllRoutes()
        {
            return iQRouteService.GetAllRoutes();
        }
    }
}