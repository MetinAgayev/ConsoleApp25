using System;

namespace ClassLibrary1
{
    public class Calculator
    {
      
        public void Toplama(int a,int b)
        {            
            Console.WriteLine(a+b);
        }
        public void Cixma(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public void Vurma(int a,int b)
        {
            Console.WriteLine(a*b);
        }
        public void Bolme(int a,int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
