// //55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

// Random rnd = new Random();

// int[,] Array (int row, int colomn)

// {
//     int[,] matrix = new int[row,colomn];
//     int i = 0;
//     int j = 0;
//     for (i=0; i < row; i++)
//     {
//         for (j=0; j < colomn; j++)
//         {
//             matrix[i,j] = rnd.Next(1,10);
//             Console.Write(matrix[i,j]);
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }
// Array(3,4);
// void avarage (int[,] matrix)
// {
//     int column = 1;
//     int sum = 0;
//     int count = matrix.GetLength(0);
//     int i = 0;
//     int j = 0;
//     for (i=0; i < matrix.GetLength(1); i++)
//     {
//         for (j=0; j < column; j++)
//         {
//             sum = sum + avarage[i,j];
//         }
//         Console.WriteLine (sum / count);
//     }
// }
// avarage(Array(3,4));