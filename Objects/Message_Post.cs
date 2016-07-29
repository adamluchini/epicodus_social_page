using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Codex.Objects
{
  public class Message_Post : SavableObject<Message_Post>
  {
    private string _body;
    private int _profile_id;
    private DateTime? _timestamp;
    private string _title;
    private int _type_id;

    public Message_Post(string Body, int ProfileId, DateTime? Timestamp, string Title,  int TypeId, int Id=0)
    {
      id = Id;
      _body = Body;
      _profile_id = ProfileId;
      _timestamp = Timestamp;
      _title = Title;
      _type_id = TypeId;
    }
    public override bool Equals(System.Object otherMessage_Post)
    {
      if (!(otherMessage_Post is Message_Post))
      {
        return false;
      }
      else
      {
        Message_Post newMessage_Post = (Message_Post) otherMessage_Post;
        bool idEquality = (this.id == newMessage_Post.id);
        return (idEquality);
      }
    }

    public string GetName()
    {
      return Profile.Find(_profile_id).name;
    }
    public static string table
    {
      get
      {
        return "messages_posts";
      }
    }

    public string title
    {
      get
      {
        return _title;
      }
      set
      {
        _title = value;
      }
    }
    public string body
    {
      get
      {
        return _body;
      }
      set
      {
        _body = value;
      }
    }
    public int profile_id
    {
      get
      {
        return _profile_id;
      }
      set
      {
        _profile_id = value;
      }
    }
    public DateTime? timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        _timestamp = value;
      }
    }
    public int type_id
    {
      get
      {
        return _type_id;
      }
      set
      {
        _type_id = value;
      }
    }
    //
    //
    // public List<Copy> GetCopies()
    // {
    //   DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM copies WHERE book_id=@Id;", new List<string> {"@Id"}, new List<object> {id});
    //   SqlDataReader rdr = dbo.RDR;
    //   rdr = dbo.CMD.ExecuteReader();
    //
    //   List<Copy> allCopies = new List<Copy> {};
    //   while(rdr.Read())
    //   {
    //     allCopies.Add(new Copy(rdr.GetInt32(1), rdr.GetDateTime(2), rdr.GetInt32(3), rdr.GetInt32(0) ));
    //   }
    //   dbo.Close();
    //   return allCopies;
    // }
    // public void AddAuthor(int AuthorId)
    // {
    //   DBObjects dbo = DBObjects.CreateCommand("INSERT INTO authors_books (author_id, book_id) VALUES (@AuthorId, @Id);", new List<string> {"@AuthorId", "@Id"}, new List<object> {AuthorId, id});
    //   dbo.CMD.ExecuteNonQuery();
    //   dbo.Close();
    // }
    // public void RemoveAuthors()
    // {
    //   DBObjects dbo = DBObjects.CreateCommand("DELETE FROM authors_books WHERE book_id=@ID;", new List<string> {"@Id"}, new List<object> {id});
    //   dbo.CMD.ExecuteNonQuery();
    //   dbo.Close();
    // }
    // public List<Author> GetAuthors()
    // {
    //   DBObjects dbo = DBObjects.CreateCommand("SELECT authors.* FROM books JOIN authors_books ON (books.id=authors_books.book_id) JOIN authors ON (authors_books.author_id=authors.id) WHERE books.id=@Id;", new List<string> {"@Id"}, new List<object> {id});
    //   SqlDataReader rdr = dbo.RDR;
    //   rdr = dbo.CMD.ExecuteReader();
    //
    //   List<Author> authors = new List<Author> {};
    //   while(rdr.Read())
    //   {
    //     authors.Add(new Author(rdr.GetString(1), rdr.GetInt32(0) ));
    //   }
    //   dbo.Close();
    //   return authors;
    // }
    // public static List<Message> Search(string search, string searchdef)
    // {
    //   DBObjects dbo = null;
    //   if(searchdef=="title")
    //   {
    //     dbo = DBObjects.CreateCommand("SELECT * FROM books WHERE title=@SearchResult;", new List<string> {"@SearchResult"}, new List<object> {search});
    //   }
    //   else if(searchdef=="author")
    //   {
    //     dbo = DBObjects.CreateCommand("SELECT books.* FROM authors JOIN authors_books ON (authors.id=authors_books.author_id) JOIN books ON (authors_books.book_id=books.id) WHERE authors.name=@SearchResult;", new List<string> {"@SearchResult"}, new List<object> {search});
    //   }
    //   SqlDataReader rdr = dbo.RDR;
    //   rdr = dbo.CMD.ExecuteReader();
    //   List<Message> searchResult = new List<Message> {};
    //
    //   while(rdr.Read())
    //   {
    //     searchResult.Add(new Message(rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetInt32(0)));
    //   }
    //   dbo.Close();
    //   return searchResult;
    // }


  }
}
