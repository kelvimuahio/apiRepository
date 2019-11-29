using System;
using System.Collections.Generic;
using Models;

namespace QueryCS
{
    public class QRouteService : IQRouteService
    {
        public readonly List<Route> _list;

        public QRouteService()
        {
            _list = new List<Route>() { new Route( 1, "Maputo - Gaza"),
                                        new Route(2, "Maputo - Maxixe"),
                                        new Route(3, "Maputo - Gaza") };
        }

        public IEnumerable<Route> GetAllRoutes()
        {
            return _list;
        }
    }
}
