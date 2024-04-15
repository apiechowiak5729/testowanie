namespace Sortowanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[20];
            Random A = new Random();
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = A.Next(1, 40);
                Console.Write($"{tablica[i]}" + " ");
            }

            int n;

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica.Length - 1; j++)
                {
                    if (tablica[j] > tablica[j + 1])
                    {
                        n = tablica[j + 1];
                        tablica[j + 1] = tablica[j];
                        tablica[j] = n;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("posortowane");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }
        }
    }
}
