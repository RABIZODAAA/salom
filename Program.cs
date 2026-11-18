using System.Diagnostics;

Post post = new Post()
{
    Title = "saliom",
    Description = "asaklom",
    LikeCount=31
    };

post.Publish();

post.Like();

Console.WriteLine($"FullName: {}");