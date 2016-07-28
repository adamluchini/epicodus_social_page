using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Codex.Objects;

namespace Codex
{
  public class CommentTest : IDisposable
  {
    public CommentTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=epicodex_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      //Arrange, Act
      int result = Comment.GetAll().Count;
      //Assert
      Assert.Equal(0, result);
    }
    [Fact]
    public void Test_DatabaseSaveCommentsFirst()
    {
      Comment test1Comment = new Comment("I'm down, do you need me to bring anything?", 2, 3, 5);
      Comment test2Comment = new Comment("I'm down, do you need me to bring anything?", 2, 3, 5);

      //Assert
      Assert.Equal(test1Comment, test2Comment);
    }

    [Fact]
    public void Test_Save_SaveCommentsToDatabase()
    {
      Comment test1Comment = new Comment("I'm down, do you need me to bring anything?", 2, 3, 5);
      test1Comment.Save();
      List<Comment> resultComments = Comment.GetAll();
      List<Comment> testComments = new List<Comment>{test1Comment};
      //Assert
      Assert.Equal(testComments, resultComments);
    }

    public void Dispose()
    {
      Comment.DeleteAll(new string[] {"comments"});
      // Console.WriteLine("");
    }
  }
}
