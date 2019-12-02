using System;
					

public class Program
{
	public static void Main()
	{
		var controller = new HomeController(new GreetingService());
		string result = controller.Hello("John");
		Console.Write(result);
	}
}
public interface IGreetingService
{
	string Greet(string name);
}
public class GreetingService : IGreetingService
{
	public string Greet (string name) {
		return "Hello, " + name;
	}
}
public class HomeController
{
	private readonly IGreetingService _greetingService;
	public HomeController(IGreetingService greetingService)
	{
		_greetingService = greetingService;
	}
	public string Hello(string name)
	{
		return _greetingService.Greet(name);
	}
}
