using System;

namespace Jumper
{
    class ParaTrooper
    {
        //attributes
        private int MistakeCount;

        //Constructor
        public ParaTrooper()
        {
            this.MistakeCount=0;
        }

        //Methods

        public void DisplayParaBoi(bool Wrong)
        {
            if(Wrong)
            {
                this.MistakeCount+=1;
            }

            if(this.MistakeCount==0)
            {
                Console.WriteLine("""  ___""");
                Console.WriteLine(""" /___\""");
                Console.WriteLine(""" \   /""");
                Console.WriteLine("""  \ /""");
                Console.WriteLine("""   o""");
                Console.WriteLine("""  /|\""");
                Console.WriteLine("""  / \""");
                Console.WriteLine(""" """);
                Console.WriteLine("""^^^^^^^""");
            }
            else if(this.MistakeCount==1)
            {
                Console.WriteLine(""" /___\""");
                Console.WriteLine(""" \   /""");
                Console.WriteLine("""  \ /""");
                Console.WriteLine("""   o""");
                Console.WriteLine("""  /|\""");
                Console.WriteLine("""  / \""");
                Console.WriteLine(""" """);
                Console.WriteLine("""^^^^^^^""");
            }
            else if(this.MistakeCount==2)
            {
                Console.WriteLine(""" \   /""");
                Console.WriteLine("""  \ /""");
                Console.WriteLine("""   o""");
                Console.WriteLine("""  /|\""");
                Console.WriteLine("""  / \""");
                Console.WriteLine(""" """);
                Console.WriteLine("""^^^^^^^""");
            }
            else if(this.MistakeCount==3)
            {
                Console.WriteLine("""  \ /""");
                Console.WriteLine("""   o""");
                Console.WriteLine("""  /|\""");
                Console.WriteLine("""  / \""");
                Console.WriteLine(""" """);
                Console.WriteLine("""^^^^^^^""");
            }
            else if(this.MistakeCount==4)
            {
                Console.WriteLine("""*Censored*""");
                Console.WriteLine("""^^^^^^^""");
            }
        }
    }
}