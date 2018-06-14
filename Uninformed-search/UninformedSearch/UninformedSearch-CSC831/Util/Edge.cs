


namespace UninformedSearch_CSC831.Util
{

    /// <summary>
    /// edges between nodes
    /// </summary>
    public class Edge
    {
        public City Point1;
        public City Point2;

        public float Cost;

        public Edge(City p1, City p2, float cost)
        {
            Point1 = p1; Point2 = p2; this.Cost = cost;
        }
    }
}
