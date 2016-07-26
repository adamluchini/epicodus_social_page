using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Codex.Objects
{
  public class MyersBriggs
  {
    private int _id;
    private bool _ei;
    private bool _ns;
    private bool _tf;
    private bool _pj;

    public MyersBriggs (bool ei, bool ns, bool tf, bool pj, int Id = 0)
    {
      _id = Id;
      _ei = Ei;
      _ns = Ns;
      _tf = Tf;
      _pj = Pj;
    }

    public int GetId()
    {
      return _id;
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
  }
}
