/******************************************
 * Автор: Венгржиновская А. С.            *
 * Дата: 14.02.2022                       *
 * Название: ООП на C#                    *
*******************************************/

using System;

namespace lab2 {

	class Program {

		static void Main(string[] args) {

			var Document = DocumentSingleton.GetInstance();

			Document.Menu();
		}
	}
}

