using Nancy;
using System.Collections.Generic;
using System;
using Codex.Objects;

namespace Codex
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"]=_=> {
        return View["index.cshtml", new List<Profile>{}];
      };

      Get["/newProfile"] = _ => {
        return View["new_profile.cshtml"];
      };

      Post["/create"] = _ => {
        Profile p = new Profile(Request.Form["ei"], Request.Form["email"], Request.Form["enrollment"], Request.Form["experience"], Request.Form["github"], Request.Form["home"], Request.Form["Linkedin"], Request.Form["name"], Request.Form["ns"], Request.Form["pj"], 1, Request.Form["style"], Request.Form["tf"]);
        p.Save();
        Profile.currentId = p.id;
        return View ["new_profile.cshtml"];
     };

     Get["/compareProfile"] = _ => {
       return View["compare.cshtml"];
     };




      Post["/compare/profile"] = _ => {
        Console.Write(Int32.Parse(Request.Form["compareProfile"]));
        Profile p = Profile.Find(Int32.Parse(Request.Form["compareProfile"]));
        List<Profile> result = Match.MatchMBs(p, "perfect");
        return View["index.cshtml", result];
      };






      // Post["/match/type"] = _ => {
      //   Profile compareProfile = Profile.Find(Request.Form["compareProfile"]);
      //   List<Profile> result;
      //   if(Request.Form["band-select-name"] == 0)
      //   {
      //     result = Match.MatchMBs(compareProfile, "perfect");
      //   }
      //   return View ["index.cshtml", result];
      // };
    }
  }
}
