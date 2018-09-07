using System;
using Prometheus;

namespace MetricsLib
{
    public class Class1
    {
        static private MetricServer metricServer;

        static Class1()
        {
            metricServer = new MetricServer(port: 1234);
            metricServer.Start();
        }
    }
}
