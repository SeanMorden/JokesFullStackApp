using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesFullStackApp.Models
{
    public class Joke
    {
        public int JokeId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        public Joke()
        {

        }
    }
}
