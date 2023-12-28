using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //using (var streamReader = new StreamReader(@"c:\file.zip"))
                //{
                //    var content = streamReader.ReadToEnd();
                //}
                var api = new YouTubeApi();
                var videos = api.GetVideos("mosh");
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Sorry, unexpected error occured.");
                Console.WriteLine(ex.Message);
                
                Console.ReadLine();
            }
            
            
        }
    }
}
