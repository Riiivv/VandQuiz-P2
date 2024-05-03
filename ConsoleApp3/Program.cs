using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace ConsoleApp3
{
    internal class Program
    {
        public class vandQuiz
        {
            public string Spørgsmål { get; set; }
            public string Svarmulighed1 { get; set; }
            public string Svarmulighed2 { get; set; }
            public string Svarmulighed3 { get; set; }
        }

        static void Main(string[] args)
        {
            {


                string json = System.IO.File.ReadAllText(@"C:\Users\g12\Desktop\Quiz.Json");

                List<vandQuiz> desrialize = JsonConvert.DeserializeObject<List<vandQuiz>>(json);

                foreach (var eachDesrializeItem in desrialize)
                {
                    Console.WriteLine(eachDesrializeItem.Spørgsmål);
                    Console.WriteLine(eachDesrializeItem.Svarmulighed1);
                    Console.WriteLine(eachDesrializeItem.Svarmulighed2);
                    Console.WriteLine(eachDesrializeItem.Svarmulighed3);
                }

                //foreach (var spørgsmål in desrialize.Spørgsmål)
                //{
                //    Console.WriteLine("spørgsmål: " + spørgsmål);
                //}

                string serialize = JsonConvert.SerializeObject(desrialize);
                Console.WriteLine(serialize);

            }
            Console.ReadKey();
        }
    }
}
