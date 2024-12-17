Console.WriteLine("Enter your name :");
var name = Console.ReadLine();

Console.WriteLine("Enter Language :");
var language = Console.ReadLine();  

if (language == "en")
{
    Console.WriteLine("Hello " + name);
} else if (language == "es")
{
    Console.WriteLine("Hola " + name);
} else if (language == "fr")
{
    Console.WriteLine("Bonjour " + name);
} else if (language == "tr")
{
    Console.WriteLine("Merhaba " + name);
}

Console.WriteLine("--------------------------------------");

Console.WriteLine("Enter number 1");
string one = Console.ReadLine();

Console.WriteLine("Enter number 2");
string two = Console.ReadLine();

int numOne = Convert.ToInt32(one);  
int numTwo = Convert.ToInt32(two);  

if (numOne > numTwo)
{
    Console.WriteLine("Bigger number is : " + numOne);
} else 
{
    Console.WriteLine("Bigger number is : " + numTwo);
}

Console.WriteLine("--------------------------------------");

Console.WriteLine("Enter the grade : ");
string grade = Console.ReadLine(); 

int mark = Convert.ToInt32(grade);  

if (mark >= 80)
{
    Console.WriteLine("A");
} else if (mark >= 70)
{
    Console.WriteLine("B");
} else if (mark >= 60)
{
    Console.WriteLine("C"); 
} else if (mark >= 50)
{
    Console.WriteLine("D");
} else
{
    Console.WriteLine("F");
}