using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace xaml_lab_3._1
{
    public partial class MainWindow : Window
    {
        private bool isDrawing;
        private Point previousPoint;
        private Brush brushColor;
        private double brushSize;
        private string currentMode;

        public MainWindow()
        {
            InitializeComponent();
            brushColor = Brushes.Black; // начальный цвет кисти
            brushSize = 5; // начальный размер кисти
            currentMode = "Рисование"; // начальный режим
        }

        private void ColorPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedColor = (ComboBoxItem)ColorPicker.SelectedItem;
            brushColor = (Brush)new BrushConverter().ConvertFromString(selectedColor.Tag.ToString());
        }

        private void Mode_Checked(object sender, RoutedEventArgs e)
        {
            var selectedMode = (RadioButton)sender;
            currentMode = selectedMode.Content.ToString();
        }

        private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (currentMode == "Рисование" || currentMode == "Удаление")
            {
                isDrawing = true;
                previousPoint = e.GetPosition(DrawingCanvas);
                if (currentMode == "Удаление")
                {
                    brushColor = Brushes.White;
                }
                else
                {
                    var selectedColor = (ComboBoxItem)ColorPicker.SelectedItem;
                    brushColor = (Brush)new BrushConverter().ConvertFromString(selectedColor.Tag.ToString());
                }
                brushSize = BrushSizeSlider.Value;
            }
        }

        private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Point currentPoint = e.GetPosition(DrawingCanvas);
                Line line = new Line
                {
                    Stroke = brushColor,
                    StrokeThickness = brushSize,
                    X1 = previousPoint.X,
                    Y1 = previousPoint.Y,
                    X2 = currentPoint.X,
                    Y2 = currentPoint.Y
                };

                DrawingCanvas.Children.Add(line);
                previousPoint = currentPoint;
            }
        }

        private void DrawingCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDrawing = false;
        }
    }
}
