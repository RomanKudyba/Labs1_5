using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman_Problem {
    class CheckForUnevenVertices {
        public int[,] UnevenVertices(List<char> vertices, List<Edge> edges) {
            bool evenGraph = true;
            int[,] degVertices = new int[vertices.Count,2];
            for(int i=0; i<vertices.Count; i++) {
                degVertices[i,0] = 0;
                degVertices[i, 1] = i;   
                foreach(Edge edge in edges) {
                    if(vertices[i] == edge.vertixU || vertices[i] == edge.vertixV) {
                        degVertices[i,0]++;
                    }
                }
                if (degVertices[i,0] % 2 == 1) {
                    evenGraph = false;
                }
            }                   
            if(evenGraph == true) {
                return null;
            } else {
                return degVertices;
            }
        }
    }
}