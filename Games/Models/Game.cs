using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.Models
{
    public class Game
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Developer { get; set; }

    }
}
