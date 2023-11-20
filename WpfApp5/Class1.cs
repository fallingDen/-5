using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Ribbon;

namespace WpfApp5
{
	 class Pair
	{
		protected int _one;
		protected int _second;

		public virtual int One
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
		public virtual int Second
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
	class Money : Pair
	{

        protected int _рубли;
        protected int _копейки;
		

        public Money(int one, int second) : base(one, second)
        {
            _рубли= one;
            _копейки = second;


			if (_копейки > 100)
			{
				int x = _копейки / 100;
				_копейки = _копейки % 100;
				_рубли = _рубли + x;
		    };

        }       // конструктор 


        public virtual int One
        {
            get
            {
                return _рубли;
            }
            set
            {
                _рубли = value;
            }
        } // свойства
        public virtual int Second
        {
            get
            {
                return _копейки;
            }
            set
            {
                _копейки = value;
            }
        } // свойства

        public static Money operator +(Money pair1, Money pair2)
        {
            return new Money(pair1.One + pair2.One, pair1.Second + pair2.Second);
        }

        public Money Raz(Money second)
        {
            return new Money(One - second.One, Second - second.Second);
        }

		public static void Division(ref Money pair, int s)
		{

			   int x = pair._рубли % s;

			   x = x * 100 / s;

			   pair._рубли = pair._рубли  /  s;
     	       pair._копейки = pair._копейки / s;

			   pair._копейки = pair._копейки + x ;

        }

      
    }
	

}
