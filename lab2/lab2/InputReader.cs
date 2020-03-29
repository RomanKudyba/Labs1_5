using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postman_Problem {
    class InputReader {
        public int[,] InputedData(int n, StreamReader file) {
            int[,] inputedData = new int[n,n]; 
            for(int i = 0; i < n; i++) {
                string[] temp = file.ReadLine().Split(' ');      
                for(int j = 0; j < n; j++) {
                    inputedData[i, j] = Convert.ToInt32(temp[j]);
                }                
            }
            return inputedData;
        }
    }
}
