//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите кол-во элементов массива");
int n = Convert.ToInt32(Console.ReadLine());           
double[] array = new double[n];
for ( int i = 0; i < n; i++)
    array[i] = Convert.ToDouble(new Random().Next(-100,100) / 10.0);
Console.WriteLine( "[" + string.Join(";  " , array)+ "]");
double max = 0;
double min = 0;
for (int i = 0; i < n; i++)
if (array[i] < min)
{
min = array[i];
}
else if (array[i] > max)
{
max = array[i];
}
Console.WriteLine(max -= min);
