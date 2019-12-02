using System;
					
public class Program
{
	public static void Main()
	{
		var controller = new HomeController();
		string result = controller.Hello("John");
		Console.Write(result);
;	}
}
public class GreetingService
{
	public string Greet (string name) {
		return "Hello, " + name;
	}
}
public class HomeController
{
	public string Hello(string name)
	{
		var service = new GreetingService();
		return service.Greet(name);
	}
}
