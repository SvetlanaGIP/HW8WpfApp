using Microsoft.Win32;
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

namespace HW7WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           /* List<string> styles = new List<string>() { "Light theme", "Dark theme" };
            styleBox.ItemsSource = styles;
            styleBox.SelectionChanged += ThemeChange;
            styleBox.SelectedIndex = 0;*/

        }

        /*private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex;
            Uri uri = new Uri("Light.xaml", UriKind.Relative);
            if (styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);
            }
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }*/

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = (sender as ComboBox).SelectedItem as string;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            if (textBox != null)
            {
                double fontSize = Convert.ToDouble((sender as ComboBox).SelectedItem);
                textBox.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations.Count == 0)
            {
                textBox.TextDecorations.Add(TextDecorations.Underline);
            }
            else
            {
                //textBox.TextDecorations.RemoveAt(0);
                textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void styleBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries.Clear();
            Uri uri = new Uri(styleBox.SelectedIndex == 0 ? "Light.xaml" : "Dark.xaml", UriKind.Relative);
            ResourceDictionary themeDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(themeDict);
            Uri uri2 = new Uri("Dictionary1.xaml", UriKind.Relative);
            ResourceDictionary themeDict2 = Application.LoadComponent(uri2) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(themeDict2);
        }
    }
}

