internal class Program
{
    private static void Main(string[] args)
    { 
        int M, N;
        Console.WriteLine("Nhap so tien $ ban muon chuyen do:");
        M = Convert.ToInt32(Console.ReadLine());
        // chanring to money
        N = M * 23000;

        Console.WriteLine($"So Tien ban muon chuyen tu $ sang VND la:{M}");
        Console.WriteLine($"So Tien VND la:{N}");

    }
}