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
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=codex_test;Integrated Security=SSPI;";
    }
  }
}
