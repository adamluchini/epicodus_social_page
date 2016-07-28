using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Match
  {
    //this is for MB
    public static List<Profile> MatchMBs(Profile p, string choice)
    {
      List<Profile> allProfiles = Profile.GetAll();

      List<Profile> resultPerfect = new List<Profile> {};
      List<Profile> resultGood = new List<Profile> {};
      foreach(var profile in allProfiles)
      {
        if(profile.id != p.id)
        {
          if(Match.MatchMB(p, profile) == "perfectly"){
            resultPerfect.Add(profile);
          }
          if(Match.MatchMB(p, profile) == "good"){
            resultGood.Add(profile);
          }
        }
      }
      if(choice == "perfect")  return resultPerfect;
      else return resultGood;
    }

    public static string MatchMB(Profile P1, Profile P2)
    {
      int counter = 0;
      if(P1.ei == P2.ei)
        counter++;
      if(P1.ns == P2.ns && P1.tf == P2.tf)
        counter++;
      if(P1.pj == P2.pj)
        counter++;
      if(counter==3) return "perfectly";
      else if(counter==2) return "good";
      else return "no match";
    }

//this is for experience
    public static List<Profile> MatchXPs(Profile p, string choice)
    {
      List<Profile> allProfiles = Profile.GetAll();

      List<Profile> resultPerfect = new List<Profile> {};
      List<Profile> resultGood = new List<Profile> {};
      foreach(var profile in allProfiles)
      {
        if(profile.id != p.id)
        {
          if(Match.MatchXP(p, profile) == "perfectly"){
            resultPerfect.Add(profile);
          }
          if(Match.MatchXP(p, profile) == "good"){
            resultGood.Add(profile);
          }
        }
      }
      if(choice == "perfect")  return resultPerfect;
      else return resultGood;
    }

    public static string MatchXP(Profile P1, Profile P2)
    {
      if( P1.experience == 1 && P2.experience == 3 ||
          P1.experience == 3 && P2.experience == 1 ||
          P1.experience == 2 && P2.experience == 2
          )
        return "perfectly";
      else if(P1.experience == 1 && P2.experience == 2 ||
              P1.experience == 2 && P2.experience == 1 ||
              P1.experience == 2 && P2.experience == 3 ||
              P1.experience == 3 && P2.experience == 2
              )
      return "good";
      else return "no match";
    }
//this is for everything else
    public static List<Profile> MatchElses(Profile p, string choice)
    {
      List<Profile> allProfiles = Profile.GetAll();

      List<Profile> resultPerfect = new List<Profile> {};
      List<Profile> resultGood = new List<Profile> {};
      foreach(var profile in allProfiles)
      {
        if(profile.id != p.id)
        {
          if(Match.MatchElse(p, profile) == "perfectly"){
            resultPerfect.Add(profile);
          }
          if(Match.MatchElse(p, profile) == "good"){
            resultGood.Add(profile);
          }
        }
      }
      if(choice == "perfect")  return resultPerfect;
      else return resultGood;
    }

    public static string MatchElse(Profile P1, Profile P2)
    {
      if( P1.enrollment == P2.enrollment)
        return "perfectly";
      else if(P1.style == P2.style)
        return "good";
      else return "no match";
    }

  }
}
