using System;

class MainClass {
  public static void Main (string[] args) {
    int numVertices, numEdges;
    int[,] adjacencyMatrix = new int[10, 10];

    Console.Write("Enter the number of vertices you want (maximum 10): ");
    numVertices = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of edges you want (maximum 10): ");
    numEdges = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < numVertices; i++)
    {
        int vertex1, vertex2;
        Console.Write("Enter the endpoints of edge {0}: ", i+1);
        vertex1 = Convert.ToInt32(Console.ReadLine());
        vertex2 = Convert.ToInt32(Console.ReadLine());

        adjacencyMatrix[vertex1, vertex2] = 1;
        adjacencyMatrix[vertex2, vertex1] = 1;
    }

    Console.WriteLine("The adjacency matrix is:");

    for(int i = 0; i < numVertices; i++)
    {
        for(int j = 0; j < numVertices; j++)
        {
            Console.Write(adjacencyMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
  }
}
