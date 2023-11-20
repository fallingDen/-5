using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        const string IncorrectInputError1 = "Я надеюсь вы это случайно, ведь так...? ";
        const string IncorrectInputError2 = "Это любопытство. Я угадал? =) ";

        int q = 0;

		private void Button_Сложить_1_Пару_Чисел(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(пара1_1.Text, out int a) || !int.TryParse(пара1_2.Text, out int b))
			{
				q++;

				if (q == 0) { MessageBox.Show(IncorrectInputError); };

                if (q == 1) { MessageBox.Show(IncorrectInputError1); };
                if (q == 2) { MessageBox.Show(IncorrectInputError2); };
                if (q == 3) { Tb__Предупреждение_.Visibility = Visibility.Visible; };
                if (q == 4) { Close(); };

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
				q++;

                if (q == 0) { MessageBox.Show(IncorrectInputError); };

                if (q == 1) { MessageBox.Show(IncorrectInputError1); };
                if (q == 2) { MessageBox.Show(IncorrectInputError2); };
                if (q == 3) { Tb__Предупреждение_.Visibility = Visibility.Visible; };
                if (q == 4) { Close(); };

                return;
			}


            
		}



		private void Button_Сложить_Пары_Чисел(object sender, RoutedEventArgs e)
		{
			if (!int.TryParse(пара1_1.Text, out int a)
			|| !int.TryParse(пара1_2.Text, out int b)
			|| !int.TryParse(пара2_1.Text, out int c)
			|| !int.TryParse(пара2_2.Text, out int d))
			{
			

                if (q == 0) { MessageBox.Show(IncorrectInputError); };

                if (q == 1) { MessageBox.Show(IncorrectInputError1); };
             if (q == 2) { MessageBox.Show(IncorrectInputError2); };
             if (q == 3) { Tb__Предупреждение_.Visibility = Visibility.Visible; };
             if (q == 4) { Close(); };
				q++;

				return;
				
			}
			
            

            Money pair1 = new Money(a, b);
			Money pair2 = new Money(c, d);
			Money pair3 = pair1 + pair2;
			пара3_1.Text = pair3.One.ToString();
			пара3_2.Text = pair3.Second.ToString();


		}

		private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Автор: Соколов Даниил \n" +
            "Практическая работа №7 \nЗадание:Использовать класс Pair (пара чисел). Определить класс-наследник Money с \r\nхарактеристиками: рубли и копейки. Переопределить операцию сложения и \r\nопределить методы вычитания и деления денежных сумм.");

		}

		private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void MenuItem_Click_Анекдот(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Мужик поехал на рыбалку. И - поймал настоящую золотую рыбку. Рыбка говорит, - времена трудные, загадывай желание - но только одно. Мужик думал-думал , что ж такое загадать, и чтоб для себя польза, и для Родины. \"Хочу, - говорит, - чтоб доллар был по рублю\". \"Будь по твоему!\"- Рыбка махнула хвостиком и уплыла. Мужик поехал домой, телефон выключил, новости не слушает. Домой пришел - жена с порога:\r\n- Ты не поверишь, что произошло!\r\nОн так, хитро:\r\n- Неужто доллар по рублю?\r\n- Ну можно и так сказать. Деноминацию рубля объявили, сто к одному...");
		}

		private void Tb__Предупреждение__TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void пара3_2_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void пара3_1_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void Button_Вычесть_Пары_Чисел(object sender, RoutedEventArgs e)
		{
            if (!int.TryParse(пара1_1.Text, out int a)
            || !int.TryParse(пара1_2.Text, out int b)
            || !int.TryParse(пара2_1.Text, out int c)
            || !int.TryParse(пара2_2.Text, out int d))
            {


                if (q == 0) { MessageBox.Show(IncorrectInputError); };

                if (q == 1) { MessageBox.Show(IncorrectInputError1); };
                if (q == 2) { MessageBox.Show(IncorrectInputError2); };
                if (q == 3) { Tb__Предупреждение_.Visibility = Visibility.Visible; };
                if (q == 4) { Close(); };
                q++;

                return;

            }

            Money pair1 = new Money(a, b);
            Money pair2 = new Money(c, d);
            Money pair3 = pair1.Raz(pair2);

			if (pair3.Second < 0)
			{
				pair3.One = pair3.One - 1;
				pair3.Second = 100 + pair3.Second  ;
			}

            пара3_1.Text = pair3.One.ToString();
            пара3_2.Text = pair3.Second.ToString();

        }

		private void Button_Разделить_Пару_Чисел(object sender, RoutedEventArgs e)
		{
			if (_1_пара.IsChecked == true)
			{
				if (int.TryParse(пара1_1.Text, out int a)
				&& int.TryParse(пара1_2.Text, out int b)
				&& int.TryParse(tb_Делитель.Text, out int s))
                {
					
                    Money pair = new Money (a, b);
					Money.Division( ref pair, s);
                    пара1_1.Text = pair.One.ToString();
                    пара1_2.Text = pair.Second.ToString();
                }
            }
            if (_2_пара.IsChecked == true)
            {
                if (int.TryParse(пара2_1.Text, out int a)
                && int.TryParse(пара2_2.Text, out int b)
                && int.TryParse(tb_Делитель.Text, out int s))
                {
                    Money pair = new Money(a, b);
                    Money.Division(ref pair, s);
                    пара2_1.Text = pair.One.ToString();
                    пара2_2.Text = pair.Second.ToString();
                }
            }
            if (_1_пара.IsChecked == true)
            {
                if (int.TryParse(пара3_1.Text, out int a)
                && int.TryParse(пара3_2.Text, out int b)
                && int.TryParse(tb_Делитель.Text, out int s))
                {
                    Money pair = new Money(a, b);
                    Money.Division(ref pair, s);
                    пара3_1.Text = pair.One.ToString();
                    пара3_2.Text = pair.Second.ToString();
                }
            }
			        
        }
	}
}
