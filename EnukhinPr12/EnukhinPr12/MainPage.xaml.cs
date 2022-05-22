using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnukhinPr12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            int one = 0;
            int two = 1;
            int sum = 0;
            grid.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            var rnd = new Random();
            int i = 0;

            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 30 });
            Label txt0 = new Label();
            txt0.Text = "0";
            txt0.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            txt0.HorizontalTextAlignment = TextAlignment.Center;
            txt0.VerticalTextAlignment = TextAlignment.Center;
            txt0.FontSize = 22;
            txt0.TextColor = Color.White;
            grid.Children.Add(txt0, i, 0);
            i++;
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 30 });
            Label txt1 = new Label();
            txt1.Text = "1";
            txt1.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            txt1.HorizontalTextAlignment = TextAlignment.Center;
            txt1.VerticalTextAlignment = TextAlignment.Center;
            txt1.FontSize = 22;
            txt1.TextColor = Color.White;
            grid.Children.Add(txt1, i, 0);
            i++;

            do
            {
                sum = one + two;
                one = two;
                two = sum;
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 30 });
                Label txt = new Label();
                txt.Text = sum.ToString();
                txt.BackgroundColor = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                txt.HorizontalTextAlignment = TextAlignment.Center;
                txt.VerticalTextAlignment = TextAlignment.Center;
                txt.FontSize = 22;
                txt.TextColor = Color.White;
                grid.Children.Add(txt, i, 0);
                i++;
            } while (50 >= one + two);

        }
    }
}