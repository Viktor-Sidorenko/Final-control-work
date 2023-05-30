public class Library
{
//Создание массива
   public static string ArrayPrint1(string[] array)
    {
        string output = String.Empty;
            for(int y = 0; y < array.Length;y++)
                {
                    output += ($"{array[y],7}");
                }
                    return output;
    }
    
//Решение задачи
    public static void Extraction(string[] array)
    {
        int count;
        for(int i = 0;i < array.Length;i++)
            {
                count = array[i].Length;
                if(count <= 3)
                {
                    Console.Write($"{array[i],3}");
                }     
            }   
    }
}