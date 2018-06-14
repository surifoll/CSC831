using System;
using System.Collections.Generic;
using System.Linq;

namespace UninformedSearch_CSC831.Util
{
    /// <summary>
    /// 1. Nodes are stored according to their priority, which is the total cost of expanding the node.This is implemented
    ///  1. Nodes are stored according to their priority, which is the total cost of expanding the node.This is implemented
    /// in the node classes themselves(by their CompareTo() methods). The node with the lowest path cost is expanded first.
    /// 2. Repeated-state checking is done after the Successor() function, but I found no efficient way to implement a
    /// Replace() function while maintaining O(log n) time in the heap, so some duplicates occur if there is a node already
    /// 
    /// in the frontier but not yet in the set of explored nodes.After messing with numerous combinations of data structures to
    /// achieve this functionality, I had to settle on some repeated states in the frontier. The shorter path would be popped first,
    /// and there is a repeated-state check done after a node is popped to see if it has been explored. If so, it is skipped
    /// entirely, so the main loss is in terms of some extra space, not speed.
    /// 
    /// </summary>
    

    public class UcsImplementation
    {
        public static bool FirstItem = true;

        public static bool SearchComplete = false;

        public static List<City> Locations = new List<City>();//complete list of cities in the collection
        public static List<Edge> Edges = new List<Edge>();
        public static List<Edge> PotentialEdges = new List<Edge>();//list of current potential paths to explore
        public static List<City> PotentialNodes = new List<City>();
        public static List<Edge> ExploredEdges = new List<Edge>(); //list of previously explored paths
        public static List<City> ExploredNodes = new List<City>();

        public static City StartPoint;
        public static City EndPoint;

        public static void Execute()
        {

            //intialise nodes

            City n1 = new City("Uyo");
            City n2 = new City("Yola");
            City n3 = new City("Ilorin");
            City n4 = new City("Ikeja");
            City n5 = new City("Minna");
            City n6 = new City("Ibadan");
            City n7 = new City("Lokoja");
            City n8 = new City("Oshogbo");
            City n9 = new City("Enugu");
            City n10 = new City("Benin");
            //add all into locations list
            Locations.AddMany(n1, n2, n3, n4, n5, n6, n7, n8, n9, n10);
            Console.WriteLine($"select from any of the following cities");
            foreach (var location in Locations)
            {
                Console.WriteLine($" {location.Name} is on the map");
            }
            //initialise edges
            //frankfurt node edges
            Edge e1 = new Edge(n1, n2, 85f);
            Edge e2 = new Edge(n1, n3, 217f);
            Edge e3 = new Edge(n1, n4, 173f);
            //Mannheim node edges
            Edge e4 = new Edge(n2, n5, 250f);
            //Wurzburg node edges
            Edge e5 = new Edge(n3, n6, 186f);
            Edge e6 = new Edge(n3, n7, 103f);
            //Nurnberg node edges
            Edge e7 = new Edge(n7, n8, 183f);
            Edge e8 = new Edge(n7, n10, 167f);
            //Kassel node edges
            Edge e9 = new Edge(n4, n10, 502f);
            //Augsberg node edges
            Edge e10 = new Edge(n9, n10, 84f);
            //add to collection of edges
            Edges.AddMany(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);
            Console.WriteLine("cities in collection: " + Locations.Count);
            Console.WriteLine("edges in collection: " + Edges.Count);

            SetStartPoint();


        }
        /// <summary>
        /// finds next set of potential nodes to check
        /// </summary>
        /// <param name="nextNode"></param>
        //
        //TODO: Pass in starting node as an argument and reset every call until final node is reached
        public static void Examine(City nextNode)
        {
            //search list of edges for any paths where the parent node's name matches our start point name
            PotentialNodes.Add(nextNode);//add start point to OPEN list
            bool examinationComplete = false;

            if (!examinationComplete)
            {
                foreach (City potential in PotentialNodes.ToList())
                {
                    foreach (Edge edge in Edges)
                    {
                        if (edge.Point1.Name == potential.Name)
                        {
                            PotentialNodes.Add(edge.Point2);
                            PotentialEdges.Add(edge);//add potential edge to collection as well as nodes
                            Console.WriteLine("potential next node " + edge.Point2.Name);
                        }
                    }
                }
                examinationComplete = true;
                foreach (City item in PotentialNodes.ToList())//much cleaner way of doing this
                {
                    if (item.Name == nextNode.Name)
                    {
                        ExploredNodes.Add(nextNode);
                        PotentialNodes.Remove(nextNode);
                    }
                }
                //exploredNodes.Add(potentialNodes.First());//add last added node to the CLOSED list
                //potentialNodes.Remove(potentialNodes.First());//remove last added node

                //TODO: create new method to explore. Use: Orderby COST in ascending order and use whatever is at the top
                //to define shortest currently open path
            }
            Compare(nextNode);//pass the explored node into the compare method so we can find the shortest route
            //Console.ReadLine();           
        }
        /// <summary>
        /// order the List in ascending order by cost
        /// </summary>
        /// <param name="option"></param>
        static void Compare(City option)
        {
            if (!SearchComplete)
            {
                PotentialEdges.OrderBy(x => x.Cost).ToList();//order the List in ascending order by cost
                Console.WriteLine("shortest route: " + PotentialEdges.First().Point2.Name);
                PotentialEdges.Remove(PotentialEdges.First());
                if (PotentialEdges.First().Point2.Name == EndPoint.Name)
                {
                    Console.WriteLine("shortest route found! Arrived at " + PotentialEdges.First().Point2.Name);
                    Console.ReadLine();
                }
                else
                {
                    Examine(PotentialEdges.First().Point2);
                }
                //Console.ReadLine();
            }
            else
            {
                PotentialEdges.Clear();
                Console.WriteLine("shortest route found");
            }
        }
        /// <summary>
        /// Set starting point
        /// </summary>
        static void SetStartPoint()
        {
            Console.WriteLine("Enter name of start node (case sensitive)");
            string response;
            response = Console.ReadLine();
            var item = Locations.FirstOrDefault(o => o.Name == response);
            if (item != null)
            {
                Console.WriteLine(item.Name + " is the start point!");
                StartPoint = item;
                SetEndPoint();
            }
            else
            {
                Console.WriteLine("No Match");
                SetStartPoint();
            }
        }
        /// <summary>
        /// Set Ending point
        /// </summary>
        static void SetEndPoint()
        {
            Console.WriteLine("Enter name of end node (case sensetive)");
            string response;
            response = Console.ReadLine();
            var item = Locations.FirstOrDefault(o => o.Name == response);
            if (item != null)
            {
                Console.WriteLine(item.Name + " is the end point!");
                EndPoint = item;
                Console.WriteLine("Type start to start");
                response = Console.ReadLine();
                if (response == "start")
                {
                    Examine(StartPoint);
                }
            }
            else
            {
                Console.WriteLine("No Match");
                SetEndPoint();
            }
        }




    }
}