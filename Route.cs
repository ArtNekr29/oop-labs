using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1
{
    class Route
    {
        private string _start;
        private string _end;
        private double _dist;
        private double _time;

        public string Start { get { return _start; } }
        public string End { get { return _end; } }
        public double Dist
        {
            get { return _dist; }
            set
            {
                if (value > 0)
                    _dist = value;
            }
        }
        public double Time
        {
            get { return _time; }
            set
            {
                if (value > 0)
                    _time = value;
            }
        }

        public Route(string start, string end, double dist, double time)
        {
            _start = start;
            _end = end;
            _dist = dist;
            _time = time;
        }

        public double AverageSpeed()
        {
            return _dist / _time;
        }

        public void TotasTimeCalc(out double total, params double[] stopTimes)
        {
            total = 0;
            foreach (var stop in stopTimes)
            {
                total += stop;
            }
            total += _time;
        }
    }
}
