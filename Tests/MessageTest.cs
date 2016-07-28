using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using Codex.Objects;

namespace Codex
{
  public class Message_Post_Test : IDisposable
  {
    public Message_Post_Test()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=epicodex_test;Integrated Security=SSPI;";
    }
    [Fact]
    public void Test_DatabaseEmptyAtFirst()
    {
      //Arrange, Act
      int result = Message_Post.GetAll().Count;
      //Assert
      Assert.Equal(0, result);
    }
    [Fact]
    public void Test_DatabaseSaveMessagesFirst()
    {
      Message_Post test1Message = new Message_Post("My parents are out of town this weekend. Party!!!", 2, new DateTime(2016, 7, 12), "Kegger!", 3);
      Message_Post test2Message = new Message_Post("My parents are out of town this weekend. Party!!!", 2, new DateTime(2016, 7, 12), "Kegger!", 3);

      //Assert
      Assert.Equal(test1Message, test2Message);
    }

    [Fact]
    public void Test_Save_SaveMessagesToDatabase()
    {
      Message_Post test1Message = new Message_Post("My parents are out of town this weekend. Party!!!", 2, new DateTime(2016, 7, 12), "Kegger!", 3);
      test1Message.Save();
      List<Message_Post> resultMessages = Message_Post.GetAll();
      List<Message_Post> testMessages = new List<Message_Post>{test1Message};
      //Assert
      Assert.Equal(testMessages, resultMessages);
    }

    public void Dispose()
    {
      Message_Post.DeleteAll(new string[] {"messages_posts"});
      // Console.WriteLine("");
    }
  }
}
