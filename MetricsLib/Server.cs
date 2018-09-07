using System;
using Prometheus;

namespace MetricsLib
{
    public static class Server
    {
        private static MetricServer metricServer;
        private static Gauge pointsGauge;
        private static Gauge posXGauge;
        private static Gauge posYGauge;
        private static Gauge speedGauge;

        public static void Start()
        {
            metricServer = new MetricServer(port: 9091);
            metricServer.Start();
            pointsGauge = Metrics.CreateGauge("game_points", "current player points");
            posXGauge = Metrics.CreateGauge("game_posx", "current player x position");
            posYGauge = Metrics.CreateGauge("game_posy", "current player y position");
            speedGauge = Metrics.CreateGauge("game_speed", "current player speed");
        }

        public static void NewGame()
        {
            pointsGauge.Set(0);
            posXGauge.Set(0);
            posYGauge.Set(0);
            speedGauge.Set(0);
        }

        public static void SetPoints(double points)
        {
            pointsGauge.Set(points);
        }

        public static void SetPos(double xPos, double yPos)
        {
            posXGauge.Set(xPos);
            posYGauge.Set(yPos);
        }

        public static void SetSpeed(double speed)
        {
            speedGauge.Set(speed);
        }
    }
}   
