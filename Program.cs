using System;

namespace GuessingNumber{
    class Game{
        

        static void Main(string[] args){
            //Default turns and floor, ceiling of the game
            int _turn = 10;
            int floor = 0, ceil = 100;

            //Create random number for game
            Random r = new Random();
            int target = r.Next(0, 100);

            //Declare answer
            int ans = -1;
            Console.WriteLine("You have 10 tries. Guess wisely.");
            //Loop for checking win condition
            while (ans != target && _turn > 0){
                Console.WriteLine("Guess your number:");
                ans = Int32.Parse(Console.ReadLine());
                if(ans < 0 || ans > 100){
                    _turn--;
                    Console.WriteLine("Number should be between 0 and 100. You have " + _turn + " guesses left!");
                }
                if(ans > target && ans <= 100){
                    if(ceil > ans){
                        ceil = ans;
                    }
                    _turn--;
                    Console.WriteLine("Wrong number! Guess again, target number is between " + floor + " and " + ceil + ". You have " + _turn + " guesses left");
                }
                if(ans < target && ans >= 0){
                    if(floor < ans){
                        floor = ans;
                    }
                    _turn--;
                    Console.WriteLine("Wrong number! Guess again, target number is between " + floor + " and " + ceil + ". You have " + _turn + " guesses left");
                }
            }
            Console.WriteLine("The number is: " + target);
            if(_turn == 0){
                Console.WriteLine("You lose!! Better try next time");
            }
            else{
                Console.WriteLine("Congratulation!! You are the winner!!");
            }

        }
    }
}