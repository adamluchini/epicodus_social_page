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

        Profile foundProfile = Profile.Find(1);

        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("manager" , manager);
        model.Add("P", new List<Profile>{});
        model.Add("G", new List<Profile>{});
        model.Add("profileId", foundProfile);
        return View["index.cshtml", model];
      };

      Get["/{id}"]=parameters=> {
        Profile foundProfile = Profile.Find(parameters.id);
        MessageManager manager = new MessageManager(foundProfile.id);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("P", new List<Profile>{});
        model.Add("G", new List<Profile>{});
        model.Add("profileId", foundProfile);
        model.Add("manager" , manager);
        return View["index.cshtml", model];
      };
      Get["/addmessage/{id}"]= parameters => {
        Profile log = Profile.Find(parameters.id);
        Profile.currentId = log.id;
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("P", new List<Profile>{});
        model.Add("G", new List<Profile>{});
        model.Add("profileId", log);
        return View["add_message.cshtml", model];
      };

      Post["/profile/{id}/done"]= parameters => {
        Profile log = Profile.Find(parameters.id);
        Profile.currentId = log.id;
        int personId = log.id;
        DateTime today = DateTime.Now;
        MessageManager manager = new MessageManager(log.id);
        Message_Post newMessage_Post = new Message_Post(Request.Form["message-body"], personId, today, Request.Form["message-title"], Request.Form["type-id"]);
        newMessage_Post.Save();
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("P", new List<Profile>{});
        model.Add("G", new List<Profile>{});
        model.Add("profileId", log);
        model.Add("manager" , manager);
        return View["index.cshtml", model];
      };

      Get["/newProfile"] = _ => {
        return View["new_profile.cshtml"];
      };

      // Get["/message/add"] = _ => {
      //   return View["add_message.cshtml"];
      // };

      Post["/create"] = _ => {
        Profile p = new Profile(Request.Form["ei"], Request.Form["email"], Request.Form["enrollment"], Request.Form["experience"], Request.Form["github"], Request.Form["home"], Request.Form["Linkedin"], Request.Form["name"], Request.Form["ns"], Request.Form["pj"], Request.Form["portland"], Request.Form["style"], Request.Form["tf"]);
        p.Save();
        Profile.currentId = p.id;
        return View ["success.cshtml"];
     };

     Post["/match/type"] = _ => {
        Profile log = Profile.Find(Profile.currentId);
        Profile.currentId = log.id;
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
        MessageManager manager = new MessageManager(1);
        model.Add("manager" , manager);
        model.Add("P", resultP);
        model.Add("G", resultG);
        model.Add("profileId", log);
        return View["index.cshtml", model];
      };
    Get["/loginProfile/{id}"]=parameters=>{
      Profile log = Profile.Find(parameters.id);
      Profile.currentId = log.id;
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("P", new List<Profile>{});
      model.Add("G", new List<Profile>{});
      model.Add("profileId", log);
      return View["login.cshtml", model];
    };
    Post["/login"]=_=>{
      Profile log = Profile.Login(Request.Form["email"]);
      Profile.currentId = log.id;
      MessageManager manager = new MessageManager(log.id);
      Dictionary<string, object> model = new Dictionary<string, object>();
      //model.Add("name", Profile.Find(log.id).name);
      model.Add("manager" , manager);
      model.Add("P", new List<Profile>{});
      model.Add("G", new List<Profile>{});
      model.Add("profileId", log);
      return View["index.cshtml", model];
    };
   }
  }
}
