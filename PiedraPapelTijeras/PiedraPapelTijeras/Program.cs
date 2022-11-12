using System;

namespace PiedraPapelTijeras
{
	class MainClass
	{
		public static void Main(string[] args)
		{

			Random r = new Random();
			const int piedra = 1;
			const int papel = 2;
			const int tijeras = 3;
			int select;

			select = r.Next(1, 4);
			Console.WriteLine(select);
			Menu();
			int seleccion_usuario = int.Parse(Console.ReadLine());
			Console.WriteLine(String.Format("usuario: {0}, computadora: {1}", seleccion_usuario, select));

			if (select == seleccion_usuario) {
				Console.WriteLine("Empate!");
			}

			if (select == piedra && seleccion_usuario == papel) {
				Console.WriteLine("Papel gana a piedra Ganaste !");
			}

			if (select == piedra && seleccion_usuario == tijeras)
			{
				Console.WriteLine("Piedra gana a tijeras Perdiste !");
			}

			if (select == papel && seleccion_usuario == tijeras)
			{
				Console.WriteLine("Tijera gana a papel Ganaste !");
			}

			//-----------------------------------------------------------------------------

			if (seleccion_usuario == piedra && select == papel)
			{
				Console.WriteLine("Papel gana a piedra Perdiste !");
			}

			if (seleccion_usuario == piedra && select == tijeras)
			{
				Console.WriteLine("Piedra gana a tijeras Ganaste !");
			}

			if (seleccion_usuario == papel && select == tijeras)
			{
				Console.WriteLine("Tijera gana a papel Perdiste !");
			}
			Console.ReadLine();
		}

		#region Metodos privados

		/// <summary>
		/// Funcion que muestra el menu de opciones en pantalla
		/// </summary>
		private static void Menu(){
			Console.WriteLine("--------------------------------------");
			Console.WriteLine("---------Bienvenido al Juego----------");
			Console.WriteLine("--------------------------------------");

			Console.WriteLine("Opcion 1. Piedra");
			Console.WriteLine("Opcion 2. Papel");
			Console.WriteLine("Opcion 3. Tijera");

			Console.WriteLine("Por favor, seleccione una de las opciones.");
		}

		#endregion

	}
}