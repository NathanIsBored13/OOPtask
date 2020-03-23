using System;

namespace OOPtask
{
    class Program
    {
        class Animal
        {
            private string state;
            private int size;
            public Animal(string s, int n)
            {
                state = s;
                size = n;
            }

            public void feed()
            {
                size++;
                Console.WriteLine("Fish fed");
                if (size == 5)
                {
                    state = "FISH";
                }
            }

            public int getSize() => size;

            public string getState() => state;
        }
        static void Main(string[] args)
        {
            Animal thisFish = new Animal("Fish", 1);
            Console.WriteLine($"{thisFish.getState()} is the size {thisFish.getSize()}");
            while(thisFish.getState() != "FISH")
            {
                thisFish.feed();
            }
            Console.WriteLine($"It is now a big {thisFish.getState()}");
        }
    }
}
