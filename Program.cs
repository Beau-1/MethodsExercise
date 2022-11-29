


//------------+ Exercise 1 +------------

//Name: 
//Favorite color
//favorite animal
//Favorite band

using System.Threading.Channels;

Console.WriteLine("Salutations, and welcome to the Happy Hedghog Inn! What is your name traveler?");
var userName = Console.ReadLine();

Console.WriteLine($"{userName}, is it? Never heard that one befor. All the same come in from the rain and warm yourself by the fire." +
    $"Here in my inn I provide custom rooms of any size, description and color. Do you have a color preferance for your room?");
var color = Console.ReadLine();

Console.WriteLine($"{color}! Ah, thats one of my favorites too. Nice choice. Additionaly we also offer a choice of emotional support animals for our guests." +
    $" We really have all sorts so go ahead and pick your favorite.");
var animal  = Console.ReadLine();

Console.WriteLine($"You picked a/an {animal} huh? Well lucky for you we have one of those. His name is Bingly, and he's happy to see you." +
    $" Finally we offer our guests a musical prefferance, however times being what they are, you can only pick one band to listen to. Who would you like to hear?");
var bandName = Console.ReadLine();

// Now for the story 

Console.WriteLine($"As you make your way upstairs to find your room you meet Chester the emotional support {animal} waiting for you in the hall." +
    $" He greets you kindly and leads you to your {color} room. Inside you hear {bandName}'s music playng." +
    $" You start to relax for the evening and begin to write a great reviw of The Happy Hedghog Inn on Yelp.");