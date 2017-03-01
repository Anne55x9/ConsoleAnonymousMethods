using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnonymousMethods
{
    //delegaten kan pege på en metode som returnerer en int og som har en int parameter
    delegate int delInt1par(int x);
    delegate bool delBool1par(int x);

    class AnonymousMethod
    {
        static void Main(string[] args)
        {

            //kalder metoden kvadrat med værdien 2 (OBS: se metoden kvadrat længere nede i koden)
            Console.WriteLine($"Kvadrat : {kvadrat(2)}");

            //delegaten delKvadrat peger på metoden kvadrat. Smider en metode ind i min delegate.  
            delInt1par delKvadrat = kvadrat;

            delBool1par delgrtThan100 = gtrThan100;

            Console.WriteLine($"delgtrThan100 : {delgrtThan100(10)}");
            Console.WriteLine($"delgtrThan100 : {delgrtThan100(105)}");

            //kalder metoden kvadrat gennem delegaten delKvadrat
            Console.WriteLine($"delKvadrat : {delKvadrat(2)}"); 

            //anonym metode som gør det samme som kvadrat metoden 
            //og som tildeles delegaten delKvadratAnonym. Det er en anonym metode alt det til højre for = og inde i kroppen.
            delInt1par delKvadratAnonym = delegate(int x)
            {
                return x*x;
            };
            Console.WriteLine("delkvadrat : " + delKvadratAnonym (2));

            delBool1par delgrtThan100Anonym = delegate(int x)
            {
                return x > 100; 
            };

            Console.WriteLine($"delgrtThan100 : {delgrtThan100Anonym(10)}");
            Console.WriteLine($"delgrtThan100 : {delgrtThan100Anonym(105)}");
            //anonym metode skrevet via Lamda syntax og som tildeles delegaten
            //delKvadratLamda
            delInt1par delKvadratLamda = x => x*x; //x => x*x er min anonyme metode. 
            Console.WriteLine($"delKvadrat lamda : {delKvadratLamda(2)}" );

            delBool1par delgrtThan100Lambda = x => x > 100;
            Console.WriteLine($"delgrtThan100 lambde : {delgrtThan100Lambda(10)}");
            Console.WriteLine($"delgrtThan100 lambde : {delgrtThan100Lambda(105)}");


            //Istedet for at bruge min egen delegate delInt1par kan jeg bruge
            //en forud defineret delegate Func, så derfor skal jeg bruge den.
            Func<int, int> funcDelegate = x => x * x;
            Console.WriteLine($"funcDelegate: {funcDelegate(2)}");

            Func<int, bool> funcDelegateGrtThan100 = x => x > 100;
            Console.WriteLine($"funcDelegate grt than 100: {funcDelegateGrtThan100(10)}");
            Console.WriteLine($"funcDelegate grt than 100: {funcDelegateGrtThan100(105)}");


            //Her skal du selv arbejde med delegates, anonyme metoder og Lamda udtryk

            //Opgave 1: 
            // Test dine kald til metoder og delegates vha. Console.Writeline

            //-kod en delegate som kan pege på metoden "gtrThan100" :   private static bool gtrThan100(int x) 
            //-brug denne delegate og få den til at pege på metoden gtrThan100
            //-brug delegaten til at kode en anonym metode som gør det samme som metoden gtrThan100
            //-brug delegaten til at kode et lambda expression som gør det samme som  gtrThan100
            //-hvilken predefineret delagate kan du bruge istedet for din egen delegate -prøv at bruge den med et Lamda expression


            //Opgave2:
            //gør det samme som ovenstående opgave , nu bare med metoden "gange":  private static int gange(int x, int y)

            Console.ReadLine();

        }


        /// <summary>
        /// Giver kvadratet på et tal
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static int kvadrat(int x)
        {
            return x * x;
        }

        /// <summary>
        /// tester for om x er større end 100
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static bool gtrThan100(int x)
        {
            return x > 100;
        }

        /// <summary>
        /// ganger x og y sammen
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int gange(int x, int y)
        {
            return x*y;

        }


    }
}
