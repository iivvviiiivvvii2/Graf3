using Graphs;
using System.Runtime.CompilerServices;
//добавляем вершины

var graph = new Graph();
var v1 = new Vertex(1);
var v2 = new Vertex(2);
var v3 = new Vertex(3);
var v4 = new Vertex(4);
var v5 = new Vertex(5);
var v6 = new Vertex(6);
var v7 = new Vertex(7);
var v8 = new Vertex(8);
var v9 = new Vertex(9);

graph.AddVertex(v1);
graph.AddVertex(v2);
graph.AddVertex(v3);
graph.AddVertex(v4);
graph.AddVertex(v5);
graph.AddVertex(v6);
graph.AddVertex(v7);
graph.AddVertex(v8);
graph.AddVertex(v9);

//добавляем ребра

graph.AddEdge(v1,v2);
graph.AddEdge(v1,v3);
graph.AddEdge(v3,v4);
graph.AddEdge(v2,v5);
graph.AddEdge(v2,v6);
graph.AddEdge(v6,v5);
graph.AddEdge(v5,v6);
graph.AddEdge(v5, v8);
graph.AddEdge(v4, v9);

//строим матрицу смежности

var matrix = graph.GetMatrix();

//выводим на консоль матрицу смежности

for (int i = 0;i < graph.VCount; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;   
    Console.Write(i+1 + " ");
    Console.ForegroundColor = ConsoleColor.White;
    for (int j = 0; j < graph.VCount; j++)
    {
        Console.Write(matrix[i,j] + " " );
    } 
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Green;
for (int j = 0; j < graph.VCount; j++)
{
    if (j == 0)
        Console.Write($" ");
    Console.Write($" {j + 1}");
}
Console.ForegroundColor = ConsoleColor.White;
//проверяем на наличие  смежныых вершин
Console.WriteLine();
graph.GetVertex(graph, v1);
Console.WriteLine();
graph.GetVertex(graph, v4);
Console.WriteLine();
graph.GetVertex(graph, v6);
Console.WriteLine();
graph.GetVertex(graph, v7);
Console.WriteLine();
//ищем наличие пути между вершинами
//Console.WriteLine(graph.Wave(v1, v7));
//Console.WriteLine(graph.Wave(v4, v3));
//Console.WriteLine(graph.Wave(v5, v4));
//Console.WriteLine(graph.Wave(v3, v4));
//Console.WriteLine(graph.Wave(v3, v7));
//ищем наличие пути между вершинами
Console.WriteLine(graph.Wave(v1, v7));
//Console.WriteLine(graph.Wave(v1, v5));
//Console.WriteLine(graph.Wave(v1, v7));

Console.WriteLine();






