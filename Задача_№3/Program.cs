// Задача №3
// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.
// 3 -> [1, 8, 27].
// 5 -> [1, 8, 27, 64, 125].
// 1) Создать метод вывода таблицы кубов списка чисел
// 2) Ввести число N и записать массив чисел от 1 до N
// 3) Применить метод и вывести таблицу кубов чисел от 1 до N
void table_cubes(int[] arg1, int arg2)
{
    double[] cube = new double[arg2];
    for(int i=0; i<arg2; i++) 
    {        
        cube[i] = Math.Pow(arg1[i], 3);       
        Console.WriteLine(cube[i]);
    }
}

Console.WriteLine("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
for(int i=0; i<N; i++)
{       
    arr[i] =1+i;
}

table_cubes(arr, N);
