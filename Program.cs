using System;
using System.Collections.Generic;

namespace JadGrp2_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
        List<int> list = new List<int>();
        
        Random diceroll = new Random();
        bool stop = false;
        
        
        int attempts = 3;
        int dice= diceroll.Next(1,6);
        
        
        int dice1 = diceroll.Next(1,6);
        int dice2 = diceroll.Next(1,6);
        
        int dice3 = diceroll.Next(1,6);
        int dice4 = diceroll.Next(1,6);
        
        {

        }
        
        while (stop == false)
         
        {
            Console.Write("How many times would you like to roll the dice ");
            Console.ReadLine();
          attempts--;
         
          list.Add(dice); 
        {
        Console.WriteLine("dice roll = "+dice);
        Console.WriteLine("dice roll = "+dice1);
        Console.WriteLine("dice roll = "+dice2);
        Console.WriteLine("dice roll = "+dice3);
        Console.WriteLine("dice roll = "+dice4);
        
        stop=(true);
        }
    
        {
            
            
            Console.WriteLine("How many to examine? ");
            Console.ReadLine();
            Console.WriteLine(dice);
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            
            
            break;
            
            int x = dice;
            int y = dice1;
            int z = dice2;
            int sum = x + y + z;
            Console.Write("These add up to ");
            Console.WriteLine(sum);
            Console.Write("The Average is ");
            Console.WriteLine(sum / 3);
      
        
                    }
                }
            }
        }
    }
