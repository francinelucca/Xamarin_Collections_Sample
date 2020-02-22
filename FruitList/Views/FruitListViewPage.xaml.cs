using System;
using System.Collections.Generic;
using FruitList.ViewModels;
using Xamarin.Forms;

namespace FruitList.Views
{
    public partial class FruitListViewPage : ContentPage
    {
        public FruitListViewPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
