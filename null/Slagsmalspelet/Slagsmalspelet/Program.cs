string name = "";
int TravelerHP = 100;
int BossHP = 100;

Console.WriteLine("Who dares oppose me?");
name = Console.ReadLine();
Console.WriteLine($"The Boss says: Well, goodbye, {name}.");

Random generator = new Random();
while (TravelerHP > 0 && BossHP > 0)
{
   Console.WriteLine("");
   Console.WriteLine($"{name} has {TravelerHP}HP,  The boss has{BossHP}HP");

   int TravelerSlash = generator.Next(10, 25);
   BossHP -= TravelerSlash;
   BossHP = Math.Max(0, BossHP);
   Console.WriteLine($"The Traveler {name} quickly slashes the Boss doing {TravelerSlash}HP ");

   int BossSmash = generator.Next(10, 25);
   TravelerHP -= BossSmash;
   TravelerHP = Math.Max(0, TravelerHP);
   Console.WriteLine($"The Boss hastly jumped into the air and smashed the ground dealing {BossSmash}HP to {name}");

   Console.WriteLine("Already tired? [ENTER TO PROCEED]");
   Console.WriteLine("");
   Console.ReadKey();

}

if (TravelerHP == 0)
{
   Console.WriteLine($"{name} says: You call this is a Boss? Easy.");
}
else if (BossHP == 0)
{
   Console.WriteLine($"The Boss says: Its cute you, {name} thought you even had a chance.");
}
else 
{
   Console.WriteLine("Well this is dissapointing..");
}
Console.WriteLine("Press [ENTER} to close game.");
Console.ReadKey();



// --------------------------------------------- //
//Random generator = new Random();
//while (true)
{
   // int result = generator.Next(5, 15);
   // Console.WriteLine(result);

    //if (result ==0)
    //{
       // Console.WriteLine("Du får en banan");
   // }
   // if (result ==1)
   // {
        //Console.WriteLine("Du får en annan banan");
   // }

   // Console.ReadLine();
}
//int hp =5;

//if (hp > 0)
//{
   // Console.WriteLine("I'm still standing!");
   // Console.WriteLine(hp);
   // hp--;
//}
//Console.ReadLine();
