using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class VandQuiz
    {
        public string Spørgsmål { get; set; }
        public string Svarmulighed1 { get; set; }
        public string Svarmulighed2 { get; set; }
        public string Svarmulighed3 { get; set; }
        public string hint { get; set; }
        public int TrueAnswer { get; set; } = 0;
    }
}