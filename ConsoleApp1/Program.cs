namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quale vuoi che sia la lunghezza dell'array?");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            int[] valori = new int[lunghezza];
           
            Console.WriteLine("inserisci "+ lunghezza + "     valori interi");
            for (int i = 0;i< lunghezza; i++)
                valori[i] = Int32.Parse(Console.ReadLine());

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
            Console.WriteLine("I valori inseriti, ordinati in modo crescente sono:");
            foreach (int a in valori)
                Console.Write($"{a} ");
        }
    }
}