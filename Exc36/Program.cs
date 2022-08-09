// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for ( int i = 0; i < n; i++)
    array[i] = new Random().Next (0, 101);
Console.WriteLine( "[" + string.Join("," , array)+ "]");

int count = 0;
for ( int i = 1; i < n; i++)
{
    if (i % 2 != 0)
    count += array[i];    
}
Console.WriteLine(count);