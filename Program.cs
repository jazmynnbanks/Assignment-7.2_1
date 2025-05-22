//Implement shell sort on an unsorted array of numbers. Take the array input from user.

Console.Write("Please enter number 1: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 4: ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Number 5: ");
int num5 = Convert.ToInt32(Console.ReadLine());

int [] myArray = {num1, num2,num3,num4,num5};

int n = myArray.Length;
int gap = n / 2;

while (gap > 0)
{
    for (int i = gap; i < n; i++)
    {
        int temp = myArray[i];
        int j = i;

        while (j >= gap && myArray[j-gap] > temp)
        {
            myArray[j] = myArray[j-gap];
            j = j - gap;
        }
        myArray[j] = temp;
    }
    gap = gap/2; //This reduces the gap each loop
}

Console.WriteLine("Sorted Array: ");
foreach (int i in myArray)
{
    Console.Write(i + " ");
}

Console.ReadKey();