using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Notas
    {
		private int Restante;
		private int cedula100;
		private int cedula50;
		private int cedula20;
		private int cedula10;

		public Notas()
		{
			this.Restante = 0;
			this.cedula100 = 0;
			this.cedula50 = 0;
			this.cedula20 = 0;
			this.cedula10 = 0;
		}

		public Notas(int Restante, int cedula100, int cedula50, int cedula20, int cedula10)
		{
			this.Restante = Restante;
			this.cedula100 = cedula100;
			this.cedula50 = cedula50;
			this.cedula20 = cedula20;
			this.cedula10 = cedula10;
		}

		public int MostrarRestante()
		{
			return Restante;
		}

		public void AcharValorRestante(int Restante)
		{
			this.Restante = Restante;
		}

		public int MostrarNota100()
		{
			return cedula100;
		}

		public void CriarNota100(int cedula100)
		{
			this.cedula100 = cedula100;
		}

		public int MostrarNota50()
		{
			return cedula50;
		}

		public void CriarNota50(int cedula50)
		{
			this.cedula50 = cedula50;
		}

		public int MostrarNota20()
		{
			return cedula20;
		}

		public void CriarNota20(int cedula20)
		{
			this.cedula20 = cedula20;
		}

		public int MostrarNota10()
		{
			return cedula10;
		}

		public void CriarNota10(int cedula10)
		{
			this.cedula10 = cedula10;
		}
	}
}
