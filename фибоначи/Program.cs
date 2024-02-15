
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи:");
        int n = int.Parse(Console.ReadLine());
        List<int> fibonacci = фибоначи.Fibonacci<int>.GenerateFibonacci(n);
        foreach (var i in fibonacci)
        {
            Console.WriteLine(i + " ");
        }
    }
}



















/*internal class Program
{
    private static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Console.WriteLine("F1) 1");
        Console.WriteLine("F2) 1");

        int n_1 = 1;
        int n_2 = 1;

        static dynamic fiba<T>(T n)
        {
        return fiba(n);
        }
        for (int i = 3; i <= n; ++i)
        {
            var n_3 = n_1 + n_2;
            Console.WriteLine("F{0}) {1}", i, n_3);
            n_1 = n_2;
            n_2 = n_3;
        }
        Console.ReadKey();
    }
}
*/