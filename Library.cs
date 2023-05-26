public class Library
{
   public static string ArrayPrint1(string[] array)
    {
        string output = String.Empty;
            for(int y = 0; y < array.Length;y++)
                {
                    output += ($"{array[y],3}");
                }
                    return output;
    }

    public static string ArrayPrint2(string[] array2)
    {
        string output = String.Empty;
            for(int y = 0; y < array2.Length;y++)
                {
                    output += ($"{array2[y],3}");
                }
                    return output;
    }

    public static void Extraction(string[] array2,string[] array)
    {
        Console.Write($"[{ArrayPrint1(array)}  ] -> [");
        int number = new Random().Next(0,3);
            for(int i = number;i < array2.Length;i++)
            {
                int x = new Random().Next(0,5);
                array2[i] = array[x];
            }
                Console.Write($"{ArrayPrint2(array2)}  ]");
        
    }
}