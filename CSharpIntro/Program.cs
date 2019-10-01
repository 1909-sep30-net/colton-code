using System;

namespace CSharpIntro
{
    class Program
    {
        static int Colton(){return 5;}
        static void Main(string[] args)
        {
           
            
                     
            
            //figure out how to format your document in VS Code
            //shift+alt+F
             
            //extra: learn what ''v)
            bool a = true;
            string b = "colton clary";
            int c = 27;

            if(a == true){b="colton";
            a=false;}
            else if(a==false){
                Console.WriteLine("null");
            }
            else{Console.WriteLine("else print");}

            c = 2019;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            for(int i =0; i<3;i++)
            {
                Console.WriteLine(i);
            }
            while(a == false){a = true;
            Console.WriteLine(a);}
            switch(c){
                case 27:
                    Console.WriteLine("your number is 27");
                    break;
                case 2019:
                    Console.WriteLine("your number is 2019");
                    break;
            }
/*this is how you make multi
line comments */
// extra: learn what "var" means in C# and try it out.
int y = Colton();
Console.WriteLine(y);
//compiler determines the type with var
var y2 = 6;
Console.WriteLine(y2);
        }
    }
}
