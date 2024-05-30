namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lunghezza = 0; 
            
            try{
                Console.WriteLine("Quale vuoi cche sia la lunghezza dell'array?");
                lunghezza = Convert.ToInt32(Console.ReadLine());
                
            }catch(Exception ex){
                Console.WriteLine("ERRORE "+ex);
            }
            

            int[] valori = new int[lunghezza];
           if(lunghezza>0){
            Console.WriteLine("inserisci "+ lunghezza + " valori interi");
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
}
