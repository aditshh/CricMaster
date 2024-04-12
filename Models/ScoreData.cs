using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricMaster.Models
{
    public class ScoreData
    {
        public List<TypeMatch> typeMatches { get; set; }

        public class TypeMatch
        {
            public string matchType { get; set; }
        }
    }
}