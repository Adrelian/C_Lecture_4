// // Урок 4. Рекурсия и двумерные массивы


// // Создаем пустой массив
// string[,] table = new string [2, 5];                                    // массив 2 строки и 5 столбцов
// // String.Empty
// // table [0,0]  table [0,1] table[0,3] table [0,4]
// // table [1,0]  table [0,1] table[0,3] table [0,4]
// table[1,2] = "слово";                                                   // обращение к строке 1, столбцу 2

// for (int rows = 0; rows < 2; rows++)                                    // задать строки
// {
//     for (int colums = 0; colums < 5; colums++)                          // Задать столбцы       

//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

//Создаём массив с числами. Красивый вывод. После окончания внутренного цикла переходи на новую строку, что бы сделать правильный вывод
//array.GetLenghr(0) и array.GetLenghr(1) берёт числа указанные в квадратных скобках при инициадизации массива. Показывает блины строк и столбцов

// int[,] matrix = new int[3,4];                                                                //Инициализация матрицы и её размерности
// for (int i = 0; i < matrix.GetLength(0); i++)                                                // задать строки
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)                                            // Задать столбцы       

//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();                                                                         //Принудительный переход на новую строку  
// }

//Метод для печати матрицы на экран и заполнении её цифрами


// void PrintArray(int [,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)                                                 // задать строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)                                         // Задать столбцы       

//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();                                                                    //Принудительный переход на новую строку  
//     }
// }

// void FillArray(int[,] matr)
// {
//     for(int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);                                               // [1; 10) заполнение матрицы
//         }
//     }
// }


// int[,] matr = new int[3,4];                                                                     //Инициализация матрицы и её размерности

// PrintArray(matr);
// FillArray(matr);
// Console.WriteLine();
// PrintArray(matr);


// Представление чёрно-белого изображения в виде каких то значков и его закрашивание

