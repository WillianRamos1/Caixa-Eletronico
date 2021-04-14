using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Saque
    {
		public Notas sacar(int valor)
		{

			Notas notas = new Notas();
			notas.AcharValorRestante(valor);

			while (notas.MostrarRestante() >= 100)
			{
				notas.CriarNota100(notas.MostrarNota100() + 1);
				notas.AcharValorRestante(notas.MostrarRestante() - 100);

			}

			while (notas.MostrarRestante() >= 50)
			{
				notas.CriarNota50(notas.MostrarNota50() + 1);
				notas.AcharValorRestante(notas.MostrarRestante() - 50);
			}

			while (notas.MostrarRestante() >= 20)
			{
				notas.CriarNota20(notas.MostrarNota20() + 1);
				notas.AcharValorRestante(notas.MostrarRestante() - 20);
			}

			while (notas.MostrarRestante() >= 10)
			{
				notas.CriarNota10(notas.MostrarNota10() + 1);
				notas.AcharValorRestante(notas.MostrarRestante() - 10);
			}

			if (notas.MostrarRestante() == 0)
			{
				return notas;
			}
			else
			{
				return null;
			}
		}
	}
}
