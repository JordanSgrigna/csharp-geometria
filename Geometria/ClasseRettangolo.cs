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
		public int calcolaPerimetro()
		{
			int perimetro = (baseRettangolo * 2) + (altezzaRettangolo * 2);
			return perimetro;

		}


		public int calcolaArea()
		{

			int area = baseRettangolo * altezzaRettangolo;
			return area;

		}

		public string stampaInformazioniRettangolo()
		{
			string informazioniRettangolo =
				$"---------RETTANGOLO---------- \n" +
				$"Base: {baseRettangolo} \n" +
				$"Altezza: {altezzaRettangolo} \n" +
				$"Perimetro: {calcolaPerimetro()} \n" +
				$"Area: {calcolaArea()} \n" +
				$"------------------------------";

			return informazioniRettangolo;
		}

		public void stampaRettangoloInConsole()
		{
			for (int i = 0; i < altezzaRettangolo; i++)
			{
				for (int j = 0; j < baseRettangolo; j++)
				{
					//Prima ed ultima riga
					if (i == 0 || i == (altezzaRettangolo - 1))
					{
						Console.Write("--");
					}
					//Prima ed ultima colonna
					else if (j == 0 || j == (baseRettangolo - 1))
					{
						Console.Write("|");
					}
					else
					{
						Console.Write("  ");
					}

					if (j == (baseRettangolo - 1))
					{
						Console.WriteLine("");
					}


				}

			}
		}
	}
}
