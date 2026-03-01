namespace HelloConsole;

class Program
{
    static void Main(string[] args)
    {
        // 文字エンコーディングを明示的に設定
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("こんにちは");
    }
}