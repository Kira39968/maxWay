using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace maxWay
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile("https://dl.dropboxusercontent.com/u/28873424/tasks/simple_triangle.txt", "TriangleToParsing.txt");
            Parser parseTriangle = new Parser("TriangleToParsing.txt");
            Console.WriteLine("The max way of triangle is " + parseTriangle.MaxWayOfTriangle());
            Console.ReadKey();
        }
    }
}
