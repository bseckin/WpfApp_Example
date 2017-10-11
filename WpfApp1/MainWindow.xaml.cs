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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// MVVM
    /// 
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<GeoObject> Shapes = new List<GeoObject>();

        public MainWindow()
        {
            InitializeComponent();
            combo.ItemsSource = new List<string>() { "Rectangle", "Cube", "Circle" };
        }

        private void neu_Click(object sender, RoutedEventArgs e)
        {
            Shapes.Add(new GeoObject(
                combo.SelectedItem.ToString(),
                int.Parse(posX.Text),
                int.Parse(posY.Text),
                int.Parse(laenge.Text),
                int.Parse(breite.Text))
            );

            datagrid.ItemsSource = null;
            datagrid.ItemsSource = Shapes;
        }

        private void btnZeichnen_Click(object sender, RoutedEventArgs e)
        {
            var temp = datagrid.SelectedItem as GeoObject;
            Shape geoObject;

            switch (temp.Shape)
            {
                case "Rectangle":
                    geoObject = new Rectangle() { Height = temp.Height, Width = temp.Width, Stroke = new SolidColorBrush(Colors.Red), StrokeThickness = 1 };
                    mycanvas.Children.Add(geoObject);

                    geoObject.SetValue(Canvas.TopProperty, (double) temp.PosY);
                    geoObject.SetValue(Canvas.LeftProperty, (double) temp.PosX);
                    break;
            }
        }
    }
}
