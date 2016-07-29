using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Codex.Objects;

namespace Codex.Tests
{
  public class MessageManagerTest : IDisposable
  {
    public MessageManagerTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=epicodex_test;Integrated Security=SSPI;";
    }

    [Fact]
    public void Test_GetAllNonHobbyMessages()
    {
      //Arrange,
      Message_Post test1Message = new Message_Post("My parents are out of town this weekend. Party!!!", 1, new DateTime(2016, 7, 12), "Kegger!", 3);
      test1Message.Save();

      MessageManager m = new MessageManager(1);
      // Act
      var result = m.GetMessages().Count;
      //int result = MessageManager.GetAll().Count;
      //Assert
      Assert.Equal(2,result);
    }
    [Fact]
    public void Test_GetComments()
    {
      //Arrange,
      Message_Post test1Message = new Message_Post("My parents are out of town this weekend. Party!!!", 1, new DateTime(2016, 7, 12), "Kegger!", 3);
      test1Message.Save();
      Comment test1Comment = new Comment("I'm down, do you need me to bring anything?", test1Message.id, 1, 5);
      test1Comment.Save();

      MessageManager m = new MessageManager(1);
      // Act
      var result = m.GetComments(test1Message.id).Count;

      Console.WriteLine("commentss: " + result);
      //int result = MessageManager.GetAll().Count;
      //Assert
      Assert.Equal(1,result);
    }



    public void Dispose()
    {
      //Message_Post.DeleteAll(new string[] {"messages_posts"});
    }

  }
}
