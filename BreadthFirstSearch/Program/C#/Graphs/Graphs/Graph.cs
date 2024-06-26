

namespace Graphs
{//Это направленый граф
    internal class Graph
    {
        /// список вершин
        List<Vertex> V = new List<Vertex>();
        /// список ребер
        List<Edge> E = new List<Edge>();
      
      

        public int VCount => V.Count;
        public int ECount => E.Count;

        //строим матрицу смежности
        public int[,] GetMatrix()
        {
            int[,] matrix = new int[V.Count, V.Count];
            foreach (Edge e in E)
            {
                var row = e.From.Number-1; 
                var column = e.To.Number-1;
                matrix[row,column] = e.Weight;
            }
            return matrix;
        }
        /// добавляекм вершину
        public void AddVertex(Vertex vertex)
        {
            V.Add(vertex);
        }
        /// добавляем ребро
        public void AddEdge(Vertex from,Vertex to)
        { 
            var edge = new Edge(from, to);
            E.Add(edge); 
        }
        /// поиск смежных вершин
        public List<Vertex> GetVertexList(Vertex vertex)
        {
            var list = new List<Vertex>();
            foreach(var adge in E)
            {
                if (adge.From == vertex)
                    list.Add(adge.To);
            }
            return list;

        }
        //проход графа. Ищем существует ли  путь между  вершинами
        ///  start - стартовая вершина ,  finish - конечная вершина

        public bool Wave(Vertex start, Vertex finish)
        {
            int sourceIndex = -1;
           
            var queue = new Queue<Vertex>();
            //помещаем стартовую вершину в стек
            queue.Enqueue(start) ;
            //цикл поиска. Он проходит обход дерева
            //если путь не найден после поиска по дереву функция возвращает false

            while (queue.Count != 0)
            {
                //берем из очереди вершину
                var vertex = queue.Peek();
                //находим индекс вершины в списке
                sourceIndex = V.IndexOf(vertex);
                //если вершина не пройдена
                if (!V[sourceIndex].Visited )
                //выводим вершину на консоль
                Console.WriteLine(vertex.ToString());
                //ищем смежные вершины если  они есть
                foreach (var v in GetVertexList(vertex))
                {
                    //если вершина не пройдена
                    if (V[sourceIndex].Visited == false)
                    {
                        //заносим вершину в очередь
                        queue.Enqueue(v);

                        //есть ли в очереди искомая вершина
                        if (queue.Contains(finish))
                        {
                            Console.WriteLine(finish.ToString());

                            return true;
                        }

                          
                    }
                }
                //помечаем вершину пройденной
                V[sourceIndex].Visited = true;
                //удаляем обработанную вершину из очереди
                queue.Dequeue();
                //if (!list.Peek().Equals(str))
                //{
                //    //Удаляет  объект, находящийся в начале очереди.
                //    queue.Dequeue();
                //}
            }
            //путь не найден
            return false;
        }

        //выводит смежные вершин
        public void GetVertex(Graph graph, Vertex vertex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Вернина {vertex.Number} имеет смежные вершины :     ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var v in graph.GetVertexList(vertex))
            {
                Console.Write(v.Number + " , ");
            }
        }

        //////////////////////////////////////////////////////
        ///
        //1-white 2-black
       

    }
}
