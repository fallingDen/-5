using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		const string IncorrectInputError = "Не надо дядя.....Няа!!! OwO ";

		private void Button_Сложить_1_Пару_Чисел(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(пара1_1.Text, out int a) || !int.TryParse(пара1_2.Text, out int b))
			{
				MessageBox.Show(IncorrectInputError);
				return;
			}

			Pair pair = new Pair(a, b);
			pair--;
			пара1_1.Text = pair.One.ToString();
			пара1_2.Text = pair.Second.ToString();

			пара3_1.Clear();
			пара3_2.Clear();
		}

		private void Button_Сложить_2_Пару_Чисел_Click(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(пара2_1.Text, out int a) || !int.TryParse(пара2_2.Text, out int b))
			{
				MessageBox.Show(IncorrectInputError);
				return;
			}

			Pair pair = new Pair(a, b);
			pair--;
			пара2_1.Text = pair.One.ToString();
			пара2_2.Text = pair.Second.ToString();

			пара3_1.Clear();
			пара3_2.Clear();
		}

		private void Button_Сложить_Пары_Чисел(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(пара1_1.Text, out int a)
			|| !int.TryParse(пара1_2.Text, out int b)
			|| !int.TryParse(пара2_1.Text, out int c)
			|| !int.TryParse(пара2_2.Text, out int d))
			{
				MessageBox.Show(IncorrectInputError);
				return;
			}

			Pair pair1 = new Pair(a, b);
			Pair pair2 = new Pair(c, d);
			Pair pair3 = pair1 + pair2;
			пара3_1.Text = pair3.One.ToString();
			пара3_2.Text = pair3.Second.ToString();


		}

		private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Автор: Соколов Даниил \n" +
			"Практическая работа №6 \nЗадание:Использовать класс Pair (пара чисел).\n" +
			"Разработать операцию сложения пар (а, b) + (с, d) = (а + c, b + d).\n" +
			"Разработать операцию для уменьшения полей на 1.");

		}

		private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void MenuItem_Click_Анекдот(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Если вам уже за тридцать и вы абсолютно ничего не добились в этой жизни — значит, \n вы честный и порядочный человек.");
		}
	}
}
