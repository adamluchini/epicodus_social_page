using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;


namespace Codex.Objects
{
  public class Comment : SavableObject<Comment>
  {
    private string _commentBody;
    private int _messageId;
    private int _profileId;
    private int _totalLikes;

    public Comment(string CommentBody, int MessageId, int ProfileId, int TotalLikes, int Id=0)
    {
      id = Id;
      _commentBody = CommentBody;
      _messageId = MessageId;
      _profileId = ProfileId;
      _totalLikes = TotalLikes;

    }
    public string GetName()
    {
      return Profile.Find(_profileId).name;
    }
    public override bool Equals(System.Object otherComment)
    {
      if (!(otherComment is Comment))
      {
        return false;
      }
      else
      {
        Comment newComment = (Comment) otherComment;
        bool idEquality = (this.id == newComment.id);
        return (idEquality);
      }
    }
    public static string table
    {
      get
      {
        return "comments";
      }
    }

    public string comment_body
    {
      get
      {
        return _commentBody;
      }
      set
      {
        _commentBody = value;
      }
    }
    public int message_id
    {
      get
      {
        return _messageId;
      }
      set
      {
        _messageId = value;
      }
    }
    public int profile_id
    {
      get
      {
        return _profileId;
      }
      set
      {
        _profileId = value;
      }
    }
    public int total_likes
    {
      get
      {
        return _totalLikes;
      }
      set
      {
        _totalLikes = value;
      }
    }
  }
}
