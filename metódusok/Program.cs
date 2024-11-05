namespace metódusok
{
	internal class Program
	{
		static void Main(string[] args)
		{

			koszonto();
            Console.WriteLine(Osszeadas(10,5));
			int a = 5;
            Console.WriteLine(Dublaz(a));
			int duplazott=Dublaz(a);
            Console.WriteLine(a);
            Console.WriteLine(duplazott);
			Console.WriteLine(Osszeg(10));
            
			int elso = 5;
			int masodik = 10;
			Csere(ref elso,ref masodik);
			Console.WriteLine(elso+" " + masodik);


			string szoveg = "kaki,kaki";
			int darab = SzovegElofordulas(szoveg, "kaki");
			Console.WriteLine($"Hányszor szerepel kaki a szövegben:{darab}");

			Console.ReadLine();
		}



		static int SzovegElofordulas(string szoveg, string alSzoveg)
		{
			int szam = 0;
			int index= szoveg.IndexOf(alSzoveg);
			while (index!= -1){
				szam++;
				index=szoveg.IndexOf(alSzoveg, index+1);
			}
			return szam;
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

		static int Dublaz(int szam)
		{
			return szam*2;
		}

		static string Dublaz()
		{
			return a;
        }

		static int Dublaz(int a, int b)
		{
			return a+b;
		}
		static int Osszeg(int a , int b=5, int c=2)
		{
			return a + b+c; 
		}

		static void Csere(ref int a,ref int b)
		{
			int temp = a;
			a=b; 
			b=temp;
			Console.WriteLine(a + " " + b);

		}
	}
}
