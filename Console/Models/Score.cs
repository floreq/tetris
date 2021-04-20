using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Models
{
    public class Score
    {
        public Guid ScoreId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public int Result { get; set; }
        public ScoreBoard ScoreBoard { get; set; }
    }
}
