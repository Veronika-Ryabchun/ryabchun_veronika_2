using System;
using Newtonsoft.Json;

namespace Laboratorna_12
{
    class Myclass
    {
        public string First;
        public string Second;
        public Myclass()
        {
            First = "first";
            Second = "second";
        }

        public Myclass(string t, string a)
        {
            First = t;
            Second = a;
        }
        ~Myclass()
        {
            Console.WriteLine("Destructor was called");
        }
        public string Ser( )
        {
            return JsonConvert.SerializeObject(this);
        }
        static public Myclass Des(string json)
        {
            return JsonConvert.DeserializeObject<Myclass>(json);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass D = new Myclass();
            Console.WriteLine(D.First);
            Myclass B = new Myclass("A", "B");
            Console.WriteLine(B.Second);
            string js = D.Ser();
            Console.WriteLine("json: " + js);
            string json = @"{ 'First':'Tom','Second':'Jackson' }";
            Myclass F = Myclass.Des(json);
            Console.WriteLine(F.Second);
        }
    }

}
