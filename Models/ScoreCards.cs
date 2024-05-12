using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CricMaster.Models
{
    public class Scorecards
    {
        public List<Scorecard> scoreCard { get; set; }
        public Matchheader matchHeader { get; set; }
        public bool isMatchComplete { get; set; }
        public string status { get; set; }
        public List<Video> videos { get; set; }
        public int responseLastUpdated { get; set; }
    }

    public class Matchheader
    {
        public int matchId { get; set; }
        public string matchDescription { get; set; }
        public string matchFormat { get; set; }
        public string matchType { get; set; }
        public bool complete { get; set; }
        public bool domestic { get; set; }
        public long matchStartTimestamp { get; set; }
        public long matchCompleteTimestamp { get; set; }
        public bool dayNight { get; set; }
        public int year { get; set; }
        public string state { get; set; }
        public string status { get; set; }
        public Tossresults tossResults { get; set; }
        public Result result { get; set; }
        public Revisedtarget revisedTarget { get; set; }
        public List<Playersofthematch> playersOfTheMatch { get; set; }
        public List<object> playersOfTheSeries { get; set; }
        public List<Matchteaminfo> matchTeamInfo { get; set; }
        public bool isMatchNotCovered { get; set; }
        public string seriesDesc { get; set; }
        public int seriesId { get; set; }
        public string seriesName { get; set; }
        public string alertType { get; set; }
        public bool livestreamEnabled { get; set; }
    }

    public class Tossresults
    {
        public int tossWinnerId { get; set; }
        public string tossWinnerName { get; set; }
        public string decision { get; set; }
    }

    public class Result
    {
        public string resultType { get; set; }
        public string winningTeam { get; set; }
        public int winningteamId { get; set; }
        public int winningMargin { get; set; }
        public bool winByRuns { get; set; }
        public bool winByInnings { get; set; }
    }

    public class Revisedtarget
    {
        public string reason { get; set; }
    }


    public class Playersofthematch
    {
        public int id { get; set; }
        public string name { get; set; }
        public string fullName { get; set; }
        public string nickName { get; set; }
        public bool captain { get; set; }
        public bool keeper { get; set; }
        public bool substitute { get; set; }
        public string teamName { get; set; }
        public int faceImageId { get; set; }
    }

    public class Matchteaminfo
    {
        public int battingTeamId { get; set; }
        public string battingTeamShortName { get; set; }
        public int bowlingTeamId { get; set; }
        public string bowlingTeamShortName { get; set; }
    }

    public class Scorecard
    {
        public int matchId { get; set; }
        public int inningsId { get; set; }
        public long timeScore { get; set; }
        public Batteamdetails batTeamDetails { get; set; }
        public Bowlteamdetails bowlTeamDetails { get; set; }
        public Scoredetails scoreDetails { get; set; }
        public Extrasdata extrasData { get; set; }
        public Ppdata ppData { get; set; }
        public Wicketsdata wicketsData { get; set; }
        public Partnershipsdata partnershipsData { get; set; }
    }

    public class Batteamdetails
    {
        public int batTeamId { get; set; }
        public string batTeamName { get; set; }
        public string batTeamShortName { get; set; }
        public Batsmendata batsmenData { get; set; }
    }

    public class Batsmendata
    {
        public Bat_1 bat_1 { get; set; }
        public Bat_2 bat_2 { get; set; }
        public Bat_3 bat_3 { get; set; }
        public Bat_4 bat_4 { get; set; }
        public Bat_5 bat_5 { get; set; }
        public Bat_6 bat_6 { get; set; }
        public Bat_7 bat_7 { get; set; }
        public Bat_8 bat_8 { get; set; }
        public Bat_9 bat_9 { get; set; }
        public Bat_10 bat_10 { get; set; }
        public Bat_11 bat_11 { get; set; }
        public Bat_12 bat_12 { get; set; }
    }

    public class Bat_1
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_2
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_3
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_4
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_5
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_6
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_7
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_8
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_9
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_10
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_11
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bat_12
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public string batShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public int runs { get; set; }
        public int balls { get; set; }
        public int dots { get; set; }
        public int fours { get; set; }
        public int sixes { get; set; }
        public int mins { get; set; }
        public float strikeRate { get; set; }
        public string outDesc { get; set; }
        public int bowlerId { get; set; }
        public int fielderId1 { get; set; }
        public int fielderId2 { get; set; }
        public int fielderId3 { get; set; }
        public int ones { get; set; }
        public int twos { get; set; }
        public int threes { get; set; }
        public int fives { get; set; }
        public int boundaries { get; set; }
        public int sixers { get; set; }
        public string wicketCode { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowlteamdetails
    {
        public int bowlTeamId { get; set; }
        public string bowlTeamName { get; set; }
        public string bowlTeamShortName { get; set; }
        public Bowlersdata bowlersData { get; set; }
    }

    public class Bowlersdata
    {
        public Bowl_1 bowl_1 { get; set; }
        public Bowl_2 bowl_2 { get; set; }
        public Bowl_3 bowl_3 { get; set; }
        public Bowl_4 bowl_4 { get; set; }
        public Bowl_5 bowl_5 { get; set; }
        public Bowl_6 bowl_6 { get; set; }
    }

    public class Bowl_1
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowl_2
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowl_3
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowl_4
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowl_5
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Bowl_6
    {
        public int bowlerId { get; set; }
        public string bowlName { get; set; }
        public string bowlShortName { get; set; }
        public bool isCaptain { get; set; }
        public bool isKeeper { get; set; }
        public float overs { get; set; }
        public int maidens { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float economy { get; set; }
        public int no_balls { get; set; }
        public int wides { get; set; }
        public int dots { get; set; }
        public int balls { get; set; }
        public float runsPerBall { get; set; }
        public bool isOverseas { get; set; }
        public string inMatchChange { get; set; }
        public string playingXIChange { get; set; }
    }

    public class Scoredetails
    {
        public int ballNbr { get; set; }
        public bool isDeclared { get; set; }
        public bool isFollowOn { get; set; }
        public float overs { get; set; }
        public float revisedOvers { get; set; }
        public float runRate { get; set; }
        public int runs { get; set; }
        public int wickets { get; set; }
        public float runsPerBall { get; set; }
    }

    public class Extrasdata
    {
        public int noBalls { get; set; }
        public int total { get; set; }
        public int byes { get; set; }
        public int penalty { get; set; }
        public int wides { get; set; }
        public int legByes { get; set; }
    }

    public class Ppdata
    {
        public Pp_1 pp_1 { get; set; }
    }

    public class Pp_1
    {
        public int ppId { get; set; }
        public float ppOversFrom { get; set; }
        public float ppOversTo { get; set; }
        public string ppType { get; set; }
        public int runsScored { get; set; }
    }

    public class Wicketsdata
    {
        public Wkt_1 wkt_1 { get; set; }
        public Wkt_2 wkt_2 { get; set; }
        public Wkt_3 wkt_3 { get; set; }
        public Wkt_4 wkt_4 { get; set; }
        public Wkt_5 wkt_5 { get; set; }
        public Wkt_6 wkt_6 { get; set; }
    }

    public class Wkt_1
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Wkt_2
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Wkt_3
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Wkt_4
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Wkt_5
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Wkt_6
    {
        public int batId { get; set; }
        public string batName { get; set; }
        public int wktNbr { get; set; }
        public float wktOver { get; set; }
        public int wktRuns { get; set; }
        public int ballNbr { get; set; }
    }

    public class Partnershipsdata
    {
        public Pat_1 pat_1 { get; set; }
        public Pat_2 pat_2 { get; set; }
        public Pat_3 pat_3 { get; set; }
        public Pat_4 pat_4 { get; set; }
        public Pat_5 pat_5 { get; set; }
        public Pat_6 pat_6 { get; set; }
        public Pat_7 pat_7 { get; set; }
    }

    public class Pat_1
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_2
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_3
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_4
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_5
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_6
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Pat_7
    {
        public int bat1Id { get; set; }
        public string bat1Name { get; set; }
        public int bat1Runs { get; set; }
        public int bat1fours { get; set; }
        public int bat1sixes { get; set; }
        public int bat2Id { get; set; }
        public string bat2Name { get; set; }
        public int bat2Runs { get; set; }
        public int bat2fours { get; set; }
        public int bat2sixes { get; set; }
        public int totalRuns { get; set; }
        public int totalBalls { get; set; }
        public int bat1balls { get; set; }
        public int bat2balls { get; set; }
        public int bat1Ones { get; set; }
        public int bat1Twos { get; set; }
        public int bat1Threes { get; set; }
        public int bat1Fives { get; set; }
        public int bat1Boundaries { get; set; }
        public int bat1Sixers { get; set; }
        public int bat2Ones { get; set; }
        public int bat2Twos { get; set; }
        public int bat2Threes { get; set; }
        public int bat2Fives { get; set; }
        public int bat2Boundaries { get; set; }
        public int bat2Sixers { get; set; }
    }

    public class Video
    {
        public int commId { get; set; }
        public int matchId { get; set; }
        public int inningsId { get; set; }
        public string infraType { get; set; }
        public string headline { get; set; }
        public int imageId { get; set; }
        public string itemId { get; set; }
        public long timestamp { get; set; }
        public List<object> parsedContent { get; set; }
        public List<string> videoGeo { get; set; }
        public string batsmanId { get; set; }
        public string bowlerId { get; set; }
        public string videoType { get; set; }
        public bool isLive { get; set; }
        public int videoId { get; set; }
        public string mappingId { get; set; }
        public string videoUrl { get; set; }
        public string adTag { get; set; }
        public List<Category> categories { get; set; }
        public string language { get; set; }
        public int planId { get; set; }
        public List<object> tags { get; set; }
        public string premiumVideoUrl { get; set; }
        public bool isPremiumFree { get; set; }
    }

    public class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int imageID { get; set; }
    }
}