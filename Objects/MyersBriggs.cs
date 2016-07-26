using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class MyersBriggs: SavableObject<MyersBriggs>
  {

    private bool _ei;
    private bool _ns;
    private bool _tf;
    private bool _pj;
    private int profile_id;

    public MyersBriggs (bool Ei, bool Ns, bool Pj, bool Tf, int Id = 0)
    {
      id = Id;
      Console.WriteLine("Constructor input values: " + Ei + Ns + Tf + Pj + Id.ToString());
      _ei = Ei;
      _ns = Ns;
      _tf = Tf;
      _pj = Pj;
    }
        public static string table
        {
          get
          {
            return "myers_briggs";
          }
        }

    public bool ei
    {
      get
      {
        return _ei;
      }
      set
      {
        _ei = value;
      }
    }
    public bool ns
    {
      get
      {
        return _ns;
      }
      set
      {
        _ns = value;
      }
    }
    public bool tf
    {
      get
      {
        return _tf;
      }
      set
      {
        _tf = value;
      }
    }
    public bool pj
    {
      get
      {
        return _pj;
      }
      set
      {
        _pj = value;
      }
    }

    public int Match(MyersBriggs mb)
    {
      int counter = 0;
      if(this._ei != mb._ei)
        counter++;
      if(this._ns == mb._ns && this._tf == mb._tf)
        counter++;
      if(this._pj != mb._pj)
        counter++;
      return counter;
    }



  }
}
