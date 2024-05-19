// Console.WriteLine("a" =="a");
// Console.WriteLine("a"=="A");
// Console.WriteLine(1==2);
// string myValue="a";

// Console.WriteLine(myValue=="a");

// Console.WriteLine("a"=="a ");

// string value1=" a";
// string value2="A ";

// Console.WriteLine(value1.Trim().ToLower()==value2.Trim().ToLower());    

// Console.WriteLine(1>2);
// Console.WriteLine(1<2);
// Console.WriteLine(1>=1);
// Console.WriteLine(1<=1);

// string pangram="The quick brown fox jumps over the lazy dog.";

// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

// string s1="hello";
// string s2="hello";

// Console.WriteLine(s1!=s2);


// using System.Data.Common;

// int salesAmount = 1001;
// // int discount = salesAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount:{(salesAmount > 1000 ? 100 : 50)}");


// Random random = new Random();

// int flip = random.Next(0, 2);

// Console.WriteLine(flip == 0 ? "heads" : "tails");

// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin"))
// {
//     Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag=true;
// int value=0;
// if(flag)
// {
//     value=10;
//     Console.WriteLine($"Inside the code block: {value}");
// }
// Console.WriteLine($"Outside the code block: {value}");

// bool flag = true;
// if (flag) Console.WriteLine(flag);

// string name="steve";

// if(name=="bob") 
//     Console.WriteLine("Found Bob");
// else if(name=="steve") 
//     Console.WriteLine("Found Steve");
// else 
//     Console.WriteLine("Found Chuck");

// int[] numbers={4,8,15,16,23,42};
// int total=0;
// bool found=false;

// foreach(int number in numbers)
// {
//     total+=number;
//     if(number==42)
//         found=true;
// }

// if(found)
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

// string fruit="";

// switch(fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display info for apple.");
//         break;
//     case "banana":
//         Console.WriteLine($"App will display info for banana.");
//         break;
//     case "cherry":
//         Console.WriteLine($"App will display info for cherry.");
//         break;

// }

// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         // title = "Junior Associate";
//         // break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color="White";
//         break;
// }


// switch(product[2])
// {
//     case "S":
//         size="Small";
//         break;
//     case "M":
//         size="Medium";
//         break;
//     case "L":
//         size="Large";
//         break;
//     default:
//         size="One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for(int i=0;i<10;i++)
// {
//     Console.WriteLine(i);
// }

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }

// for(int i=0;i<10;i+=3)
// {
//     Console.WriteLine(i);
// }

// for(int i=0;i<10;i++)
// {
//     Console.WriteLine(i);
//     if(i==7) break;
// }

// string[] names={"Alex", "Eddie","David","Michael"};

// for(int i=names.Length-1;i>=0;i--)
// {
//     Console.WriteLine(names[i]);
// }

// string[] names={"Alex", "Eddie","David","Michael"};

// for(int i=0;i<names.Length;i++)
// {
//     if(names[i]=="David")
//         names[i]="Sammy";
// }

// foreach(string name in names)
//     Console.WriteLine(name);

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - FizzBuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} - Fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} - Buzz");
//     }
//     else
//     {
//         Console.WriteLine($"{i}");
//     }
// }

// Random random = new Random();
// int  current=random.Next(1,11);

// do{
//     current=random.Next(1,11);
//     Console.WriteLine(current);
// }while(current!=7);

// while(current>=3)
// {
//     Console.WriteLine(current);
//     current=random.Next(1,11);
// }

// Console.WriteLine($"Last Number: {current}");

// do
// {
//     current=random.Next(1,11);
//     if(current>=8)  continue;

//     Console.WriteLine(current);

// }while(current!=7);

// Random random=new Random();

// int heroHealth=10;
// int monsterHealth=10;

// do
// {
//     int roll=random.Next(1,11);
//     monsterHealth-=roll;
//     Console.WriteLine($"Monster health was damaged and lost {roll} health and now has {monsterHealth} health.");

//     if(monsterHealth<=0) continue;

//     roll=random.Next(1,11);
//     heroHealth-=roll;
//     Console.WriteLine($"Hero health was damaged and lost {roll} health and now has {heroHealth} health.");

// }while(heroHealth>0 && monsterHealth>0);

// Console.WriteLine(heroHealth<=0? "Monster Wins!": "Hero Wins!");

// string? readResult;

// Console.WriteLine("Enter a string:");

// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

// string? readResult;
// Console.WriteLine("Enter a string containing atleast three characters:");

// bool validEntry = false;

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }

// } while (validEntry == false);

// int numericValue=0;
// bool validNumber=false;

// validNumber=int.TryParse(readResult, out numericValue);  //checks if readResult can be parsed into an integer eg. "7", if yes returns True else returns 0 (value of 'numericValue')

// Console.WriteLine("Eenter an interger between 5 and 10");
// string? readResult;
// bool validEntry = false;
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         int numericValue = 0;
//         validEntry = int.TryParse(readResult, out numericValue);

//         if (validEntry)
//         {
//             int readNumber = int.Parse(readResult);
//             if (readNumber >= 5 && readNumber <= 10)
//             {
//                 Console.WriteLine($"Your input value {readNumber} has been accepted.");
//                 break;
//             }
//             else
//             {
//                 validEntry = false;
//             }
//         }

//         if (!validEntry)
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }


// } while (validEntry == false);




// string? readResult;
// bool validEntry=false;

// do
// {
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if(readResult!= null)
//     {
//         string cpy=readResult;
//         readResult = readResult.Trim().ToLower();
//         if(readResult=="administrator" || readResult=="manager" || readResult=="user")
//         {
//             validEntry=true;
//             Console.WriteLine($"Your input value ({cpy}) has been accepted."); 
//         }
//         else
//         {
//             Console.WriteLine($"The role name that you entered, \"{cpy}\" is not valid.");
//         }
//     }
// }while(validEntry==false);




// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

// int periodLocation;
// foreach (string str in myStrings)
// {
//     periodLocation = str.IndexOf('.');
//     if (periodLocation != -1)
//     {
//         string subStr = str;
//         do
//         {
//             Console.WriteLine(subStr.Substring(0, periodLocation));
//             subStr = subStr.Remove(0, periodLocation + 1).Trim();
//             periodLocation = subStr.IndexOf('.');

//         } while (periodLocation != -1);

//         Console.WriteLine(subStr);
//     }
//     else
//     {
//         Console.WriteLine(str);
//     }
// }

