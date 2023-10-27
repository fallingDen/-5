using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace WpfApp5
{
	internal class Pair
	{
		private int _one;
		private int _second;

		public int One
		{
			get
			{
				return _one;
			}
			set
			{
				_one = value;
			}
		} // свойства
		public int Second
		{
			get
			{
				return _second;
			}
			set
			{
				_second = value;
			}
		} // свойства


		public Pair(int one, int second)
		{
			_one = one;
			_second = second;
		} // конструктор 

		/// <summary>
		/// Сложение полей пары чисел (первого числа пары с вторым)
		/// </summary>
		/// <returns>Результат суммы полей пары чисел</returns>
		public int Sum()
		{
			return _one + _second;
		}
		/// <summary>
		/// Сложение этой пары чисел с другой парой чисел
		/// </summary>
		/// <param name="second">Вторая пара чисел</param>
		/// <returns>Третья пара чисел (результаты суммы первой с второй)</returns>
		public Pair Sum(Pair second)
		{
			return new Pair(One + second.One, Second + second.Second);
		}

		/// <summary>
		/// Сложение пар чисел
		/// </summary>
		/// <param name="pair1">Первая пара чисел</param>
		/// <param name="pair2">Вторая пара чисел</param>
		/// <returns>Третья пара чисел (результаты суммы первой с второй)</returns>
		public static Pair operator +(Pair pair1, Pair pair2)
		{
			return new Pair(pair1.One + pair2.One, pair1.Second + pair2.Second);
		}

		/// <summary>
		/// Уменьшение пары чисел на 1
		/// </summary>
		/// <param name="pair"></param>
		/// <returns>Пара чисел с полями на единицу меньше</returns>
		public static Pair operator --(Pair pair)
		{
			pair.One--;
			pair.Second--;

			return pair;
		}
	}
}
