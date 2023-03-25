// See https://aka.ms/new-console-template for more information
int[,] multiple = new int[3,4]
{
  /*0*/  {1,2,3,4},
  /*1*/   {6,7,8,9},
  /*2*/  {11,12,13,14}
};

for (int i = 0; i < multiple.GetLength(0); i++)
{
    for (int j = 0; j < multiple.GetLength(1); j++)
    {
        Console.WriteLine(multiple[i,j]);
    }
}


int [][] jaggedArray = new int [3][];
/*
 * 1,2,3
 * 1,2,3,4
 * 1,2,3,4,5,7,8
 */
for (int i = 0; i < jaggedArray.GetLength(0); i++)
{
    Console.WriteLine("enter dimension");
    int p = int.Parse(Console.ReadLine());

    jaggedArray[i] = new int[p];

    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
       int z =  int.Parse(Console.ReadLine());
       jaggedArray[i][j] = z;
    }
}

foreach (int [] subArray in jaggedArray)
{
    foreach (var element in subArray)
    {
        Console.WriteLine(element);
    }
}
