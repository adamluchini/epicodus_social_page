using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Profile: SavableObject<Profile>
  {
    // private int _id;
    private bool _ei;
    private string _email;
    private int _enrollment;
    private int _experience;
    private string _github;
    private string _home;
    private string _linkedin;
    private bool _ns;
    private bool _pj;
    private int _portland;
    private int _style;
    private bool _tf;

    public Profile(
    bool Ei,
    string Email,
    int Enrollment,
    int Experience,
    string Github,
    string Home,
    string Linkedin, bool Ns, bool Pj, int Portland, int Style, bool Tf, int Id = 0)
    {
      id = Id;
      _ei = Ei;
      _email = Email;
      _enrollment = Enrollment;
      _experience = Experience;
      _github = Github;
      _home = Home;
      _linkedin = Linkedin;
      _ns = Ns;
      _pj = Pj;
      _portland = Portland;
      _style = Style;
      _tf = Tf;
    }

    public override bool Equals(System.Object otherProfile)
    {
      if (!(otherProfile is Profile))
      {
        return false;
      }
      else
      {
        Profile newProfile = (Profile) otherProfile;
        bool idEquality = (this.id == newProfile.id);
        return (idEquality);
      }
    }

    public static string table
    {
      get
      {
        return "profile";
      }
    }

    public int experience
    {
      get
      {
        return _experience;
      }
      set
      {
        _experience = value;
      }
    }

    public int portland
    {
      get
      {
        return _portland;
      }
      set
      {
        _portland = value;
      }
    }
    public int style
    {
      get
      {
        return _style;
      }
      set
      {
        _style = value;
      }
    }
    public string home
    {
      get
      {
        return _home;
      }
      set
      {
        _home = value;
      }
    }
    public string github
    {
      get
      {
        return _github;
      }
      set
      {
        _github = value;
      }
    }
    public string linkedin
    {
      get
      {
        return _linkedin;
      }
      set
      {
        _linkedin = value;
      }
    }
    public string email
    {
      get
      {
        return _email;
      }
      set
      {
        _email = value;
      }
    }
    public int enrollment
    {
      get
      {
        return _enrollment;
      }
      set
      {
        _enrollment = value;
      }
    }
    public bool ei
    {
      get
      {
        return _ei;
      }
      set
      {
        _ei = value;
      }
    }
    public bool ns
    {
      get
      {
        return _ns;
      }
      set
      {
        _ns = value;
      }
    }
    public bool tf
    {
      get
      {
        return _tf;
      }
      set
      {
        _tf = value;
      }
    }
    public bool pj
    {
      get
      {
        return _pj;
      }
      set
      {
        _pj = value;
      }
    }







    // public List<MyersBriggs> GetMyersBriggs()
    // {
    //   DBObjects dbo = DBObjects.CreateCommand("SELECT * FROM myers_briggs WHERE profile_id=@Id;", new List<string> {"@Id"}, new List<object> {id});
    //   SqlDataReader rdr = dbo.RDR;
    //   rdr = dbo.CMD.ExecuteReader();
    //
    //   List<MyersBriggs> works = new List<MyersBriggs> {};
    //   while(rdr.Read())
    //   {
    //     works.Add(new MyersBriggs(rdr.GetBoolean(1), rdr.GetBoolean(2), rdr.GetBoolean(3), rdr.GetInt32(4), rdr.GetBoolean(5), rdr.GetInt32(0) ));
    //   }
    //   dbo.Close();
    //   return works;
    //}

  }
}
