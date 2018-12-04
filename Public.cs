using System; 
namespace Class
{
    class Class
    {
static void Main(string[] args)
           {
var object1 = new Calculate();
string Opera;
Console.WriteLine("Enter first number:");
 var num1 =Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number:");
 var num2 =Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("enter an operator");
 Opera=Console.ReadLine();

 
 if(Opera=="+")
 {
Console.WriteLine(object1.Add(num1,num2));
 }
 if(Opera=="-")
 {
Console.WriteLine(object1.substract(num1,num2));
 }
 if(Opera=="*")
 {
Console.WriteLine(object1.multiply(num1,num2));
 } 
 if(Opera=="/")
 {
Console.WriteLine(object1.divide(num1,num2));
 }
 else
 {
     Console.WriteLine("imposible calculation");
 }
Console.ReadKey();
           }
    }

}
    

   