using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace xaml_lab_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeBackgroundColor_Click(object sender, RoutedEventArgs e)
        {
            // Смена цвета фона между двумя определенными ресурсами
            if (MainGrid.Background == FindResource("DefaultBackground") as SolidColorBrush)
            {
                MainGrid.Background = FindResource("AlternateBackground") as SolidColorBrush;
            }
            else
            {
                MainGrid.Background = FindResource("DefaultBackground") as SolidColorBrush;
            }

            // Обновление строки состояния
            StatusText.Text = "Цвет фона изменен";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Егор Курочкин (не любит C#, пожалейте его, пожалуйста)", "О разработчике");
            StatusText.Text = "Показана информация о разработчике";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                StatusText.Text = menuItem.Header.ToString();
            }
        }

        private void MenuItem_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StatusText.Text = "Готово";
        }

        private void ToolBarButton_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (sender is Button button)
            {
                StatusText.Text = button.Content.ToString();
            }
        }

        private void ToolBarButton_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            StatusText.Text = "Готово";
        }
    }
}
