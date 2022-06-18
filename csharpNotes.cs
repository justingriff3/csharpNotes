//Excercise - "Hello World"
Console.WriteLine("Hello World");  //OUTPUT: Hello World!
Console.WriteLine("Congratulations! You wrote your first lines of code"); //OUTPUT: <Previous + Congratulations, you wrote your fist line of code//

//Challenge
Console.WriteLine("This is the fist line.");
Console.WriteLine("This is the second line of code");

//Writing char literal 
Console.WriteLine('J');

//Writing int literal
Console.WriteLine(123);

//Writing a decimal literal
Console.WriteLine(12.3m); //OUTPUT: 12.3
//In this context, the m is called a literal suffix which tells the complier you wish to work wth a value of a type decimal.

//Write a bool literal
Console.WriteLine(True);   //OUTPUT: True
Console.WriteLine(False);  //OUTPUT: False

//VARIABLES
String firstname = "Justin";
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

//Var Keyword: Implicitly typed local variables
var message = "Hello World!";
/*Since the varible message is immediately set to the string value "Hello World!",
 The C# compiler understands the intent and treats ever instance of message as an instance of type string   */
//Trying to change message to a decimal or int after would throw an error
//Var keyword can only be used if the variable is initialized

//Character Escape Sequences: Skipping lines and adding tabs
Console.WriteLine(\n); //jumps to a new line
Console.WriteLine(\t); //Creates a tab in the output line
Console.WriteLine("Hello \"World\"!"); //OUTPUT: Hello "World"!

//Verbatim String Literal: Kepp all space and characters without the need to escape the backlash
Console.WriteLine(@"    c:\source\repos
                     (this is where your code goes)");
/*OUTPUT: c:\source\repos
           (this is where your code goes)*/

//Uniciode Escape Characters: Kon'nichwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
//\u = an escape sequence that uses four-character code representing some character in Unicode

//Concatenate a literal string and a variable
string message1 = "Hello" + firstName;
Console.WriteLine(message1); //OUTPUT: Hello Justin
//Concatenate two literal strings
Console.WriteLine(message + " " + firstName); //OUTPUT: Hellow World! Justin

//String Interplotation: Combines multiple values into a single literal string by using a "template" and one or more interplotaion expressions
//An interplotaion expression is a variable surronded by an opening and closing curly brace symbol {}
//The literal string becomes a template when its prefixed by the $ character
greeting = "Hello";
String message2 = $"{greeting} {firstName}!"; //A popular alternative to string concatenation
Console.WriteLine(message2); //OUTPUT: Hello Justin!

//COMBINE VERBATIM LITERALS AND STRING INTERPLOTATION
String projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data"); //OUTPUT: C:\Output\First-Project\Data

//BASIC OPERATIONS ON NUMBERS IN C#
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber); // OUTPUT: 19

//Mix data types to froce implicit type conversations
Console.WriteLine(firstName + " sold " + firstNumber + " apples."); //OUTPUT: Justin sold 12 apples
Console.WriteLine(firstName + " sold " + (firstNumber + secondNumber) + " apples."); //OUTPUT: Justin sold 19 apples
//The parentheses symbol form the order of operations operator.

//Basic Math Operations              OUTPUT WOULD BE
int sum = 7 + 5;                    //   12
int difference = 7 - 5;             //   2
int product = 7 * 5;                //   35
int quotient = 7 / 5;               //   1 

decimal decimalQuotient = 7.0 / 5;
Console.WriteLine("Decimal quotient: " + decimalQuotient);  //OUTPUT: Decimal quotient: 1.4

int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine(quotient1); //OUTPUT: 1.4

//Modulus: Remainder after int division
Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));   //OUTPUT: Modulus of 200 / 5 : 0
Console.WriteLine("Modulus of 7 / 5: " + (7 %  5));       //OUTPUT: Modulus of 7 / 5 : 2

/* Order of Operations
1. Parentheses (whatever is inside the parenthesis is performed first)
2. Exponents
3. Multiplication and Division (from left to right)
4. Addition and Subtraction (from left to right)

5. There is no exponent operator in c#, you can use System.Math.Pow()
*/
  
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);  //OUTPUT: 23
Console.WriteLine(value2);  //OUTPUT: 35

//INCREMENT AND DECREMENT
value1 = 0;                //Setting value to 0
value1 = value1 + 5;       //Incrementing value by 5
value1 += 5;               //Incrementing value by 5

value1 = value1 + 1;       //Incrementing value by 1
value1++;                  //Incrementing value by 1
value1--;                  //DECREMENTING value by 1

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius");

//PRACTICING METHODS
Random dice = new Random(); //Random number generator
int roll = dice.Next(1, 7); //Numbers from 1 to 6 are displayed in the console output
Console.WriteLine(roll);    

//Create a Random game: Use the if statement
Random dice1 = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
//OUTPUT: 4 + 5 + 2 = 11

if(total > 14) 
{
    Console.WriteLine("You win!"); //IF the roll total is above 14 you win!
}

if(total < 15)
{
    Console.WriteLine("Sorry, you lose"); //IF the roll total is 14 or under you lose!!!
}

//Boolean expressions using if/if-else statements
string message3 = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");     //OUTPUT: true
Console.WriteLine(result);

//RANDOM GAME
if(message3.Contains("fox"))   //statement is true
{
    Console.WriteLine("What does the fox say?"); //OUTPUT: What does the fox say?
}

if((roll1 == roll2) || (roll2 == roll3) || (roll1) == (roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total");
    total += 2;
}

if((roll1 = roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}
else if(total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose");
}

//ARRAYS AND ARRAY FEATURES
String[] orderIDs = new string[3];

orderIDs[0] = "A123";
orderIDs[1] = "B456";
orderIDs[2] = "C789";

Console.WriteLine($"First: {orderIDs[0]}");   //OUTPUT: A123
Console.WriteLine($"Second: {orderIDs[1]}");  //OUTPUT: B456
Console.WriteLine($"Third: {orderIDs[2]}");   //OUTPUT: C789

String[] sameIDs = {"A123", "B456", "C789"};  //Another to Reassign values

Console.WriteLine($"There are {orderIDs.Length} orders to process."); //OUTPUT: There are 3 orders to process.

//FOREACH STATEMENT (LOOPS)
String[] names = {"Bob", "Conrad", "Grant"};
foreach (String name in names)
{
    Console.WriteLine(name);     //OUTPUT: Bob Conrad Grant
}

int[] intventory = {200, 450, 700, 175, 250};
sum = 0;
int bin;
foreach(int items in inventory)
{
    sum += items;          //keeps a running total of the items in the array
    bin++;                 //Keeps track of how many iterations
    Console.WritingLine($"Bin {bin} = {items} items (Running total: {sum}"); //3rd iteration: Bin 3 = 700 items (Running total: 1350)
}

Console.WriteLine($"We have {sum} items in inventory.");

//Whitespace functions
//Example 1
Console
.
WriteLine
(
"Hello World!"
)
;
//OUTPUT: Hello World!

//Example 2
string firstWord = "Hello"; String lastWord = "World!"; Console.WriteLine(firstword + " " + lastWord);
//OUTPUT: Hello World!














