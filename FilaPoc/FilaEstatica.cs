using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPoc
{
	public class FilaEstatica : IFila<int>
	{
		private int?[] VetorDeElementos { get; set; }
		public int? Inicio { get; private set; }
		public int? Fim { get; private set; }
		public int Qtde { get; private set; }
		public int Tamanho { get; private set; }

		public FilaEstatica(int tamanho)
		{
			Inicio = null;
			Fim = null;
			Qtde = 0;
			Tamanho = tamanho;
			VetorDeElementos = new int?[tamanho];

		}
		public int Desenfilerar()
		{
			if(EstaVazia()) throw new Exception("UnderFlow");

			int valorRetorno = VetorDeElementos[Inicio.Value].Value;
			
			VetorDeElementos[Inicio.Value] = null;
			Qtde--;
			if (EhUltimaPosicaoInicio()) Inicio = 0;
			else Inicio++;

			if (EstaVazia()) { Inicio = null; Fim = null; }


			return valorRetorno;
		}

		public void Enfilerar(int item)
		{
			if (EstaCheia())
				throw new Exception("OverFlow");

			if (EstaVazia())
			{
				Inicio = 0;
				Fim = 0;
			}
			else {
				if (EhUltimaPosicaoFim()) Fim = 0;	
				else Fim++; 
			}

			VetorDeElementos[Fim.Value] = item;
			Qtde++;

		}

		public bool EstaVazia() => Qtde == 0;

		public bool EstaCheia() => Qtde == Tamanho;

		public bool EhUltimaPosicaoFim() => Fim == (Tamanho-1);
		public bool EhUltimaPosicaoInicio() => Inicio == (Tamanho-1);

	}
}
