using System;

namespace Memento
{
    public class Juego
    {
		private string Progress;
		private int Checkpoint;

		public int getCheckpoint()
		{
			return Checkpoint;
		}

		public void setCheckpoint(int checkpoint)
		{
			this.Checkpoint = checkpoint;
		}

		public string getProgress()
		{
			return Progress;
		}

		public void setProgress(String nombre)
		{
			this.Progress = nombre;
		}

		public string toString()
		{
			return "Juego [Progreso=" + Progress + ", checkpoint=" + Checkpoint + "]";
		}
	}
}
