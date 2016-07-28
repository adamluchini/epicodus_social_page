using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Codex.Objects;

namespace Codex.Tests
{
  public class ProfileTest : IDisposable
  {
    public ProfileTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=epicodex_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      //Arrange, Act
      int result = Profile.GetAll().Count;
      //Assert
      Assert.Equal(0,result);
    }
    [Fact]
    public void Test_FindCopy()
    {
      Profile newProfile = new Profile(Ei:true, Email:"email", Enrollment:1, Experience:1, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      newProfile.Save();

      //Act
      Profile p = Profile.Find(newProfile.id);
      int result = Profile.Find(newProfile.id).id;
      //Assert.Equal(1,1);
      Assert.Equal(newProfile.id, result);
    }
    [Fact]
    public void Test_Match_PerfectlyMatchMB()
    {
      Profile firstProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      Profile secondProfile = new Profile(Ei:true, Email:"email", Enrollment:1, Experience:1, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      firstProfile.Save();
      secondProfile.Save();
      List<Profile> result =  new List<Profile> {firstProfile};

      Assert.Equal(result, Match.MatchMBs(secondProfile, "perfect"));
    }
    [Fact]
    public void Test_Match_GoodMatchMB()
    {
      Profile firstProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:false, Pj:true, Portland:1, Style:1, Tf:true);
      Profile secondProfile = new Profile(Ei:true, Email:"email", Enrollment:1, Experience:1, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      firstProfile.Save();
      secondProfile.Save();
      List<Profile> result =  new List<Profile> {firstProfile};

      Assert.Equal(result, Match.MatchMBs(secondProfile, "good"));
    }
    [Fact]
    public void Test_Match_PerfectlyMatchXP()
    {
      Profile firstProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      Profile secondProfile = new Profile(Ei:true, Email:"email", Enrollment:1, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      firstProfile.Save();
      secondProfile.Save();
      List<Profile> result =  new List<Profile> {firstProfile};

      Assert.Equal(result, Match.MatchXPs(secondProfile, "perfect"));
    }
    [Fact]
    public void Test_Match_GoodMatchXP()
    {
      Profile firstProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:false, Pj:true, Portland:1, Style:1, Tf:true);
      Profile secondProfile = new Profile(Ei:true, Email:"email", Enrollment:1, Experience:1, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      firstProfile.Save();
      secondProfile.Save();
      List<Profile> result =  new List<Profile> {firstProfile};

      Assert.Equal(result, Match.MatchXPs(secondProfile, "good"));
    }
    [Fact]
    public void Test_Match_PerfectlyMatchElse()
    {
      Profile firstProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      Profile secondProfile = new Profile(Ei:true, Email:"email", Enrollment:2, Experience:2, Github:"github", Home:"home", Linkedin:"linkedin", Name:"Jim", Ns:true, Pj:true, Portland:1, Style:1, Tf:true);
      firstProfile.Save();
      secondProfile.Save();
      List<Profile> result =  new List<Profile> {firstProfile};

      Assert.Equal(result, Match.MatchElses(secondProfile, "perfect"));
    }
    public void Dispose()
    {
      Profile.DeleteAll(new string[] {"profile"});
      Console.WriteLine("");
    }
  }
}
