using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

    
        Video video1 = new Video();
        video1._title = "Baby Shark";
        video1._author = "Pinkfong";
        video1._length="2 minutes 16 seconds";

        Comment comment1= new Comment();
        comment1._name="Francisco";
        comment1._comment= " I like the video a lot";
        video1._comments.Add(comment1);
        Comment comment2 = new Comment();
        comment2._name = "Frank";
        comment2._comment = "My kids love this video";
        video1._comments.Add(comment2);
        Comment comment3 = new Comment();
        comment3._name = "Louis";
        comment3._comment = "I think people shouldn't show this video to their kids";
        video1._comments.Add(comment3);

        

        Video video2= new Video();
        video2._title = "If I Could Hie to Kolob";
        video2._author = "Eric Johnson";
        video2._length = "7 minutes 13 seconds";

        Comment comment1_2= new Comment();
        comment1_2._name="Erick";
        comment1_2._comment= " It lifts me up";
        video2._comments.Add(comment1);
        Comment comment2_2 = new Comment();
        comment2_2._name = "Sam";
        comment2_2._comment = "What a great video";
        video2._comments.Add(comment2);
        Comment comment3_2 = new Comment();
        comment3_2._name = "Liz";
        comment3_2._comment = "Cannot stop thinking in eternity";
        video2._comments.Add(comment3);
                

        Video video3 = new Video();
        video3._title = "In the End";
        video3._author= "Linkin Park";
        video3._length = "3 minutes 39 seconds";

        Comment comment1_3 = new Comment();
        comment1_3._name = "Tracy";
        comment1_3._comment = "This song rocks!";
        video3._comments.Add(comment1_3);  
        Comment comment2_3 = new Comment();
        comment2_3._name = "Kim";
        comment2_3._comment ="This song reminds me my youth";
        video3._comments.Add(comment2_3);  
        Comment comment3_3 = new Comment();
        comment3_3._name = "Pachi";
        comment3_3._comment = "I think this is the best Linkin Park's song";
        video3._comments.Add(comment3_3);  

        Video videoAll = new Video();
        videoAll._videos.Add(video1);
        videoAll._videos.Add(video2);
        videoAll._videos.Add(video3);


        videoAll.DisplayAllVideos();




    }
}