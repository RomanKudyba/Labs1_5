using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman_Problem {
    class EulerCycle {        
        public void EulerProcess(char verticeStart, List<char> verticesParam, List<Edge> edgesParam) {
            List<char> vertices = verticesParam.ToList();
            List<Edge> edges = edgesParam.ToList();
            Stack<char> path = new Stack<char>();
            Console.Write("\n");
            char w;
         

            path.Push(verticeStart);
            while (path.Count != 0) {
                w = path.Peek();
                foreach(char u in vertices) {
                    if (edges.Find(edge => ToFindEdgeWhithVertices(w, u, edge)) != null) {
                        path.Push(u);
                        edges.Remove(edgesParam.Find(edge => ToFindEdgeWhithVertices(w, u, edge)));
                        break;
                    }
                }
                if(w == path.Peek()) {
                    path.Pop();
                    Console.Write("({0})", w);
                    if(path.Count != 0) {
                        Console.Write("->");
                    }
                }
            }                         
        }  

        private bool ToFindEdgeWhithVertices(char u, char v, Edge edge) {
            if ((u == edge.vertixU && v == edge.vertixV) || (u == edge.vertixV && v == edge.vertixU))
                return true;
            else
                return false;
        }
    }
}
