using codilityTests;
using System;
using System.Diagnostics;
using System.Text;

//Choose lesson
var UI = new Test2();

//set inputs
int inputX = 10, inputY = 1000000000, inputD = 150;
int input = 0;
int max = 2;
int min = 1;
int number = 100;
int[] arrInput = [1, 1000, 80, -91];//[23171, 21011, 21123, 21366, 21013, 21367];//createArray(min, max, number); //[1, 2, 3, 1, 3, 4, 6];//[1,2];//
int[] arrInput2 = [0, 0, 0, 0, 0];
string stringInput = "BILLO,NULL,BILL\nOLLO,BBI";
string[] stringArrInput = ["BILL", "BOB"];

//Init timer to messure code efficiency
var timer = new Stopwatch();

timer.Start();
string output = UI.Solution3(stringInput);
timer.Stop();
TimeSpan elapsed = timer.Elapsed;

//foreach (int i in output)
//{
//    Console.Write(i + ", ");
//}
Console.WriteLine("answer: " + output + "\nTime: " + elapsed.Milliseconds);

#region utilities
string GetIntArrAsString(int min, int max, int lenght)
{
    int[] arr = CreateArray(min, max, number);
    var str = new StringBuilder();
    str.Append('[');
    foreach (int i in arr)
        str.Append(i).Append(',');

    str.Length = str.Length - 1;
    str.Append(']');

    return str.ToString();
}



int[] CreateMissingNumberArray(int N, int missing)
{
    int[] arr = new int[N];
    var random = new Random();
    int currentNumber = 1;

    for(int i = 0; i < missing - 1; i++)
    {
        arr[i] = currentNumber++;
    }
    currentNumber++;
    for(int i = missing - 1; i < N; i++)
    {
        arr[i] = currentNumber++;
    }

    random.Shuffle(arr);
    return arr;
}

int[] CreateArray(int min, int max, int N)
{
    var random = new Random();
    int[] arr = new int[N];

    for(int i = 0; i < N; ++i)
    {
        arr[i] = random.Next(min, max);
    }

    return arr;
}

int[] CreateArrayOfPairs(int min, int max, int N)
{
    var random = new Random();
    int[] arr = new int[N];

    for (int i = 0; i < N; ++i)
    {
        arr[i] = random.Next(min, max);
    }

    return arr;
}
#endregion