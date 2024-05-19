// Random dice=  new Random();  // or Random dice=new();   -- methods in Random class are stateful and depend on data, thus need to create an instance/object before calling methods. (Random is class Random.Next() is method)
// int roll=dice.Next(1,7);

// Console.WriteLine(roll); // Console.WriteLine() is stateless method --doesnt depend on any data (Console is class WriteLine() is method)

// Random dice=new Random();
// int roll1=dice.Next();
// int roll2=dice.Next(101);
// int roll3=dice.Next(50,101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue  =500;
// int secondValue =600;
// int largerValue=System.Math.Max(firstValue,secondValue);

// Console.WriteLine(largerValue);



// Random dice = new Random();
// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll:{roll1}+{roll2}+{roll3}={total}");

// // string message="The quick brown fox jumps over the lazy dog.";

// // bool result=message.Contains("dog");
// // Console.WriteLine(result);

// // if(message.Contains("fox"))
// // {
// //     Console.WriteLine("What does the fox say?");
// // }

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
//     Console.WriteLine($"Your total including bonus: {total}");
// }


// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten");
// }


// using System.Runtime.InteropServices;

// Random random = new Random();

// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if(daysUntilExpiration==0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// if(daysUntilExpiration==1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage=20;
// }
// else if(daysUntilExpiration<=5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage=10;
// }
// else if (daysUntilExpiration >=10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if(discountPercentage>0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }
/*
string[] fraudlentOrderIDs= new string[3];

fraudlentOrderIDs[0]="A123";
fraudlentOrderIDs[1]="B456";
fraudlentOrderIDs[2]="C789";
*/

// string[] fraudlentOrderIDs= {"A123","B456","C789"};
// // fraudlentOrderIDs[3]="D000";

// Console.WriteLine($"First: {fraudlentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudlentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudlentOrderIDs[2]}");

// fraudlentOrderIDs[0]="F000";
// Console.WriteLine($"Reassign First: {fraudlentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudlentOrderIDs.Length} fraudlent orders to process.");

// string[] names={"Rowena", "Robin","Bao"};

// foreach(string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory={200,450,700,175,250};
// int sum=0;
// int bin=0;
// foreach(int item in inventory)
// {
//     sum+=item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in the inventory.");

// string[] fraudlentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string id in fraudlentOrderIDs)
// {
//     if (id.StartsWith("B"))
//     {
//         // Console.WriteLine("The name starts with 'B'!");
//         Console.WriteLine(id);
//     }
// }

// string firstName="Bob";
// int widgetsPurchased=7;
// //Testing change to message
// // int widgetsSold=7;
// // Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

// 

/*
    The following code generates five random OrderIDs
    to test the fraud detection process. OrderIDs
    consist of letters from A to E, and a three 
    digit number. Ex. A123
*/

// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

/*
    The following code reverses a string and
    prints it along with printing the number 
    of o's in the string. 
*/

string originalMessage="The quick brown fox jumps over the lazy dog.";

char[] message=originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount=0;

foreach(char letter in message)
{
    if(letter=='o')
    {
        letterCount++;
    }
}

string new_message= new String(message);
Console.WriteLine(new_message);

Console.WriteLine($"'o' appears {letterCount} times.");

