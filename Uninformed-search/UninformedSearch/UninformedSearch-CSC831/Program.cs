using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UninformedSearch_CSC831.Util;

namespace UninformedSearch_CSC831
{
    class Program
    {
        private const bool DEBUG = false;

        static void Main(string[] args)
        {
            TileBoard tileBoard;

            //if (DEBUG)
            //{
            //    string filePath;
            //    if (args.Length == 0)
            //        filePath = "input.txt";
            //    else
            //        filePath = args[0];
            //    string input = "_12345678";

            //    try
            //    {
            //        var sr = new StreamReader(filePath);
            //        input = sr.ReadToEnd();
            //        input = input.Replace("\r\n", "");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //        Console.ReadLine();
            //        return;
            //    }

            //    tileBoard = new TileBoard(input);
            //}

            //if (!DEBUG)
            //{

            //}

            tileBoard = new TileBoard();
            tileBoard.Randomize('_');
            var searches = new Searches();
            Console.WriteLine("==============================Breadth-First Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");

            searches.BreadthFirstSearch(tileBoard.Copy());
            Console.WriteLine("==============================Depth-First Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            searches.DepthFirstSearch(tileBoard.Copy());

            Console.WriteLine("==============================Uniform-Cost Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            UcsImplementation.Execute();

            Console.WriteLine("==============================Depth-Limited Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            searches.DepthLimitedSearch(tileBoard.Copy());
            Console.WriteLine("==============================Iterative-Deepening Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            searches.IterativeDeepeningSearch(tileBoard.Copy());
            Console.WriteLine("==============================Bi-directional Search=========================");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            Console.WriteLine("============================== ============================== ");
            searches.BidirectionalSearch(tileBoard.Copy());
           

            Console.ReadLine();
        }
    }
}
