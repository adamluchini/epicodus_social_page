using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Match
  {
    public static List<Profile> MatchMBs(Profile p, string choice,

    delegate string MatchMB(Profile P1, Profile P2)
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

    )
    {
      List<Profile> allProfiles = Profile.GetAll();

      List<Profile> resultPerfect = new List<Profile> {};
      List<Profile> resultGood = new List<Profile> {};
      foreach(var profile in allProfiles)
      {
        if(profile.id != p.id)
        {
          if(MatchMB(p, profile) == "perfectly"){
            resultPerfect.Add(profile);
          }
          if(MatchMB(p, profile) == "good"){
            resultGood.Add(profile);
          }
        }
      }
      if(choice == "perfect")  return resultPerfect;
      else return resultGood;
    }

    // public delegate string MatchMB(Profile P1, Profile P2)
    // {
    //   int counter = 0;
    //   if(P1.ei == P2.ei)
    //     counter++;
    //   if(P1.ns == P2.ns && P1.tf == P2.tf)
    //     counter++;
    //   if(P1.pj == P2.pj)
    //     counter++;
    //   if(counter==3) return "perfectly";
    //   else if(counter==2) return "good";
    //   else return "no match";
    // }

  }
}
