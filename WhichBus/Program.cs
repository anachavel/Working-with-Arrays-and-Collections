﻿using System;
using System.Collections.Generic;
// Prueba commit
namespace Pluralsight.ArraysCollections.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            var allRoutes = BusRouteRepository.InitializeRoutes();

            foreach (BusRoute route in allRoutes.Values)
                Console.WriteLine(route);
        }
    }
}
