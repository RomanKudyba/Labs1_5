package com.company;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) throws FileNotFoundException {

                System.out.println(("\nВведені графи не iзоморфнi"));
                break;
            }

        int f = 0;
        int k = 0;
        while (f < m1.length && f < m1.length) {
            int s = 0;
            k++;
            for (int j = 0; j < m1.length && j < m2.length; j++)
                if (m1[f][j] != m2[f][j])
                    if (s < fact(m1.length)) {
                        boolean q = false;
                        for (int w = 0; w < mA.length; w++) {
                            for (int g = 0; g < mB.length; g++) {
                                if (mA[w] == mB[g]) {
                                    boolean t;
                                    for (int h = 0; h < 2; h++) {
                                        t = m2[h][w];
                                        m2[h][w] = m2[h][g];
                                        m2[h][g] = t;
                                    }

                                    for (int h = 0; h < 2; h++) {
                                        t = m2[w][h];
                                        m2[w][h] = m2[g][h];
                                        m2[g][h] = t;
                                    }

                                    q = true;
                                }
                                if (q) break;
                            }
                            if (q) break;
                        }
                        f = 0;
                        s++;
                        break;
                    } else {
                        System.out.println("\nГрафи не iзоморфнi");
                        break;
                    }
            f++;
            if (k > 1000) {
                System.out.println("\nГрафи не iзоморфнi");
                break;
            }
        }

        if ((f >= m1.length - 1 || f >= m2.length - 1))
            System.out.println("\nГрафи iзоморфнi");

    }

    static public void print(boolean[][] matrix) {
        for (boolean[] b : matrix) {
            for (boolean b1 : b) {
                if (b1) System.out.print(1 + " ");
                else System.out.print(0 + " ");
            }
            System.out.println();
        }
    }

    static public boolean[][] readFile(String path) throws FileNotFoundException {
        File file = new File(path);
        int numb;
        FileReader reader = new FileReader(file);
        Scanner scanner = new Scanner(reader);
        numb = Integer.valueOf(scanner.nextLine().split(" ")[0]);
        boolean matrix[][] = new boolean[4][4];
        String line;
        String array[];
        for (int i = 0; i < numb; i++) {
            line = scanner.nextLine();
            array = line.split(" ");
            for (int j = 0; j < numb; j++) {
                if (Integer.valueOf(array[j]) == 1)
                    matrix[i][j] = true;
                else matrix[i][j] = false;
            }
        }
        scanner.close();
        return matrix;}

    static public int fact(int x) {
        int y = 1;

        for (int i = 1; i < x; i++)
            y = y * i;

        return y;}

    static int[] scan(boolean[][] x) {
        int[] mX = new int[2];

        for (int j = 0; j < (2); j++) {
            int xx = 0;
            for (int i = 0; i < (2); i++)

                if (x[i][j])

                    xx++;

            mX[j] = xx;
        }
        return mX;
    }
}
