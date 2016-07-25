using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class Pair
  {
    private int _id;
    private int _portland;
    private string _home;
    private string _github;
    private string _linkedin;
    private string _email;

    public Pair(int portland, string home, string github, string linkedin, string email, int Id = 0)
    {
      _id = Id;
      _portland = portland;
      _home = home;
      _github = github;
      _linkedin = linkedin;
      _email = email;
    }

    public int GetId()
    {
      return _id;
    }
    public int GetPortland()
    {
      return _portland;
    }
    public void SetPortland(int portland)
    {
      _portland = portland;
    }
    public string GetHome()
    {
      return _home;
    }
    public void SetHome(string home)
    {
      _home = home;
    }
    public string GetGithub()
    {
      return _github;
    }
    public void SetGithub(string github)
    {
      _github = github;
    }
    public string GetLinkedin()
    {
      return _linkedin;
    }
    public void SetLinkedin(string linkedin)
    {
      _linkedin = linkedin;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string email)
    {
      _email = email;
    }

    public void Save()
    {
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr;
      conn.Open();

      SqlCommand cmd = new SqlCommand("INSERT INTO pairs (portland, home, github, linkedin, email) OUTPUT INSERTED.id VALUES (@portland, @home, @github, @linkedin, @email);", conn);

      SqlParameter portlandParameter = new SqlParameter();
      portlandParameter.ParameterName = "@portland";
      portlandParameter.Value = this.GetPortland();

      cmd.Parameters.Add(portland);

      SqlParameter homeParameter = new SqlParameter();
      homeParameter.ParameterName = "@home";
      homeParameter.Value = this.GetHome();

      cmd.Parameters.Add(homeParameter);

      SqlParameter githubParameter = new SqlParameter();
      githubParameter.ParameterName = "@github";
      githubParameter.Value = this.GetGithub();

      cmd.Parameters.Add(githubParameter);

      SqlParameter linkedinParameter = new SqlParameter();
      linkedinParameter.ParameterName = "@linkedin";
      linkedinParameter.Value = this.GetLinkedin();

      cmd.Parameters.Add(linkedinParameter);

      SqlParameter emailParameter = new SqlParameter();
      emailParameter.ParameterName = "@email";
      emailParameter.Value = this.GetEmail();

      cmd.Parameters.Add(emailParameter);


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
