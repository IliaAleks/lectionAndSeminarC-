// // Lection 1
// int Max(int arg1, int arg2, int arg3)
// {
// int result=arg1;
// if (arg2>result) result=arg2;
// if (arg3>result) result=arg3;
// return result;
// }
// int a=2;
// int b=113;
// int c=89;
// int max=Max(a, b, c);
// Console.WriteLine(max);

// int [] array= {1, 2, 4, 8, 9, 10};
// int n= array.Length;
// int find = 9;
// int index=0;
// while (index<n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//     }
//     index++;
// }

int [] array= new int[10];

void FillArray(int[] collection)

{
    int length=collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;

    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
FillArray(array);
PrintArray(array);