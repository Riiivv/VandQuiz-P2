using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            {

            //C: \Users\g12\source\repos\ConsoleApp3\ConsoleApp3
                string json = System.IO.File.ReadAllText(@"C:\Users\g12\source\repos\ConsoleApp3\ConsoleApp3\Quiz.Json");

                List<VandQuiz> desrialize = JsonConvert.DeserializeObject<List<VandQuiz>>(json);

                foreach (var eachDesrializeItem in desrialize)
                {
                    Console.WriteLine(eachDesrializeItem.Spørgsmål);

                    var i = 0;

                    foreach (var svarmulighed in eachDesrializeItem.Svarmuligheder)
                    {
                        Console.WriteLine(++i + ". " + svarmulighed);
                    }

                    Console.WriteLine("Tryk på 0 , 1 , eller 2 for at få det rigtige svar");
                    Console.WriteLine("her er et hint : " + eachDesrializeItem.hint);

                    int brugerSvar = Convert.ToInt32(Console.ReadLine());

                    checkBrugerInput(eachDesrializeItem, brugerSvar);
                }
                string serialize = JsonConvert.SerializeObject(desrialize);
                Console.WriteLine(serialize);

            }
            Console.ReadKey();
        }

        private static void checkBrugerInput(VandQuiz eachDesrializeItem, int brugerSvar)
        {
            if (brugerSvar == eachDesrializeItem.TrueAnswer)
            {
                Console.WriteLine("Det er korrekt");
            }
            else
            {
                Console.WriteLine("det er ikke korrekt");
            }
        }
    }
}

//// Dynamisnk antal spørgsmål
//for (int i = 1; i <= desrialize.Count; i++)
//{
//    desrialize[i].Spørgsmål
//    // Dynamisnk antal svar til det enkelte spørgsmål
//    for (int j = 0; j < length; j++)
//    {
//        //desrialize[i].Svarmulighed1[j]
//    }
//}