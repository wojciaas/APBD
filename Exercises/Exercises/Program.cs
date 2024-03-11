namespace Exercises;

class Program
{
    static void Main(string[] args)
    {
        //camelCase - Java
        //addStudent (Student stud) - Java
        //PascalCase - C#
        //AddStudent (Student stud) - C#
        Console.WriteLine("Hello, World!");
    }

    int AvarageVal(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
            sum += num;
        return sum / arr.Length;
    }
}