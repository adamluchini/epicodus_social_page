using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Match
  {
    public static List<Profile> MatchPerfect(Profile p)
    {
      List<Profile> allProfiles = Profile.GetAll();

      List<Profile> result = new List<Profile> {};
      foreach(var profile in allProfiles)
      {
        if(profile.id != p.id)
        {
          if(Match.MatchP(p, profile)){
            result.Add(profile);
          }
        }

      }
      return result;
    }

    public static bool MatchP(Profile P1, Profile P2)
    {
      int counter = 0;
      if(P1.ei == P2.ei)
        counter++;
      if(P1.ns == P2.ns && P1.tf == P2.tf)
        counter++;
      if(P1.pj == P2.pj)
        counter++;
      if(P1.enrollment == P2.enrollment)
        counter++;
      if(P1.experience == P2.experience)
        counter++;
      if(P1.home == P2.home)
        counter++;
      if(P1.portland == P2.portland)
        counter++;
      if(P1.style == P2.style)
        counter++;


      return counter==3;
    }
  }
}
