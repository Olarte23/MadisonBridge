
using Bridge.Logic;
using System.Linq.Expressions;

Console.WriteLine("Enter your Bridge: \n");

String? n = Console.ReadLine();

var bridges = new Bridges($"{n}");

Console.WriteLine(bridges.ValidateBridge());
