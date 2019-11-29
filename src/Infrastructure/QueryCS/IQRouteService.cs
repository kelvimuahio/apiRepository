using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueryCS
{
    public interface IQRouteService
    {
        IEnumerable<Route> GetAllRoutes();
    }
}
