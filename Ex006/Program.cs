namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            Console.Write("Digite a primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("Média: {0}", media);
        }
    }
}
