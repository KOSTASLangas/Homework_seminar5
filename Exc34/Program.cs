// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for ( int i = 0; i < 5; i++)
    array[i] = new Random().Next (100, 1000);
Console.WriteLine( "[" + string.Join("," , array)+ "]");
int count = 0;
for ( int i = 0; i < 5; i++)
if (array[i] % 2 == 0)
count++;

Console.WriteLine("В массиве " + count +  " четных чисел" );
