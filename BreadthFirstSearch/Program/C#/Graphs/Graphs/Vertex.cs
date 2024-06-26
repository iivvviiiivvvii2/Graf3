

namespace Graphs
{
    internal class Vertex
    {
        public Vertex(int number,bool visited = false)
        {
            Number = number;
            Visited = visited;
        }


        /// <summary>
        /// вершина
        /// </summary>
        public  int Number {  get; set; }
        /// посещение вершины
        public bool Visited { get => visited; set => visited = value; }
        bool visited;


        public override string ToString()
        {
            return Number.ToString();
        }


    }
}
