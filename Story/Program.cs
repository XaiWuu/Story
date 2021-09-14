using System;
using System.Threading;


Console.WriteLine("Whats your name?");

string name; 

name = Console.ReadLine();

Console.WriteLine($"Welcome {name} we have been waiting for you!");

Thread.Sleep(1700); 

Console.WriteLine($"Do you accept the challange thats wating for you?");


string answer;
answer = Console.ReadLine();

answer = answer.ToLower();

if (answer == "yes")
{
    Console.WriteLine($"Good you will recive a price after the challange!");
}
else if (answer == "no")
{
    Console.WriteLine($"Sorry its to late to back out now!");
}
else
{
    Console.WriteLine($"I dont care you must do this!!!");
}

Thread.Sleep(1700); 

Console.WriteLine($"Now can you go, choose the direction: right or left");

answer = Console.ReadLine();

if (answer == "right")
{
    Console.WriteLine($"On the right there is a samurai you have to beat...");
}
else if (answer == "left")
{
    Console.WriteLine($"On the left there is a monster that only eat beautiful humans so you dont have to worry about him");
}
else
{
    Console.WriteLine($"Because you didnt choose you have to go right now!!!");
}

answer = Console.ReadLine();


Console.ReadLine();

