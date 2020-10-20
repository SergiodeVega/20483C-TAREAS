using System;

namespace matrizletras
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrizLetra = genera('C');
            imprime(matrizLetra);
            Console.WriteLine("\n");
            matrizLetra = genera('O');
            imprime(matrizLetra);
        }

        static public char[,] genera(char letra)
        {
            char[,] matrizLetra = new char[7, 7];
            switch (letra)
            {
                case 'C':
                    for (int row = 0; row < 7; row++)
                    {
                        for (int column = 0; column < 7; column++)
                        {
                            matrizLetra[row, column] = (
                            ((row == 0 || row == 6) && (column > 1 && column < 6)) ||
                            ((row == 1 || row == 5) && (column == 1 || column == 6)) ||
                            ((row > 1 && row < 5) && column == 0)
                            ? '*' : ' ');
                        }
                    }
                    break;
                case 'O':
                    for (int row = 0; row < 7; row++)
                    {
                        for (int column = 0; column < 7; column++)
                        {
                            matrizLetra[row,column] = (
                            ((row == 0 || row == 6) && (column > 1 && column < 5)) ||
                            ((row == 1 || row == 5) && (column == 1 || column == 5)) ||
                            ((row > 1 && row < 5) && ((column == 0 || column == 6)))
                            ? '*' : ' ');
                        }
                    }
                    break;
            }
            return matrizLetra;
        }

        static public void imprime(char[,] matr)
        {
            for (int row = 0; row < 7; row++)
            {
                for (int column = 0; column < 7; column++)
                {
                    Console.Write(matr[row, column]);
                }
                Console.WriteLine("");
            }
        }
    }


}
