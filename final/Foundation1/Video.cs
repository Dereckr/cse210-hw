using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
public class Video{

    public string _title;
    public string _author;
    public string _length;

   public List<Comment> _comments = new List<Comment>();
   public List<Video> _videos = new List<Video>();

   public void DisplayAllVideos()
   {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
        }
   }


    public void DisplayVideo()
    {
        Console.WriteLine($"the title of the video is: {_title} by {_author}");
        Console.WriteLine($"The length is: {_length}");
        foreach (Comment comment in _comments) 
        {
            comment.DisplayComment();
        } 
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine("");
    }
}