// See https://aka.ms/new-console-template for more information
using FilaPoc;

Console.WriteLine("Hello, World!");
FilaDinamica filaDinamica = new FilaDinamica();
filaDinamica.Enfilerar(10);
filaDinamica.Enfilerar(20);
filaDinamica.Enfilerar(30);
filaDinamica.Desenfilerar();
filaDinamica.Desenfilerar();
Console.WriteLine("Hello, World!");


