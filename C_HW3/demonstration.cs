using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW3
{
    public abstract class Animal
    {
        public int Weight;


        public abstract void Sound();


    }

    public class Bird: Animal
    {


        public override void Sound()
        {
            Console.WriteLine("Twitter");
        }
        
        public void Together(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Together(int a, int b, int c)
        {
            Console.WriteLine((a + b) + c);
        }

        public int CalWeight(int k)
        {
            int a = 10;
            return a * k;
        }

    }
    public class Dog
    {
        Bird bird1 = new Bird();
        Bird bird2 = new Bird();

        public void Main(string[] args) {

            bird1.CalWeight(1);


            bird2.CalWeight(2);

        }

    }

}
