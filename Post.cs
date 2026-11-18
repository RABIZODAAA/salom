using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int LikeCount { get; set; }
    List<string> Comments = [];

    public bool IsPublished = false;

    public void Publish()
    {
        Console.WriteLine("The post is published.");

        IsPublished = true;
    }

    public void Like()
    {
        LikeCount++;
    }
    

}