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

namespace Практика4_Анисимов_Кошелева.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (X.Text.Length > 0 & Y.Text.Length > 0 & Z.Text.Length > 0)
            {
                double x = Convert.ToDouble(X.Text);
                double y = Convert.ToDouble(Y.Text);
                double z = Convert.ToDouble(Z.Text);


                double firstPart = Math.Pow(2, -x);
                double fourthRootY = Math.Pow(Math.Abs(y), 1.0 / 4.0);
                double expXminus1 = Math.Exp(x - 1);
                double sinZ = Math.Sin(z);
                double divisionResult = expXminus1 / sinZ;
                double cubeRoot = Math.Pow(divisionResult, 1.0 / 3.0);
                double product = fourthRootY * cubeRoot;
                double sum = x + product;
                double sqrtPart = Math.Sqrt(sum);
                double result = firstPart * sqrtPart;
                Answer.Text = $"{result}";
            }
            else MessageBox.Show("Введите все значения");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            X.Text = "";
            Y.Text = "";
            Z.Text = "";
            Answer.Text = "";
        }
        


        private void TextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text[0]);
        }
    }
}
