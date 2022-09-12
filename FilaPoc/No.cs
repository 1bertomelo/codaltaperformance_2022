using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPoc
{
	public class No
	{
		public No(int valor, No? proximoNo)
		{
			Valor = valor;
			ProximoNo = proximoNo;
		}

		public int Valor { get; private set; }
		public No? ProximoNo { get; private set; }

		public void AtualizarNoProximo(No? noProximo)
		{
			ProximoNo = noProximo;
		}
	}
}
