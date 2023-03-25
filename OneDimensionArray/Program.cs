// See https://aka.ms/new-console-template for more information

/*           0  1  2  3   4 5
 array arr= {1,20,30,343,24,1}   ---> stack   heap
                arr[1]
                                        arr---->[1,20...]*/

Console.WriteLine("Enter number in array:");
int x = int.Parse(Console.ReadLine());

//int[] arr = { 1, 2, 3, 4, 5, 6 };

int[] arr = new int[x];

Console.WriteLine("before filling array");
for (int i = 0; i < x; i++)
{
    Console.Write($"{arr[i]} ");
}

for (int i = 0; i < x; i++)
{
    Console.WriteLine($"Enter {i}th element:");
    int k = int.Parse(Console.ReadLine());
    arr[i] = k;
}

Console.WriteLine("after filling array");
for (int i = 0; i < x; i++)
{
    Console.Write($"{arr[i]} ");
}

foreach (int el in arr)
{
    Console.Write($"{el} ");
}

