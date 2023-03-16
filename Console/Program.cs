
using Bridge.Logic;
using System.Linq.Expressions;

var bridge = new Bridges[]
{
    new Bridges("*==+==+===*"),
    new Bridges("*==+===+==*"),
    new Bridges("*==+====+==*"),

};

foreach (var item in bridge)
{
    Console.WriteLine(item.ValidateBridge());
}