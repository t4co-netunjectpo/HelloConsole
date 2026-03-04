namespace HelloConsole;

class Program
{
    static void Main(string[] args)
    {
        // 文字エンコーディングを明示的に設定
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("こんにちは");
        Console.WriteLine("緊急対応完了！");
    }
}