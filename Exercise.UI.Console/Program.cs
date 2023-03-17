using Beam.Logic;
using System;

Console.WriteLine("Enter your beam to calculate: \n");

String? n = Console.ReadLine();

var beam = new Logic($"{n}");

Console.WriteLine(beam.Validator());
Console.WriteLine(beam.ValidateResistence());
