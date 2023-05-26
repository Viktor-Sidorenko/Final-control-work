using static Library;

public class Task
{
//Входные данные 
    public static void Result()
    {
        string[] array = {"a" , "b" , ":)", "1", "e"};
        string[] array2 = new string[3];
        int m = new Random().Next(0,5);
        Extraction(array2,array);
    }
}