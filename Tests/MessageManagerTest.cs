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
      MessageManager m = new MessageManager(1);
      // Act
      var result = m.GetMessages().Count;
      //int result = MessageManager.GetAll().Count;
      //Assert
      Assert.Equal(4,result);
    }



    public void Dispose()
    {
      //Message_Post.DeleteAll(new string[] {"messages_posts"});
    }

  }
}
