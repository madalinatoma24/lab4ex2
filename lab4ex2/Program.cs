using System;

namespace lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 2
                Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
                k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
                - Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
                rezultatul.
                - Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
                rezultatul.
             */
            Console.WriteLine("Introduceti n: ");
            
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti m: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti k: ");
            int k = int.Parse(Console.ReadLine());
            int[,,] matrix= new int[n,m,k];

            Console.WriteLine($"Introduceti matricea:");
            for (int i=0; i< n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    for (int l = 0; l < k; l++)
                    {
                        Console.WriteLine(matrix[i, j, l] + " ");
                        matrix[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine($"Suma:{SumElements(matrix)}");
            Console.WriteLine($"Max:{GetMaxElementOfMatrix(matrix)}");
            //  ShowMatrix(matrix);

        }
        
        static int SumElements(int[,,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int k = matrix.GetLength(2);
            int result = 0;
            for (int i=0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    for (int l = 0; l < k; l++)
                    {
                        result += matrix[i, j, l];
                    }
                }
            }
            return result;
           
        }

        static int GetMaxElementOfMatrix(int[,,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int k = matrix.GetLength(2);
            int result = matrix[0,0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    for (int l = 0; l < k; l++)
                    {
                        
                        if (result < matrix[i, j, l])
                        {
                            result = matrix[i, j, l];
                        }
                    }
                }
            }
            return result;
        }

        /* static void ShowMatrix(int[,,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int k = matrix.GetLength(2);

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    for (int l = 0; l < k; l++)
                    {
                        Console.Write(matrix[i,j,l] + " ");
                       // matrix[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }

           
        }*/
    }
}
