using System.Security.Cryptography.X509Certificates;

class randoms 
{
    public static void Main() 
    { 
        Random rand = new Random();
        string s = "";
        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.Clear();
        s=s+"int [] ints = { ";

        for (int i = 0; i < 300; i++) 
        { 
        
            s=s+rand.Next(64*1024).ToString()+" , ";
        
        
        }
        s=s+ " 0 }";
        Console.WriteLine(s);


    }



}

