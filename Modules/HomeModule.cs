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
        return View["index.cshtml"];
      };

      Get["/newProfile"] = _ => {
        return View["new_profile.cshtml"];
      };

      // Post["/test"] = parameters => {
      //   if(Request.Form["band-select-name"] == 0)
      //   {
      //
      //   };
      //   Patron patron = Patron.Find(patronId);
      //
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   // List<Copy> book_checkouts = Patron.GetCheckOuts();
      //   List<Copy> patron_checkouts = Copy.GetCheckedOutCopies(patron);
      //   //List<Book> history = Patron.GetHistory();
      //   Console.WriteLine("# checkouts:" + patron_checkouts.Count);
      //   model.Add("patron", patron);
      //   model.Add("checkouts", patron_checkouts);
      //   //model.Add("history", allClients);
      //   return View ["/patron.cshtml", model];
      // };
//
//       Patch["patrons/Renew"] = _ => {
//         Copy copy = Copy.Find(Request.Form["copy-id"]);
//         copy.Renew();
//
//         int patronId = Request.Form["patron-id"];
//         Patron patron = Patron.Find(patronId);
//
//         Dictionary<string, object> model = new Dictionary<string, object>();
//         // List<Copy> book_checkouts = Patron.GetCheckOuts();
//         List<Copy> patron_checkouts = Copy.GetCheckedOutCopies(patron);
//         //List<Book> history = Patron.GetHistory();
//         Console.WriteLine("# checkouts:" + patron_checkouts.Count);
//         model.Add("patron", patron);
//         model.Add("checkouts", patron_checkouts);
//         //model.Add("history", allClients);
//         return View ["/patron.cshtml", model];
//
//      };

    }
  }
}
