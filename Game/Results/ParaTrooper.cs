using System;

namespace Jumper
{
    class ParaTrooper
    {
        //attributes
        public int mistakeCount;

        //Constructor
        public ParaTrooper()
        {
            this.mistakeCount = 0;
        }

        //Methods
        public void DisplayParaBoi()
        {

            if(this.mistakeCount==0)
            {
                Console.WriteLine();
                Console.WriteLine("  ___");
                Console.WriteLine(@" /___\");
                Console.WriteLine(@" \   /");
                Console.WriteLine(@"  \ /");
                Console.WriteLine("   o");
                Console.WriteLine(@"  /|\");
                Console.WriteLine(@"  / \");
                Console.WriteLine(" ");
                Console.WriteLine("^^^^^^^");
            }
            else if(this.mistakeCount == 1)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(@" /___\");
                Console.WriteLine(@" \   /");
                Console.WriteLine(@"  \ /");
                Console.WriteLine(@"   o");
                Console.WriteLine(@"  /|\");
                Console.WriteLine(@"  / \");
                Console.WriteLine(" ");
                Console.WriteLine("^^^^^^^");
            }
            else if(this.mistakeCount == 2)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(@" \   /");
                Console.WriteLine(@"  \ /");
                Console.WriteLine("   o");
                Console.WriteLine(@"  /|\");
                Console.WriteLine(@"  / \");
                Console.WriteLine(" ");
                Console.WriteLine("^^^^^^^");
            }
            else if(this.mistakeCount == 3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(@"  \ /");
                Console.WriteLine("   o");
                Console.WriteLine(@"  /|\");
                Console.WriteLine(@"  / \");
                Console.WriteLine(" ");
                Console.WriteLine("^^^^^^^");
            }
            else if(this.mistakeCount == 4)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("   x");
                Console.WriteLine(@"  /|\");
                Console.WriteLine(@"  / \");
                Console.WriteLine("^^^^^^^");
            }
        }
    }
}