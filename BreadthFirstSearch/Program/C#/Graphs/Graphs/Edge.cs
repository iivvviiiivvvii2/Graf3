using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{ /// класс ребра
    internal class Edge
    {
        public Edge(Vertex from, Vertex to, int weight = 1)
        {
            From = from;
            To = to;
            Weight = weight;
        }
        ///  вершина ребра 
        public Vertex From { get; set; }
        public Vertex To { get; set; }
        /// вес ребра
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"({From};  {To};)";
        }
    }
}
