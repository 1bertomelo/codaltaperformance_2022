// See https://aka.ms/new-console-template for more information
using FilaPoc;

Console.WriteLine("Hello, World!");
FilaEstatica filaEstatica = new FilaEstatica(5);
filaEstatica.Enfilerar(10);
filaEstatica.Enfilerar(20);
filaEstatica.Enfilerar(30);
filaEstatica.Enfilerar(40);
filaEstatica.Enfilerar(50);
filaEstatica.Desenfilerar();
filaEstatica.Enfilerar(60);
filaEstatica.Desenfilerar();
filaEstatica.Desenfilerar();
filaEstatica.Desenfilerar();
filaEstatica.Desenfilerar();
filaEstatica.Enfilerar(70);


