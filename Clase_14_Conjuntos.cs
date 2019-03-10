using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass 
{
	
  public static void Main () 
	{
		//establecer conjuntos
		int[] universo = new int[31];

		int[] conjunto1 = new int[] {0, 15, 6, 6, 12, 3, 0, 12, 18, 12, 6, 9, 18};
		int[] conjunto2 = new int[] {0, 4, 18, 6, 6, 16, 6, 0, 12, 10, 14, 18, 2, 12, 8, 2};

		//universo 0-30
		for (int i = 0; i < universo.Length; i++) universo[i] = i;

		//ordenar los conjuntos
		BubbleSort(ref conjunto1);
		BubbleSort(ref conjunto2);

		//escoger si se quiere hallar interseccion, union o complemento
		while (true)
		{
			bool respCorrecta = false;

			Console.Write("Qué quieres hallar? escribe 'inter' o 'uni' o 'comp': ");
			string resp = Console.ReadLine();	

			//comprobar qué respuesta escogió (if)
			switch (resp)
			{
				case "inter":
					Interseccion(conjunto1, conjunto2);
					respCorrecta = true;
					break;

				case "uni":
					Union(conjunto1, conjunto2);
					respCorrecta = true;
					break;

				case "comp":
					Complemento(conjunto1, conjunto2, universo);
					respCorrecta = true;					
					break;

				default:
					Console.WriteLine("Da una respuesta correcta");
					break;
			}
			if (respCorrecta) break;
		}
  }

	//ordenamiento
	static void BubbleSort(ref int[] conjunto)
	{
		for (int i = 0; i < (conjunto.Length - 1); i++)
		{
			for (int j = 0; j < (conjunto.Length - 1 - i); j++)
			{
				int temp = conjunto[j];
				if (conjunto[j] > conjunto[j+1])
				{
					conjunto[j] = conjunto[j+1];
					conjunto[j+1] = temp;
				}
			}
		}
	}

	//quitar números repetidos
	static void Simplificar(ref int[] array)
	{
		List<int> arrayList = new List<int>();
		int temp = 0;
		
		//poner los numeros no repetidos
		for (int i = 0; i < array.Length; i++)
		{			
			if (array[i] != temp || i == 0) arrayList.Add(array[i]);
			temp = array[i];
		}

		//retornar el arreglo simplificado
		array = arrayList.ToArray();
	}

	//hallar la intersección
	static void Interseccion(int[] conjunto1, int[] conjunto2)
	{
		List<int> interseccionList = new List<int>();

		//Añadir elementos iguales a la interseccion
		for (int i = 0; i < (conjunto1.Length - 1); i++)
		{
			for (int j = 0; j < conjunto2.Length; j++)
			{
				if (conjunto1[i] == conjunto2[j]) {
					interseccionList.Add(conjunto1[i]);
					break;
				}
				else if (conjunto1[i] < conjunto2[j]) break;
			}
		}

		//simplificar (quitar valores repetidos)
		int[] interseccion = interseccionList.ToArray();
		Simplificar(ref interseccion);

		//mostrar interseccion
		Console.WriteLine("\nInterseccion");		
		for (int i = 0; i < interseccion.Length; i++) 
		{
			if (i == (interseccion.Length - 1)) 
			{
				Console.Write(interseccion[i]);
				break;
			} 
			Console.Write(interseccion[i] + ", ");
		}
	}

	//hallar la union
	static void Union(int[] conjunto1, int[] conjunto2)
	{
		List<int> unionList = new List<int>();

		//añadir elementos a la union
		for (int i = 0; i < (conjunto1.Length - 1); i++)
		{
			unionList.Add(conjunto1[i]);
		}
		for (int i = 0; i < (conjunto2.Length - 1); i++)
		{
			unionList.Add(conjunto2[i]);
		}

		//ordenar y simplificar union (quitar valores repetidos) 
		int[] union = unionList.ToArray();
		BubbleSort(ref union);
		Simplificar(ref union);

		//mostrar union
		Console.WriteLine("\nUnion");
		for (int i = 0; i < union.Length; i++) 
		{
			if (i == (union.Length - 1)) 
			{
				Console.Write(union[i]);
				break;
			} 
			Console.Write(union[i] + ", ");
		}
	}

  //hallar el complemento
	static void Complemento(int[] conjunto1, int[] conjunto2, int[] universo)
	{
		List<int> universoList = universo.ToList();

		//quitar elementos al "universo" de los conjuntos
		for (int i = 0; i < universo.Length; i++)
		{
			for (int j = 0; j < conjunto1.Length; j++)
			{
				if (universo[i] == conjunto1[j]) {
					universoList.Remove(universo[i]);
					break;
				}
			}
			for (int j = 0; j < conjunto2.Length; j++)
			{
				if (universo[i] == conjunto2[j]) {
					universoList.Remove(universo[i]);
					break;
				}
			}
		}

		int[] complemento = universoList.ToArray(); 

		//mostrar complemento
		Console.WriteLine("\nComplemento");
		for (int i = 0; i < complemento.Length; i++) 
		{
			if (i == (complemento.Length - 1)) 
			{
				Console.Write(complemento[i]);
				break;
			} 
			Console.Write(complemento[i] + ", ");
		}
	}
}
