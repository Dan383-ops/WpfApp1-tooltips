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
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Логика взаимодействия для Window1.xaml
	/// </summary>

	public partial class Window1 : Window
	{
		private double _currentValue = 0;
		private double _storedValue = 0;
		private double _operation = '\0';
		public Window1()
		{
			InitializeComponent();
		}

		private void NumberButton_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			string number = button.Content.ToString();
			if(txtDisplay.Text == "0" && number != ".")
			{
				txtDisplay.Text = number;
			}
			else
			{
				txtDisplay.Text += number;
			}
		}

		private void OperationButton_Click(object sender, RoutedEventArgs e)
		{
			Button button = (Button)sender;
			_operation = button.Content.ToString()[0];
			_storedValue = double.Parse(txtDisplay.Text);
			txtDisplay.Text = "0";
		}

		private void EqualsButton_Click(object sender, RoutedEventArgs e)
		{
			_currentValue = double.Parse(txtDisplay.Text);
			switch (_operation)
			{
				case '+':
					_currentValue = _storedValue + _currentValue;
					break;
				case '-':
					_currentValue = _storedValue - _currentValue;
					break;
				case '*':
					_currentValue = _currentValue * _storedValue;
					break;
				case '/':
					if(_currentValue != 0)
					{
						_currentValue = _storedValue / _currentValue;
					} else
					{
						MessageBox.Show("Що ты лысый? Обоюдно!");
					}
					break;
			}
			txtDisplay.Text = _currentValue.ToString();
			_operation = '\0';
		}

		private void btn7_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn8_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn9_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn5_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn6_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn1_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn2_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn3_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn0_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDecimal_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnEquals_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnRemove_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnclear_Click(object sender, RoutedEventArgs e)
		{
			txtDisplay.Text = "0";
			_currentValue = 0;
			_operation = '\0';
			_storedValue = 0;
		}

		private void btnMuti_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnDivis_Click(object sender, RoutedEventArgs e)
		{

		}

		/*private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow window = new MainWindow();
			window.Show();
			this.Close();
		}
		private void MenuItem1_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{

		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			MessageBox.Show(textBox.Text);
		}

		private void btn4_Click(object sender, RoutedEventArgs e)
		{

		}
	*/
	}
}
