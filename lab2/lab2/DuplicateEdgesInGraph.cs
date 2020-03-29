using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman_Problem {
    class DuplicateEdgesInGraph {
        public List<Edge> EdgesToDuplicate(List<Edge> edges, int[,] unevenVertices) {
            List<Edge> edgesToDuplicate = new List<Edge>();
            for (int i = 0; i < (unevenVertices.Length / 2) - 1; i++) {
                if (unevenVertices[i, 0] % 2 != 0) {
                    for (int j = i + 1; j < unevenVertices.Length / 2; j++) {
                        if (unevenVertices[j, 0] % 2 != 0) {
                            edgesToDuplicate.Add(edges.Find(edge => ToFindEdgeWhithVertices(unevenVertices[i, 1], unevenVertices[j, 1], edge)));
                        }
                    }
                }
            }
            edgesToDuplicate.RemoveAll(edge => edge == null);
            return edgesToDuplicate;
        } 
        
        private bool ToFindEdgeWhithVertices(int iu, int iv, Edge edge) {
            char u = Convert.ToChar(iu + 65);
            char v = Convert.ToChar(iv + 65);
            if ((u == edge.vertixU || u == edge.vertixV) && (v == edge.vertixU || v == edge.vertixV))
                return true;
            else
                return false;                   
        }

        public List<Edge> DuplicateEdges(List<Edge> edgesToDuplicate, int countOfUnevenVertices) {
            List<List<Edge>> sums = new List<List<Edge>>();
            for (int i = 0; i < edgesToDuplicate.Count; i++) {
                List<Edge> tempr = new List<Edge>();                     
                tempr.Add(edgesToDuplicate[i]);
                sums.Add(tempr);                
            }

            Console.WriteLine();
            int koef = 1;
            if (countOfUnevenVertices < 4) {
                koef = 2;
            }
            for (int i = 0; i < countOfUnevenVertices/2 - koef; i++) {
                List<List<Edge>> temp = new List<List<Edge>>();
                foreach (List<Edge> ed in sums) {
                    List<Edge> hyemp = ed.ToList(); 
                    for (int j = 0; j < edgesToDuplicate.Count; j++) {
                        if (!hyemp.Any(gavno => mocha(gavno, edgesToDuplicate[j]))) {
                            hyemp.Add(edgesToDuplicate[j]);
                            List<Edge> pidor = hyemp.ToList();
                            if (!konec(temp, pidor)) {                           
                                temp.Add(pidor);
                            }   
                            hyemp.Remove(edgesToDuplicate[j]);
                        }
                    }                   
                }
                sums.Clear();
                sums = temp.ToList();                 
            }

            int[] sumas = new int[sums.Count];   
            for(int i = 0; i < sums.Count; i++) { 
                sumas[i] = 0;  
                foreach(Edge tempEd in sums[i]) {
                    sumas[i] += tempEd.weight;
                    Console.Write("({0},{1})\t", tempEd.vertixU, tempEd.vertixV);
                }     
                Console.WriteLine("Total weigth of edges: {0}", sumas[i]);
            }
            Console.WriteLine();

            int index = 0;
            int min = sumas[0];
            for(int i = 0; i < sumas.Length; i++) {
                if (sumas[i] < min) {
                    min = sumas[i];
                    index = i;
                }
            }

            return sums[index];           
        }

        private bool mocha(Edge hyempove, Edge duplicatove) {
            if (hyempove.vertixU == duplicatove.vertixU || hyempove.vertixU == duplicatove.vertixV
                || hyempove.vertixV == duplicatove.vertixU || hyempove.vertixV == duplicatove.vertixV) {
                return true;
            }
            return false;
        }

        private bool konec(List<List<Edge>> haha, List<Edge> hoho) {
            foreach(List<Edge> me in haha) {
                int kaka = 0;
                if(me.Count == hoho.Count) {
                    foreach(Edge mey in hoho) {
                        if (me.Contains(mey)) {
                            kaka++;
                        }
                    }
                    if (kaka == hoho.Count)
                        return true;                  
                }
            }
            return false;
        }

    }
}
