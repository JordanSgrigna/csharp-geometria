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

		public void stampaRettangolo()
		{
			Console.WriteLine("-----Rettangolo-----");
			Console.WriteLine($"Base: {baseRettangolo}");
			Console.WriteLine($"Altezza: {altezzaRettangolo}");
			Console.WriteLine("Perimetro: " + calcolaPerimetro());
			Console.WriteLine("Area: " + calcolaArea());
			Console.WriteLine("-------------------------");
		}
	}
}
