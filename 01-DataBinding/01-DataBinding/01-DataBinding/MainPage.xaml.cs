using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _01_DataBinding
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            slider2.Value = 0.5;
        }

        private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = string.Format("Value is {0:F2}", slider1.Value);
        }
    }
}
