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
    private string _email
    private string _game;
    private string _movie;
    private string _tv;
    private string _pet;

    public Pair(int portland, string home, string github, string linkedin, string email, string game, string movie, string tv, string pet, int Id = 0)
    {
      _id = Id;
      _portland = portland;
      _home = home;
      _github = github;
      _linkedin = linkedin;
      _email = email;
      _game = game;
      _movie = movie;
      _tv = tv;
      _pet = pet;
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
    public string GetGame()
    {
      return _game;
    }
    public void SetGame(string game)
    {
      _game = game;
    }
    public string GetMovie()
    {
      return _movie;
    }
    public void SetMovie(string movie)
    {
      _movie = movie;
    }
    public string GetTv()
    {
      return _tv;
    }
    public void SetTv(string tv)
    {
      _tv = tv;
    }
    public string GetPet()
    {
      return _pet;
    }
    public void SetPet(string pet)
    {
      _pet = pet;
    }

    public void Save()
    {
      SqlConnection conn = DB.Connection();
      SqlDataReader rdr;
      conn.Open();

      SqlCommand cmd = new SqlCommand("INSERT INTO pairs (portland, home, github, linkedin, email, game, movie, tv, pet) OUTPUT INSERTED.id VALUES (@portland, @home, @github, @linkedin, @email, @game, @movie, @tv, @pet);", conn);

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
      EmailParameter.ParameterName = "@Email";
      EmailParameter.Value = this.GetEmail();

      cmd.Parameters.Add(Parameter);

      SqlParameter md3Parameter = new SqlParameter();
      md3Parameter.ParameterName = "@md3";
      md3Parameter.Value = this.GetDueDate();

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