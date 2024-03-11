namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        //camelCase - Java
        //addStudent (Student stud) - Java
        //PascalCase - C#
        //AddStudent (Student stud) - C#
        int[] arr = { 1, 2, 7, 4 };
        Console.WriteLine("Średnia: " + AvarageVal(arr));
    }

    static int AvarageVal(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum += num;
        return sum / arr.Length;
    }
}