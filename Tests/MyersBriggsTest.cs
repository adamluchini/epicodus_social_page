// using Xunit;
// using System.Collections.Generic;
// using System;
// using System.Data;
// using System.Data.SqlClient;
// using Codex.Objects;
//
// namespace Codex.Tests
// {
//   public class MyersBriggsTest : IDisposable
//   {
//     public MyersBriggsTest()
//     {
//       DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Codex_test;Integrated Security=SSPI;";
//     }
//
//     [Fact]
//     public void Test_DatabaseEmptyAtFirst()
//     {
//       //Arrange, Act
//       int result = MyersBriggs.GetAll().Count;
//       //Assert
//       Assert.Equal(0,result);
//     }
//     [Fact]
//     public void Test_FindCopy()
//     {
//       MyersBriggs newMyersBriggs = new MyersBriggs(true, true, true, 1, true);
//       newMyersBriggs.Save();
//
//       //Act
//       int result =MyersBriggs.Find(newMyersBriggs.id).id;
//
//       Assert.Equal(newMyersBriggs.id, result);
//     }
//
//     [Fact]
//     public void Test_Match_PerfectMatch()
//     {
//       MyersBriggs firstMyersBriggs = new MyersBriggs(false, true, false, 1, true);
//       MyersBriggs secondMyersBriggs = new MyersBriggs(true, true, true, 2, true);
//       firstMyersBriggs.Save();
//       secondMyersBriggs.Save();
//
//       Assert.Equal(3,  firstMyersBriggs.Match(secondMyersBriggs));
//     }
//     [Fact]
//     public void Test_Match_GoodMatch()
//     {
//       MyersBriggs firstMyersBriggs = new MyersBriggs(true, true, false, 1, true);
//       MyersBriggs secondMyersBriggs = new MyersBriggs(true, true, true, 2, true);
//       firstMyersBriggs.Save();
//       secondMyersBriggs.Save();
//
//       Assert.Equal(2, firstMyersBriggs.Match(secondMyersBriggs));
//     }
//     [Fact]
//     public void Test_Match_OkayMatch()
//     {
//       MyersBriggs firstMyersBriggs = new MyersBriggs(true, true, true, 1, true);
//       MyersBriggs secondMyersBriggs = new MyersBriggs(true, true, true, 2, true);
//       firstMyersBriggs.Save();
//       secondMyersBriggs.Save();
//
//       Assert.Equal(1, firstMyersBriggs.Match(secondMyersBriggs));
//     }
//     [Fact]
//     public void Test_Match_NoMatch()
//     {
//       MyersBriggs firstMyersBriggs = new MyersBriggs(true, false, true, 1, false);
//       MyersBriggs secondMyersBriggs = new MyersBriggs(true, true, true, 2, true);
//       firstMyersBriggs.Save();
//       secondMyersBriggs.Save();
//
//       Assert.Equal(0, firstMyersBriggs.Match(secondMyersBriggs));
//     }
//
//     public void Dispose()
//     {
//       MyersBriggs.DeleteAll(new string[] {"myers_briggs"});
//       Console.WriteLine("");
//     }
//   }
// }
