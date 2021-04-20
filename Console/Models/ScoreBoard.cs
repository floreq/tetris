using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Models
{
    public class ScoreBoard
    {
        public Guid ScoreBoardId { get; set; }
        public string Title { get; set; }
        public ICollection<Score> Scores { get; set; }
    }
}
