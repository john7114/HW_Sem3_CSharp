// Задача №2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Алгоритм:
// 1. Создать метод для вычисления расстояния между точками в 3D пространстве
// 2. Ввести координаты точек А и В и записать их в виде массива
// 3. Применить ранее созданный метод и вывести результат на экран
void distance_3D(int[] arg_A, int[] arg_B)
{
    double d = Math.Sqrt(Math.Pow((arg_B[0] - arg_A[0]), 2) + Math.Pow((arg_B[1] - arg_A[1]), 2) + Math.Pow((arg_B[2] - arg_A[2]), 2));       
    Console.WriteLine(d);        
}

Console.WriteLine("Введите координаты (в порядке x y z) точки A, через пробел: "); 
string coorA = Console.ReadLine();
string[] P_A = coorA.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int size_A = P_A.Length;
int[] point_A = new int[size_A];
for (int i = 0; i < size_A; i++) 
{ 
    point_A[i] = Convert.ToInt32(P_A[i]); 
}

Console.WriteLine("Введите координаты (в порядке x y z) точки B, через пробел: ");
string coorB = Console.ReadLine();
string[] P_B = coorB.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

int size_B = P_B.Length;
int[] point_B = new int[size_B];
for (int i = 0; i < size_B; i++) 
{
    point_B[i] = Convert.ToInt32(P_B[i]); 
}

distance_3D(point_A, point_B);