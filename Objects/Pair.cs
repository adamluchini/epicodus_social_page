using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Pair
  {
    private int _id;
    private int _experience;
    private int _style;
    private string _mb1;
    private string _mb2;
    private string _mb3;

    public Pair(int experience, int style, string mb1, string mb2, string mb3, int Id = 0)
    {
      _id = Id;
      _experience = experience;
      _style = style;
      _mb1 = mb1;
      _mb2 = mb2;
      _mb3 = mb3;
    }

    public int GetId()
    {
      return _id;
    }
    public int GetExperience()
    {
      return _experience;
    }
    public void SetExperience(int experience)
    {
      _experience = experience;
    }
    public int GetStyle()
    {
      return _style;
    }
    public void SetStyle(int style)
    {
      _style = style;
    }
    public string GetMd1()
    {
      return _md1;
    }
    public void SetMd1(string md1)
    {
      _md1 = md1;
    }
    public string GetMd2()
    {
      return _md1;
    }
    public void SetMd2(string md2)
    {
      _md1 = md1;
    }
    public string GetMd3()
    {
      return _md1;
    }
    public void SetMd3(string md3)
    {
      _md1 = md1;
    }

    public void Save()
    {
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr;
      conn.Open();

      SqlCommand cmd = new SqlCommand("INSERT INTO pairs (experience, style, mb1, mb2, mb3) OUTPUT INSERTED.id VALUES (@experience, @style, @mb1, @mb2, @mb3,);", conn);

      SqlParameter experienceParameter = new SqlParameter();
      experienceParameter.ParameterName = "@experience";
      experienceParameter.Value = this.GetBookId();

      cmd.Parameters.Add(experience);

      SqlParameter styleParameter = new SqlParameter();
      styleParameter.ParameterName = "@style";
      styleParameter.Value = this.GetDueDate();

      cmd.Parameters.Add(styleParameter);

      SqlParameter md1Parameter = new SqlParameter();
      md1Parameter.ParameterName = "@md1";
      md1Parameter.Value = this.GetDueDate();

      cmd.Parameters.Add(md1Parameter);

      SqlParameter md2Parameter = new SqlParameter();
      md2Parameter.ParameterName = "@md2";
      md2Parameter.Value = this.GetDueDate();

      cmd.Parameters.Add(md2Parameter);

      SqlParameter md3Parameter = new SqlParameter();
      md3Parameter.ParameterName = "@md3";
      md3Parameter.Value = this.GetDueDate();

      cmd.Parameters.Add(md3Parameter);

      rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        this._id = rdr.GetInt32(0);
      }
      if (rdr != null)
      {
        rdr.Close();
      }
      if (conn != null)
      {
        conn.Close();
      }
    }

    // public static List<Copy> GetAll()
    // {
    //   SqlConnection conn = DB.Connection();
    //   SqlDataReader rdr = null;
    //   conn.Open();
    //
    //   SqlCommand cmd = new SqlCommand("SELECT * FROM copies;", conn);
    //   rdr = cmd.ExecuteReader();
    //
    //   List<Copy> allCopys = new List<Copy> {};
    //   while(rdr.Read())
    //   {
    //     int bookId = rdr.GetInt32(0);
    //
    //     DateTime? dueDate = rdr.GetDateTime(1);
    //     int copyId = rdr.GetInt32(2);
    //     Copy newCopy = new Copy(bookId, dueDate, copyId);
    //     allCopys.Add(newCopy);
    //   }
    //
    //   if (rdr != null)
    //   {
    //     rdr.Close();
    //   }
    //   if (conn != null)
    //   {
    //     conn.Close();
    //   }
    //
    //   return allCopys;
    // }



    // public static Copy Find(int id)
    // {
    //   SqlConnection conn = DB.Connection();
    //   SqlDataReader rdr = null;
    //   conn.Open();
    //
    //   SqlCommand cmd = new SqlCommand("SELECT * FROM copies WHERE id = @CopyId;", conn);
    //   SqlParameter courseIdParameter = new SqlParameter();
    //   courseIdParameter.ParameterName = "@CopyId";
    //   courseIdParameter.Value = id.ToString();
    //   cmd.Parameters.Add(courseIdParameter);
    //   rdr = cmd.ExecuteReader();
    //
    //
    //   int bookId = 0;
    //   int copyId = 0;
    //   DateTime? foundDueDate = null;
    //
    //   while(rdr.Read())
    //   {
    //     bookId = rdr.GetInt32(0);
    //     foundDueDate = rdr.GetDateTime(1);
    //     copyId = rdr.GetInt32(2);
    //   }
    //   Copy foundCopy = new Copy(bookId, foundDueDate, copyId);
    //
    //   if (rdr != null)
    //   {
    //     rdr.Close();
    //   }
    //   if (conn != null)
    //   {
    //     conn.Close();
    //   }
    //   return foundCopy;
    // }
    // public string GetTitle()
    // {
    //   SqlConnection conn = DB.Connection();
    //   SqlDataReader rdr = null;
    //   conn.Open();
    //
    //
    //   SqlCommand cmd = new SqlCommand("SELECT books.title FROM copies JOIN books ON (copies.book_id = books.id) WHERE copies.id = @CopyId;", conn);
    //   SqlParameter courseIdParameter = new SqlParameter();
    //   courseIdParameter.ParameterName = "@CopyId";
    //   courseIdParameter.Value = GetId();
    //   cmd.Parameters.Add(courseIdParameter);
    //   rdr = cmd.ExecuteReader();
    //
    //   string bookTitle = "";
    //
    //   while(rdr.Read())
    //   {
    //     bookTitle = rdr.GetString(0);
    //   }
    //
    //   if (rdr != null)
    //   {
    //     rdr.Close();
    //   }
    //   if (conn != null)
    //   {
    //     conn.Close();
    //   }
    //   return bookTitle;
    // }
    // public static List<Copy> GetCheckedOutCopies(Patron patron)
    // {
    //   // SELECT copies.* FROM patrons JOIN checkouts ON (patrons.id = checkouts.patron_id) 	JOIN copies ON (checkouts.copy_id = copies.id) WHERE patrons.id = @CopyId
    //   SqlConnection conn = DB.Connection();
    //   SqlDataReader rdr = null;
    //   conn.Open();
    //
    //   SqlCommand cmd = new SqlCommand("SELECT copies.* FROM patrons JOIN checkouts ON (patrons.id = checkouts.patron_id) 	JOIN copies ON (checkouts.copy_id = copies.id) WHERE patrons.id = @PatronId;", conn);
    //   SqlParameter courseIdParameter = new SqlParameter();
    //   courseIdParameter.ParameterName = "@PatronId";
    //   courseIdParameter.Value = patron.GetId();
    //
    //   cmd.Parameters.Add(courseIdParameter);
    //
    //   rdr = cmd.ExecuteReader();
    //
    //   List<Copy> allCopys = new List<Copy> {};
    //   while(rdr.Read())
    //   {
    //     int bookId = rdr.GetInt32(0);
    //     Console.WriteLine("Inside loop");
    //     DateTime? dueDate = rdr.GetDateTime(1);
    //     int copyId = rdr.GetInt32(2);
    //     Copy newCopy = new Copy(bookId, dueDate, copyId);
    //     allCopys.Add(newCopy);
    //   }
    //
    //   if (rdr != null)
    //   {
    //     rdr.Close();
    //   }
    //   if (conn != null)
    //   {
    //     conn.Close();
    //   }
    //   return allCopys;
    // }
    // public string GetAuthors()
    // {
    //   SqlConnection conn = DB.Connection();
    //   SqlDataReader rdr = null;
    //   conn.Open();
    //
    //
    //   SqlCommand cmd = new SqlCommand("SELECT authors.* FROM books JOIN books_authors ON (books.id = books_authors.book_id) JOIN authors ON (books_authors.author_id = authors.id) WHERE books.id = @BookId;", conn);
    //   SqlParameter courseIdParameter = new SqlParameter();
    //   courseIdParameter.ParameterName = "@BookId";
    //   courseIdParameter.Value = this._bookId;
    //   cmd.Parameters.Add(courseIdParameter);
    //   rdr = cmd.ExecuteReader();
    //
    //   string authorsString = "";
    //
    //   while(rdr.Read())
    //   {
    //     string author = rdr.GetString(0);
    //     authorsString += author + " ";
    //   }
    //
    //   if (rdr != null)
    //   {
    //     rdr.Close();
    //   }
    //   if (conn != null)
    //   {
    //     conn.Close();
    //   }
    //
    //   return authorsString;
    //
    // }
    //
    // public void Renew()
    // {
    //   SqlConnection conn = DB.Connection();
    //  conn.Open();
    //
    //  SqlCommand cmd = new SqlCommand("UPDATE copies SET due_date = '2016-08-15' WHERE id = @CopyId;", conn);
    //
    //  SqlParameter idParameter = new SqlParameter();
    //  idParameter.ParameterName = "@CopyId";
    //  idParameter.Value = this.GetId();
    //
    //  cmd.Parameters.Add(idParameter);
    //
    //  cmd.ExecuteNonQuery();
    //
    //  if (conn != null)
    //  {
    //    conn.Close();
    //  }
    // }

    // public string GetDueDateString()
    // {
    //   DateTime dt =  DateTime.Now;
    //   if (_dueDate.HasValue) dt = _dueDate.Value;
    //
    //   //dt = _dueDate;
    //   return dt.ToString("d");
    // }

    public static void DeleteAll()
    {
      SqlConnection conn = DB.Connection();
      conn.Open();
      SqlCommand cmd = new SqlCommand("DELETE FROM copies; DELETE FROM patrons; DELETE FROM books;", conn);
      cmd.ExecuteNonQuery();
    }

  }
}
