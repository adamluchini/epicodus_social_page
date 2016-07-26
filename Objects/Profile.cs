// using System.Collections.Generic;
// using System.Data.SqlClient;
// using System;
//
// namespace Codex.Objects
// {
//   public class Profile
//   {
//     private int _id;
//     private int _experience;
//     private int _style;
//     private int _portland;
//     private string _home;
//     private string _github;
//     private string _linkedin;
//     private string _email;
//     private int _enrollment;
//     private MyersBriggs _myersbriggs;
//
//
//     public Profile(int experience, int style, string home, int portland, string github, string linkedin, string email, int enrollment, MyersBriggs myersbriggs, int Id = 0)
//     {
//       _id = Id;
//       _experience = Experience;
//       _style = Style;
//       _portland = Portland;
//       _home = Home;
//       _github = Github;
//       _linkedin = Linkedin;
//       _email = Email;
//       _enrollment = Enrollment;
//       _myersbriggs = Myersbriggs;
//     }
//     public static string table
//     {
//       get
//       {
//         return "profile";
//       }
//     }
//
//     public int experience
//     {
//       get
//       {
//         return _experience
//       }
//       set
//       {
//         _experience = value;
//       }
//     }
//
//     public int portland
//     {
//       get
//       {
//         return _portland
//       }
//       set
//       {
//         _portland = value;
//       }
//     }
//     public int style
//     {
//       get
//       {
//         return _style
//       }
//       set
//       {
//         _style = value;
//       }
//     }
//     public string home
//     {
//       get
//       {
//         return _home;
//       }
//       set
//       {
//         _home = value;
//       }
//     }
//     public string github
//     {
//       get
//       {
//         return _github;
//       }
//       set
//       {
//         _github = value;
//       }
//     }
//     public string linkedin
//     {
//       get
//       {
//         return _linkedin;
//       }
//       set
//       {
//         _linkedin = value;
//       }
//     }
//     public string email
//     {
//       get
//       {
//         return _email;
//       }
//       set
//       {
//         _email = value;
//       }
//     }
//     public int enrollment
//     {
//       get
//       {
//         return _enrollment;
//       }
//       set
//       {
//         _enrollment = value;
//       }
//     }
//
//   }
// }
