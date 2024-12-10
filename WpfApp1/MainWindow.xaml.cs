﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private List<string> imagesStore;
		private int currentIndex = 0;
		public MainWindow()
		{
			InitializeComponent();
			LoadImages(@"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\Danil_Polovianov\Downloads\DB");
			DisplayImage();
		}

		private void LoadImages(string path)
		{
			if (Directory.Exists(path))
			{
				imagesStore = new List<string>(Directory.GetFiles((path), "*.jpg"));
				imagesStore.AddRange(Directory.GetFiles((path), "*.png"));
				imagesStore.AddRange(Directory.GetFiles((path), "*.bmp"));
			}
		}

		private void DisplayImage()
		{
			if (imagesStore == null || imagesStore.Count == 0)
			{
				MessageBox.Show("Empty Folder");
				return;
			}
			var ImagePath = imagesStore[currentIndex];
			DisplayImageForm.Source = new BitmapImage(new Uri(ImagePath));
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Window1 window = new Window1();
			window.Show();
			this.Close();
		}

		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void MenuItem_Click_1(object sender, RoutedEventArgs e)
		{
			if (imagesStore == null || imagesStore.Count == 0)
			{
				MessageBox.Show("Nothing");
				return;
			}
			currentIndex = (currentIndex - + imagesStore.Count) % imagesStore.Count;
			DisplayImage();
		}

		private void MenuItem_Click_2(object sender, RoutedEventArgs e)
		{
			if (imagesStore == null || imagesStore.Count == 0)
			{
				MessageBox.Show("Nothing");
				return;
			}
			currentIndex = (currentIndex + 1) % imagesStore.Count;
			DisplayImage();
		}

		private void MenuItem_Click_3(object sender, RoutedEventArgs e)
		{
			Window1 window = new Window1();
			window.Show();
			this.Close();
		}
	}
}
