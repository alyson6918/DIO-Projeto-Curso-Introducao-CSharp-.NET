using Csharp;
using Interface;
using Enum;

var pessoa0 = (Pessoas)0;
Pessoas pessoa1 = Pessoas.Alyson;
Pessoas pessoa2 = (Pessoas)2;

Pessoa person = new Pessoa();
person.Name = "Alyson Lima Ramalho";
person.Age = 18;
person.State = "SP";

var person2 = new Pessoa();
person2.Name = "Aline";
person2.Age = 36;
person2.State = "SP";

Animal animal = new Animal();

animal.Name = "Einstein";
animal.Owner = "Alyson";
animal.Species = "Maine Coon";

Console.WriteLine(pessoa2);