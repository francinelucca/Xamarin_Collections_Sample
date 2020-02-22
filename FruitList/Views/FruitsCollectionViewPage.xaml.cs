using System;
using System.Collections.Generic;
using FruitList.ViewModels;
using Xamarin.Forms;

namespace FruitList.Views
{
    public partial class FruitsCollectionViewPage : ContentPage
    {
        public FruitsCollectionViewPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
