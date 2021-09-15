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
    Console.WriteLine($"On the left there is a monster that has a huge A*S");
}
else
{
    Console.WriteLine($"Because you didnt choose, you have to go right now!!!");
}

Thread.Sleep(1700); 

Console.WriteLine($"Now choose your weapon");

Thread.Sleep(1700); 

Console.WriteLine($"Do you want a sword, axe or selfcontrollingweapon?");

answer = Console.ReadLine();

if (answer == "sword")
{
    Console.WriteLine($"Good choice, you are real fighter");
}
else if (answer == "axe")
{
    Console.WriteLine($"I see you are a strong human, you are a godly warior");
}
else if (answer == "selfcontrollingweapon")
{
    Console.WriteLine($"Daymn you are a real f*cking p*ssy");
}
else
{
    Console.WriteLine($"Ok because you didnt choose you get a banana");
}

Thread.Sleep(1000);

Console.WriteLine($"Now you will fight him!!!");

Thread.Sleep(1000);

Console.WriteLine($"Choose your attack");

Thread.Sleep(1000);

Console.WriteLine($"Punch or throw your weapon");

answer = Console.ReadLine();

if (answer == "punch")
{
    Console.WriteLine($"You beat him good job!!!");
    Thread.Sleep(1000);
    Console.WriteLine($"You Win, good job!!!");
}
else if (answer == "throw")
{
    Console.WriteLine($"Damn you really are a p*ssy");
    Thread.Sleep(1000);
    Console.WriteLine($"You Loose, you suck!!!");
}
else
{
    Console.WriteLine($"Because you didnt attack you died like a B*TCH!!!");    
}

Console.ReadLine();
