namespace metódusok
{
	internal class Program
	{
		static void Main(string[] args)
		{

			koszonto();
            Console.WriteLine(Osszeadas(10,5));
			Console.ReadLine();
		}

		static void koszonto()
		{
			Console.WriteLine("hello világ");
			
		}

		static int Osszeadas(int a, int b)
		{
			/*int osszeg = a + b;
			return osszeg;*/
			return a + b;
		}
	}
}
