using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Codex.Objects
{
  public class MessageManager
  {
    private int _id;
private List<Message_Post> _messages;
//private List<Comment[]> _comments;

      public MessageManager (Profile profile)
      {

      }

      public List<Message_Post> GetMessage(int index)
      {
        return _messages;
      }

      public List<Message_Post> GetAllNonHobbyMessagesForCurrentProfile()
      {
        DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM messages_posts WHERE  type_id != 4 AND profile_id =@Id;", new List<string> {"@Id"},  new List<object> {this._id});
        SqlDataReader rdr = dbo.RDR;
        rdr = dbo.CMD.ExecuteReader();
        // SELECT * FROM messages_posts
        // WHERE type_id != 4 AND profile_id = 1

        List<Message_Post> all = new List<Message_Post> {};
        while(rdr.Read())
        {
          // all.Add(Message_Post(
          //   rdr.GetString(1),
          //   rdr.GetInt32(2),
          //   rdr.GetDateTime(3),
          //   rdr.GetString(4),
          //   rdr.GetInt32(5),
          //   rdr.GetInt32(0)
          // ));
        }

        dbo.Close();
        return all;
      }

  }
}
