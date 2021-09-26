using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UnlockPattern2
{
    class graph
    {
        private int V;
        private List<int>[] adj;
        public graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");


            List<int> vList = adj[v];
            foreach( var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        void DFS(int v)
        {
            bool[] visited = new bool[V];

            DFSUtil(v, visited);
        }


        static void Main(string[] args)
        {
            graph g = new graph(9);

            g.AddEdge(0, 1); g.AddEdge(0, 3); g.AddEdge(0, 4); g.AddEdge(0, 5);g.AddEdge(0, 7);
            g.AddEdge(1, 0);g.AddEdge(1, 2);g.AddEdge(1, 4);g.AddEdge(1, 3);g.AddEdge(1, 5);g.AddEdge(1, 8);g.AddEdge(1, 6);
            g.AddEdge(2, 1);g.AddEdge(2, 3);g.AddEdge(2, 4);g.AddEdge(2, 5);g.AddEdge(2, 7);
            g.AddEdge(3, 0); g.AddEdge(3, 1); g.AddEdge(3, 2); g.AddEdge(3, 4); g.AddEdge(3, 6); g.AddEdge(3, 7); g.AddEdge(3, 8);
            g.AddEdge(4, 0); g.AddEdge(4, 1); g.AddEdge(4, 2); g.AddEdge(4, 3); g.AddEdge(4, 5); g.AddEdge(4, 6); g.AddEdge(4, 7);g.AddEdge(4, 8);
            g.AddEdge(5, 0); g.AddEdge(5, 1); g.AddEdge(5, 2); g.AddEdge(5, 4); g.AddEdge(5, 6); g.AddEdge(5, 7); g.AddEdge(5, 8);
            g.AddEdge(6, 1); g.AddEdge(6, 3); g.AddEdge(6, 4); g.AddEdge(6, 5); g.AddEdge(6, 7);
            g.AddEdge(7, 0); g.AddEdge(7, 1); g.AddEdge(7, 2); g.AddEdge(7, 4); g.AddEdge(7, 7); g.AddEdge(7, 8);
            g.AddEdge(8, 1); g.AddEdge(8, 3); g.AddEdge(8, 4); g.AddEdge(8, 5); g.AddEdge(8, 7);

            g.DFS(8);
        }

    }
}
