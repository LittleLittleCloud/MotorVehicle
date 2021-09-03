// See https://aka.ms/new-console-template for more information
using SampleClassiciation;

var output = SampleClassification.Predict(horizon: 30);
Console.WriteLine(string.Join("\r\n", output.x));
