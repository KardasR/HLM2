using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLM2
{
    internal class Player
    {
        public string? Name { get; set; }       // Nullable because boxes can be blank
        public int Id { get; set; }
        public int Overall { get; set; }
    }
}
