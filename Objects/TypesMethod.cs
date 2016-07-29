// using System.Collections.Generic;
// using System;
// using System.Data;
// using System.Data.SqlClient;
//
//
// namespace Codex
// {
//   public class Type : SavableObject<Comment>
//   {
//     private string _name;
//
//     public Comment(string name, int Id=0)
//     {
//       id = Id;
//       _name = Name;
//     }
//     public override bool Equals(System.Object otherType)
//     {
//       if (!(otherComment is Comment))
//       {
//         return false;
//       }
//       else
//       {
//         Comment newComment = (Comment) otherComment;
//         bool idEquality = (this.id == newComment.id);
//         return (idEquality);
//       }
//     }
//     public static string table
//     {
//       get
//       {
//         return "comments";
//       }
//     }
//
//     public string comment_body
//     {
//       get
//       {
//         return _commentBody;
//       }
//       set
//       {
//         _commentBody = value;
//       }
//     }
//     public int message_id
//     {
//       get
//       {
//         return _messageId;
//       }
//       set
//       {
//         _messageId = value;
//       }
//     }
//     public int profile_id
//     {
//       get
//       {
//         return _profileId;
//       }
//       set
//       {
//         _profileId = value;
//       }
//     }
//     public int total_likes
//     {
//       get
//       {
//         return _totalLikes;
//       }
//       set
//       {
//         _totalLikes = value;
//       }
//     }
//   }
// }
