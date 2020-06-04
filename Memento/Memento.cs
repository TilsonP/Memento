using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
		private Juego estado;

		public Memento(Juego estado)
		{
			this.estado = estado;
		}

		public Juego getEstado()
		{
			return estado;
		}
	}
}
