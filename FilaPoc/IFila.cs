using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPoc
{
	public interface IFila<T>
	{
		//Enqueue
		public void Enfilerar(T item);
		//Deque
		public T Desenfilerar();

	}
}
