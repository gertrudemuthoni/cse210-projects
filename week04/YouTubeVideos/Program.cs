using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate 3 video objects
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        // Set appropriate values for each video object 
        video1._title = "Video 1";
        video1._author = "Author 1";
        video1._length = 60;
        Comment v1c1 = new Comment { _commentor = "Tracy Wallace", _commentText = "My intrusive thoughts agreeing!" };
        Comment v1c2 = new Comment { _commentor = "Jacob Mulan", _commentText = "I love your perspective on this." };
        Comment v1c3 = new Comment { _commentor = "Gray Tim", _commentText = "This is a great video!" };
        Comment v1c4 = new Comment { _commentor = "Jane Cook", _commentText = "I learned a lot from this." };
        video1._comments.Add(v1c1);
        video1._comments.Add(v1c2);
        video1._comments.Add(v1c3);
        video1._comments.Add(v1c4); 
        
        video2._title = "Video 2";
        video2._author = "Author 2";        
        video2._length = 120;
        Comment v2c1 = new Comment { _commentor = "Nancy Drew", _commentText = "Could your improve on your audio?" };
        Comment v2c2 = new Comment { _commentor = "Sarah Mara", _commentText = "The points shared are valid." };
        Comment v2c3 = new Comment { _commentor = "Mickey Doe", _commentText = "I love this video!" };
        Comment v2c4 = new Comment { _commentor = "Jane Doe", _commentText = "This is a great video!" };
        video2._comments.Add(v2c1);
        video2._comments.Add(v2c2); 
        video2._comments.Add(v2c3);
        video2._comments.Add(v2c4);
        
        video3._title = "Video 3";
        video3._author = "Author 3";
        video3._length = 180;
        Comment v3c1 = new Comment { _commentor = "Sally Marley", _commentText = "How insightful!" };
        Comment v3c2 = new Comment { _commentor = "Dawson Lawson", _commentText = "This was very informative." };
        Comment v3c3 = new Comment { _commentor = "Martha Stewart", _commentText = "I learned a lot from this." };
        Comment v3c4 = new Comment { _commentor = "John Doe", _commentText = "Great video!" };
        video3._comments.Add(v3c1);
        video3._comments.Add(v3c2); 
        video3._comments.Add(v3c3);
        video3._comments.Add(v3c4);

        List<Video> videos = new List<Video>();  
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine();

            foreach (Comment comment in video._comments)
            {
                comment.DisplayComment();
                Console.WriteLine();
            }
        } 
  
   

    }
}