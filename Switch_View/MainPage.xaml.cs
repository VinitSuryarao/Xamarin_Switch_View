using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switch_View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SwitchImg_Toggled(object sender, ToggledEventArgs e)
        {
            bool value = e.Value;
            if (value)
            {
                BackgroundImageSource = "SampleImg4.jpg";
            }
            else
            {
                BackgroundImageSource = "SampleImg5.jpg";
            }
        }
    }
}
