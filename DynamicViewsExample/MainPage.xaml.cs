using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DynamicViewsExample
{
    public partial class MainPage : ContentPage
    {
        Label lblTxt;
        Button btnPress;
        int counter;
        public MainPage()
        {
            InitializeComponent();
            counter = 0;
            lblTxt = new Label();
            lblTxt.Text = $"Waiting for clicking";
            btnPress = new Button();
            btnPress.Clicked += BtnPress_Clicked;
            //btnPress.Clicked=(sender,e)=>{}
            stck.Children.Add(lblTxt);
            stck.Children.Add(btnPress);
            lblTxt.FontSize = 34;
            lblTxt.HorizontalTextAlignment = TextAlignment.Center;
          
        }

        private void BtnPress_Clicked(object sender, EventArgs e)
        {
            counter++;
            lblTxt.Text = $"Clicked {counter} times";
        }
    }
}
