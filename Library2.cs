using static Library;

public class Task
{
//Входные и выходные данные 
    public static void Result()
    {
        string[] array = {"Hello" , "dog" , ":)", "13456", "Word"};
        Console.Write($"[{ArrayPrint1(array)}  ] -> [");
        Extraction(array);
        Console.Write("]");
    }
}