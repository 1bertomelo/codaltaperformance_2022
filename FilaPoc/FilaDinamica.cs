using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPoc
{
	public class FilaDinamica : IFila<int>
	{
		public int Tamanho { get; private set; }
		public No? Inicio { get; private set; }
		public No? Fim { get; private set; }

		public FilaDinamica()
		{
			Tamanho = 0;
			Inicio = null;
			Fim = null;
		}

		public int Desenfilerar()
		{
			if (EstaVazia()) throw new Exception("Underflow");

			int valorRetorno = Inicio.Valor;
			
			Inicio = Inicio.ProximoNo;
			Tamanho--;
			return valorRetorno;

		}

		public void Enfilerar(int item)
		{
			No novoNo = new No(item, null);
			if (EstaVazia())
				Inicio = novoNo;
			else
				Fim.AtualizarNoProximo(novoNo);
			Fim = novoNo;
			Tamanho++;
		}

		public bool EstaVazia() => Tamanho == 0;


	}
}
