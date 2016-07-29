using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace Codex.Objects
{
  public class MessageManager
  {
    private int _profile_id;
    private List<Message_Post> _messages;
//private List<Comment[]> _comments;

      public MessageManager (int profile_id)
      {
        _profile_id = profile_id;
      }

      public List<Message_Post> GetMessages()
      {
        var messages = GetAllNonHobbyMessagesForCurrentProfile();
        // Console.WriteLine(GetAllHobbyMessages().Count);
        messages.AddRange(GetAllHobbyMessages());

        var sort = from m in messages
        orderby m.timestamp descending
        select m;

        return messages;//(List<Message_Post>)sort;
      }

      public List<Message_Post> GetAllNonHobbyMessagesForCurrentProfile()
      {
        DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM messages_posts;");
        // DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM messages_posts WHERE  type_id != 4;");
        SqlDataReader rdr = dbo.RDR;
        rdr = dbo.CMD.ExecuteReader();

        List<Message_Post> all = new List<Message_Post> {};
        while(rdr.Read())
        {
          all.Add(new Message_Post(
            rdr.GetString(1),
            rdr.GetInt32(2),
            rdr.GetDateTime(3),
            rdr.GetString(4),
            rdr.GetInt32(5),
            rdr.GetInt32(0)
          ));
        }

        dbo.Close();
        return all;
      }
      public List<List<Comment>> GetCommentsLists ()
      {
        List<List<Comment>> commentsLists = new List<List<Comment>> {};
        foreach (Message_Post message in _messages) {
          commentsLists.Add(GetComments(message.id));
          Console.WriteLine("reading message in getcommentslists");
        }
        return commentsLists;
      }

      public List<Comment> GetComments(int message_id)
      {
        DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM comments WHERE comments.message_Id = @Id;", new List<string> {"@Id"},  new List<object> {message_id});
        // DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM messages_posts WHERE  type_id != 4;");
        SqlDataReader rdr = dbo.RDR;
        rdr = dbo.CMD.ExecuteReader();
        Console.WriteLine("message id in get comment"+message_id);
        List<Comment> all = new List<Comment> {};
        while(rdr.Read())
        {
          Console.WriteLine("reading comment in get comment");
          all.Add(new Comment(
            rdr.GetString(1),
            rdr.GetInt32(2),
            rdr.GetInt32(3),
            rdr.GetInt32(4),
            rdr.GetInt32(0)
          ));
        }

        dbo.Close();
        return all;

      }

      public List<Message_Post> GetAllHobbyMessages()
      {
        DBObjects dbo = DBObjects.CreateCommand("SELECT messages_posts.* FROM profiles JOIN profile_subhobby ON (profiles.id = profile_subhobby.profile_id) JOIN messages_subhobbies ON (profile_subhobby.subhobby_id = messages_subhobbies.subhobby_id) JOIN messages_posts ON (messages_subhobbies.message_id = messages_posts.id) WHERE profiles.id =@Id;", new List<string> {"@Id"},  new List<object> {this._profile_id});

        Console.WriteLine("profile id: " + this._profile_id);

        SqlDataReader rdr = dbo.RDR;
        rdr = dbo.CMD.ExecuteReader();

        List<Message_Post> all = new List<Message_Post> {};
        while(rdr.Read())
        {
          Console.WriteLine("read record");
          all.Add(new Message_Post(
            rdr.GetString(1),
            rdr.GetInt32(2),
            rdr.GetDateTime(3),
            rdr.GetString(4),
            rdr.GetInt32(5),
            rdr.GetInt32(0)
          ));
        }

        dbo.Close();
        return all;
      }

  }
}
