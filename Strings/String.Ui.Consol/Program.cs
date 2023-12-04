// See https://aka.ms/new-console-template for more information
using Strings.Logic;

try
{
	Console.WriteLine("Hello, World!");
	var mystring = new MyString("for");

	Console.WriteLine(mystring.Ispalindrome());


}
catch (Exception ex)
{

	throw new Exception(ex.Message);
}