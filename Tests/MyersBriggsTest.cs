using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Codex.Objects;

namespace Codex.Tests
{
  public class MyersBriggsTest : IDisposable
  {
    public MyersBriggsTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Codex_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      //Arrange, Act
      int result = MyersBriggs.GetAll().Count;
      //Assert
      Assert.Equal(0,result);
    }
    [Fact]
    public void Test_FindCopy()
    {
      MyersBriggs newMyersBriggs = new MyersBriggs(true, true, true, true);
      newMyersBriggs.Save();

      //Act
      int result =MyersBriggs.Find(newMyersBriggs.id).id;

      Assert.Equal(newMyersBriggs.id, result);
    }

    public void Dispose()
    {
      MyersBriggs.DeleteAll(new string[] {"myers_briggs"});
      Console.WriteLine("");
    }


  }
}
