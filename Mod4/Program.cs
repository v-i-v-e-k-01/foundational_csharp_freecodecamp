// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");



// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");



// Console.WriteLine("");
// Console.WriteLine("Floating point types:");

// Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int[] data = new int[3];

// string shortenedString = "Hello World!";
// Console.WriteLine(shortenedString);

// int val_A = 2;
// int val_B = val_A;
// val_B = 5;

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

// int[] ref_A = new int[1];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");


// int first=2;
// string second="4";
// string result=first+second;
// Console.WriteLine(result);

// int myInt=3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal=myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal=3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt=(int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal=1.23456789m;
// float myFloat=(float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

// using Microsoft.VisualBasic;
// int first=5;
// int second=7;
// string message=first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first="5";
// string second="7"; 
// int sum=int.Parse(first) + int.Parse(second);

// Console.WriteLine(sum);

// string value1="5";
// string value2="7";
// int result= Convert.ToInt32(value1) + Convert.ToInt32(value2);

// Console.WriteLine(result);


// int value=(int)1.5m;
// Console.WriteLine(value);

// int value2=Convert.ToInt32(1.5m);
// Console.WriteLine(value2);



// string name="Bob";
// Console.WriteLine(int.Parse(name));

// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/offset): {50 + result}");
// }

// string[] values={"12.3","45","ABC","11","DEF"};
// string message="";
// decimal total=0m;
// decimal tempNum;

// for(int i=0;i<values.Length;i++)
// {
//     if(decimal.TryParse(values[i],out tempNum))
//     {
//         total+=tempNum;
//     }
//     else 
//     {
//         message+=values[i];
//     }
// }

// Console.WriteLine(message);
// Console.WriteLine(total);   

// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// int result1=Convert.ToInt32(value1/value2);

// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2=value2/(decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3=value3/value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// string[] pallets={"B14","A11","B12","A13"};

// Console.WriteLine("Sorted...");

// Array.Sort(pallets);

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");

// Array.Reverse(pallets);

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// string[] pallets={"B14","A11","B12","A13"};
// Console.WriteLine("");

// // Console.WriteLine($"Before: {pallets[0].ToLower()}");

// Array.Clear(pallets,0,2);

// // if(pallets[0]!=null)
// // {
// //     Console.WriteLine($"After: {pallets[0].ToLower()}");
// // }

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");

// Array.Resize(ref pallets,6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4]="C01";
// pallets[5]="C05";

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets,3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// string value="abc123";

// char[] valueArray=value.ToCharArray();

// // foreach(var val in valueArray)
// // {
// //     Console.WriteLine(val);
// // }

// Array.Reverse(valueArray);

// // string result=new string(valueArray);

// string result=string.Join(",",valueArray);

// Console.WriteLine(result);

// string[] items=result.Split(",");

// foreach(var item in items)
// {
//     Console.WriteLine(item);
// }



// string pangram = "The quick brown fox jumps over the lazy dog";

// string[] words = pangram.Split(" ");

// for (int i=0; i < words.Length; i++)
// {
//     char[] wordCharacters= words[i].ToCharArray();
//     Array.Reverse(wordCharacters);
//     words[i]=new string(wordCharacters);
// }

// pangram=string.Join(" ",words);

// Console.WriteLine(pangram);



// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orders=orderStream.Split(",");

// Array.Sort(orders);

// foreach(var order in orders)
// {
//     if(order.Length!=4)
//     {
//         Console.WriteLine(order+"\t- Error");
//     }
//     else
//     {
//         Console.WriteLine(order);
//     }
// }


// string first="Hello";
// string second="World";

// string result=string.Format("{0} {1}!",first,second);
// Console.WriteLine(result);

// Console.WriteLine("{1} {0}",first,second);
// Console.WriteLine("{0} {0} {0}",first,second);

// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price=123.45m;
// int discount=50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement =123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// decimal tax=.36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You save {0:C2} off the regular {1:C2} price.", (price - salePrice), price);

// Console.WriteLine(yourDiscount);


// int invoiceNumber=1201;
// decimal productShares=25.4568m;
// decimal subtotal=2750.00m;
// decimal taxPercentage=.15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Console.WriteLine($"    Shares: {productShares:N3} Product");

// Console.WriteLine($"      Sub Total: {subtotal:C}");

// Console.WriteLine($"        Tax: {taxPercentage:P2}");

// Console.WriteLine($"    Total Billed: {total:C}");

// string input="Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));

// Console.WriteLine(input.PadLeft(12,'-'));
// Console.WriteLine(input.PadRight(12,'-'));

// string paymentId = "769C";
// string payeeName="Mr.Stephen Ortega";
// string paymentAmount="$5,000.00";


// var formattedLine= paymentId.PadRight(6);
// formattedLine+=payeeName.PadRight(24);
// formattedLine+=paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);


// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here
// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");

// Console.WriteLine($"Currently you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");

// Console.WriteLine("");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// // Your logic here
// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += string.Format("{0:P2}", currentReturn).PadRight(10);
// comparisonMessage += string.Format("{0:C2}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += string.Format("{0:P2}", newReturn).PadRight(10);
// comparisonMessage += string.Format("{0:C2}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);

// string message="Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition+=1;

// int length = closingPosition-openingPosition;

// Console.WriteLine(message.Substring(openingPosition,length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan= "<span>";
// const string closeSpan="</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;

// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition,length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// // int openingPosition = message.LastIndexOf('(');

// // openingPosition += 1;

// // int closingPosition = message.LastIndexOf(')');

// // int length = closingPosition - openingPosition;
// // Console.WriteLine(message.Substring(openingPosition, length));


// while(true)
// {
//     int openingPosition= message.IndexOf('(');
//     if(openingPosition ==-1) break;

//     openingPosition+=1; 

//     int closingPosition=message.IndexOf(')');
//     int length = closingPosition-openingPosition;

//     Console.WriteLine(message.Substring(openingPosition,length));

//     message=message.Substring(closingPosition+1);
// }


// string message= "Help (find) the {opening symbols}";

// Console.WriteLine($"Searching THIS message: {message}");

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:
// char[] openSymbols={'[','{','('};
// int startPosition=5;

// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition=message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPositon {startPosition} : {message.Substring(openingPosition)}");




// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols={'[','{','('};

// int closingPosition=0;

// while(true)
// {
//     int openingPosition=message.IndexOfAny(openSymbols,closingPosition);

//     if(openingPosition==-1)break;

//     string currentSymbol=message.Substring(openingPosition,1);

//     char matchingSymbol=' ';

//     switch(currentSymbol)
//     {
//         case "[":
//             matchingSymbol=']';
//             break;
//         case "{":
//             matchingSymbol='}';
//             break;
//         case "(":
//             matchingSymbol=')';
//             break;
//     }

//     openingPosition+=1;

//     closingPosition= message.IndexOf(matchingSymbol,openingPosition);

//     int length=closingPosition-openingPosition;

//     Console.WriteLine(message.Substring(openingPosition,length));
// }

// string data = "12345John Smith          5000  3  ";
// string updatedData=data.Remove(5,20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);


const string input= "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity="";
string output="";

const string openSpan="<span>";
const string closeSpan="</span>";

int quantityStart=input.IndexOf(openSpan);
int quantityEnd=input.IndexOf(closeSpan);

quantityStart+=openSpan.Length;
int quantityLength=quantityEnd-quantityStart;
quantity=input.Substring(quantityStart,quantityLength);
Console.WriteLine("Quantity: "+quantity);


const string tradeSymbol="&trade;";
const string regSymbol="&reg;";
output=input.Replace(tradeSymbol,regSymbol);

const string openDiv="<div>";
const string closeDiv="</div>";

int divStart=output.IndexOf(openDiv);
int divCloseStart=output.IndexOf(closeDiv);

divStart+=openDiv.Length;
int outputLength=divCloseStart-divStart;
output=output.Substring(divStart,outputLength);


Console.WriteLine("Output: "+output);