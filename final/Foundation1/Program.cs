using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>
        {
            new Video
            {
                Title = "Titanic",
                Author = "James Cameroon",
                Length = 100,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "eve", Text = "Great love story!" },
                    new Comment { CommenterName = "lindsay", Text = "I wish Jack made it offshore!" },
                    new Comment { CommenterName = "James", Text = "Loved it, I am saddened by the ending though" }
                }
            },
            new Video
            {
                Title = "300",
                Author = "Frank Miller and Lynn Varley",
                Length = 97,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "Hannah", Text = "Epic!" },
                    new Comment { CommenterName = "daniel", Text = "I loved the phrse 'This is Sparta' " },
                    new Comment { CommenterName = "Nathan", Text = "so much blood shading; disgusting." }
                }
            },
            new Video
            {
               Title = "The sound of Freedom",
                Author = "Jenny Weaver",
                Length = 135,
                Comments = new List<Comment>
                {
                    new Comment { CommenterName = "Kendra", Text = "Happy to know there are still great people out in the world" },
                    new Comment { CommenterName = "Getu", Text = "I litrally cried through the entire movie' " },
                    new Comment { CommenterName = "David", Text = "thank you Angle studio!" }
                } 
            }
        };

        // Display information of the videos video
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
