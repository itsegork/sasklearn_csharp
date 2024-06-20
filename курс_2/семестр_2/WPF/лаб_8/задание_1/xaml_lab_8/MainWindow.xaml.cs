using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace xaml_lab_8
{
    public partial class MainWindow : Window
    {
        private ScaleTransform scaleTransform = new ScaleTransform();

        public MainWindow()
        {
            InitializeComponent();

            // Привязка свойства ScaleX и ScaleY преобразования scaleTransform к значению Slider
            scaleSlider.ValueChanged += OnScaleSliderValueChanged;

            // Начальное применение преобразования scaleTransform к StackPanel с элементами управления
            rootElement.LayoutTransform = scaleTransform;
        }

        private void OnScaleSliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Обновление значений ScaleX и ScaleY преобразования scaleTransform
            scaleTransform.ScaleX = scaleSlider.Value;
            scaleTransform.ScaleY = scaleSlider.Value;
        }
    }
}
