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
        MessageManager manager = new MessageManager(1);
        Dictionary<string, object> model = new Dictionary<string, object>();
        // foreach(var a in manager.GetMessages()){
        //   Console.Write(a);
        // }
        // Console.Write(manager.GetMessages());
        model.Add("manager" , manager);

        model.Add("P", new List<Profile>{});
        model.Add("G", new List<Profile>{});
        return View["index.cshtml", model];
      };

      Get["/newProfile"] = _ => {
        return View["new_profile.cshtml"];
      };

      Get["/message/add"] = _ => {
        return View["add_message.cshtml"];
      };

      Post["/create"] = _ => {
        Profile p = new Profile(Request.Form["ei"], Request.Form["email"], Request.Form["enrollment"], Request.Form["experience"], Request.Form["github"], Request.Form["home"], Request.Form["Linkedin"], Request.Form["name"], Request.Form["ns"], Request.Form["pj"], Request.Form["portland"], Request.Form["style"], Request.Form["tf"]);
        p.Save();
        Profile.currentId = p.id;
        return View ["success.cshtml"];
     };

     Post["/match/type"] = _ => {
       Dictionary<string, object> model = new Dictionary<string, object>();
        Profile p = Profile.Find(Profile.currentId);
        List<Profile> resultP;
        List<Profile> resultG;
        if(Int32.Parse(Request.Form["band-select-name"]) == 0)
        {
          resultP = Match.MatchMBs(p, "perfect");
          resultG = Match.MatchMBs(p, "good");
        }
        else if(Int32.Parse(Request.Form["band-select-name"]) == 2)
        {
          resultP = Match.MatchXPs(p, "perfect");
          resultG = Match.MatchXPs(p, "good");
        }
        else
        {
          resultP = Match.MatchElses(p, "perfect");
          resultG = Match.MatchElses(p, "good");
        }
        model.Add("P", resultP);
        model.Add("G", resultG);
        return View["index.cshtml", model];
      };

    Get["/loginProfile"]=_=>{
        return View["login.cshtml"];
    };
    Post["/login"]=_=>{
      Profile log = Profile.Login(Request.Form["email"]);
      Profile.currentId = log.id;
      MessageManager manager = new MessageManager(log.id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("manager" , manager);
      model.Add("P", new List<Profile>{});
      model.Add("G", new List<Profile>{});
      return View["index.cshtml", model];
    };
   }
  }
}
