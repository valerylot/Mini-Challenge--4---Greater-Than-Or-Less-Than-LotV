//Valery Lot
//09/09/2026
//Mini Challenge #4 Greater than or less than
//Converted user's number inputs from strings to int, wrote conditional statements, and Console.WriteLine to state whether the numbers were less than, greater than, or equal to.
//Peer Review Name:Chris Estrada
//Review: Code works and is clean with notes. I did not think to display the actual numbers in the results but that looks better. Good job!

Console.Clear();
Console.Write("Please enter a number: ");
string num1 = Console.ReadLine();
Console.Write("Please enter another number: ");
string num2 = Console.ReadLine();

//we want to convert the strings to int
int actualNum1 = Convert.ToInt32(num1);
int actualNum2 = Convert.ToInt32(num2);

//we want to create an if else conditional statement
if(actualNum1 > actualNum2)
{
    Console.WriteLine($"{actualNum1} is greater than {actualNum2}");
}
else if(actualNum1 < actualNum2)
{
    Console.WriteLine($"{actualNum1} is less than {actualNum2}");
}
else
{
    Console.WriteLine($"{actualNum1} is equal to {actualNum2}");
}

//now we want to create an if else conditional statement using actualNum comparing to actualNum1
if(actualNum2 > actualNum1)
{
    Console.WriteLine($"{actualNum2} is greater than {actualNum1}");
}
else if(actualNum2 < actualNum1)
{
    Console.WriteLine($"{actualNum2} is less than {actualNum1}");
}
else
{
    Console.WriteLine($"{actualNum2} is equal to {actualNum1}");
}