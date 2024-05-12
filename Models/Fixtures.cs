using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricMaster.Models
{

    public class Fixtures
    {
        public List<Matchdetail> matchDetails { get; set; }
    }

    public class Matchdetail
    {
        public Matchdetailsmap matchDetailsMap { get; set; }
    }

    public class Matchdetailsmap
    {
        public string key { get; set; }
        public List<Match> match { get; set; }
        public int seriesId { get; set; }
    }

    public class Match
    {
        public Matchinfo matchInfo { get; set; }
    }

    public class Matchinfo
    {
        public int matchId { get; set; }
        public int seriesId { get; set; }
        public string seriesName { get; set; }
        public string matchDesc { get; set; }
        public string matchFormat { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public Team1 team1 { get; set; }
        public Team2 team2 { get; set; }
        public int currBatTeamId { get; set; }
        public string seriesStartDt { get; set; }
        public string seriesEndDt { get; set; }
        public bool isTimeAnnounced { get; set; }
    }

    public class Team1
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamSName { get; set; }
        public int imageId { get; set; }
    }

    public class Team2
    {
        public int teamId { get; set; }
        public string teamName { get; set; }
        public string teamSName { get; set; }
        public int imageId { get; set; }
    }
}