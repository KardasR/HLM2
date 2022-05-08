using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLM2
{
    internal class Lines
    {
        internal class Line
        {
            public Player? leftwing { get; set; }
            public Player? center { get; set; }
            public Player? rightwing { get; set; }
            public Player? leftdefence { get; set; }
            public Player? rightdefence { get; set; }
        }
        internal class Goalies
        {
            public Player? starter { get; set; }
            public Player? backup { get; set; }
            public Player? thirdstring { get; set; }
        }
    }
}
