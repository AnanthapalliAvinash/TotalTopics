using System;

namespace Generics
{
    //public delegate G Generics<G>(G a,G b);
    class Test<test>
    {

    }
    class Generic<generic>
    {

        //public G MyProprty { get; set; }
        public bool Compare<G>(G s,G s1)
        {
           if(s.Equals(s1))
            
                return true;
               return false;           
        }
       
    }
    class Program
    {        
        static void Main(string[] args)
        {
            Test<int> t = new Test<int>();
            //Generic g1 = new Generic();
            Generic<String> g2 = new Generic<String>();
            Generic<float> g3 = new Generic<float>();
            Generic<double> g4 = new Generic<double>();
            //Console.WriteLine(g1.Compare(10,10));
            Console.WriteLine(g2.Compare("Hello","Hii"));
            Console.WriteLine(g3.Compare(10.3f,6.5f));
            Console.WriteLine(g4.Compare(3.42455678436384573,5.45544554545));

        }
    }
}
