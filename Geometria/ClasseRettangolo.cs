using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
	public class Rettangolo
	{
		// ATTRIBUTI
		public int baseRettangolo;
		public int altezzaRettangolo;

		// STATI

		// COSTRUTTORE
		public Rettangolo(int baseRettangolo,  int altezzaRettangolo)
		{
			this.baseRettangolo = baseRettangolo;
			this.altezzaRettangolo = altezzaRettangolo;
		}

		// METODI
		public int calcolaPerimetro(int baseRettangolo, int altezzaRettangolo)
		{
			int perimetro = (this.baseRettangolo * 2) + (this.altezzaRettangolo * 2);
			return perimetro;

		}


		public int calcolaArea(int baseRettangolo, int altezzaRettangolo)
		{

			int area = this.baseRettangolo * this.altezzaRettangolo;
			return area;

		}
	}
}
