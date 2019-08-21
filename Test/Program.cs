using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new JavaScriptSerializer();

            string filePath = "E:\\Visual Studio Files\\JSONText.txt";
            string result = File.ReadAllText(filePath);
            List<Comment> comments = (List<Comment>)serializer.Deserialize(result, typeof(List<Comment>));

            foreach(Comment comment in comments)
            {
                Console.WriteLine(comment.name + "," + comment.id + "," + comment.email + "," + comment.body + "," + comment.postId);                
            }            

            Console.ReadLine();
        }
    }
}
