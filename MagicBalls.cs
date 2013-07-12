using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magic8Ball
{
    public class MagicBalls
    {
        
        public static void main (String [] args)
        {
        int choices = 20;
        int ran; 
        Random rdm = new Random();

        ran = rdm.Next(20); 
        switch (ran % choices)
        {

            case 0:
                Console.WriteLine("It is for certain");
                break;

            case 1:
                Console.WriteLine("It is decidedly so");
                break;

            case 2:
                Console.WriteLine("W/o a doubt");
                break;
            case 3:
                Console.WriteLine("Yes definitely");
                break;
            case 4:
                Console.WriteLine("You may rely on it ");
                break;
            case 5:
                Console.WriteLine("As I see it yes");
                break;
            case 6:
                Console.WriteLine("Most likely");
                break;
            case 7:
                Console.WriteLine("Outlook good");
                break;
            case 8:
                Console.WriteLine("Yes");
                break;
            case 9:
                Console.WriteLine("Signs point to yes");
                break;
            case 10:
                Console.WriteLine("Reply hazy try again");
                break;
            case 11:
                Console.WriteLine("Ask again later");
                break;
            case 12:
                Console.WriteLine("Better not tell you now");
                break;
            case 13:
                Console.WriteLine("Cannot predict now");
                break;
            case 14:
                Console.WriteLine("Concentrate and ask again");
                break;
            case 15:
                Console.WriteLine("Don't count on it");
                break;
            case 16:
                Console.WriteLine("My reply  is no ");
                break;
            case 17:
                Console.WriteLine("My sources say no");
                break;
            case 18:
                Console.WriteLine("Outlook not so good");
                break;
            case 19:
                Console.WriteLine("Very doubtful ");
                break;
        }

    }
    }
}