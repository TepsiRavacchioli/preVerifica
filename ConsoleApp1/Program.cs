namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valori = { 19, 44, 38, 15, 40 };
            int iMin = 0;
            for (int i = 0; i <= valori.Length - 1; i++)
            {
                for (int j = 0; j <= valori.Length - 1; j++)
                {
                    if (valori[i] < valori[j])
                    {
                        iMin = valori[j];
                        valori[j] = valori[i];
                        valori[i] = iMin;
                    }
                }
            }
            foreach (int a in valori)
                Console.WriteLine($"sort 1 valori ordinati:/n{a}");
        }
    }
}