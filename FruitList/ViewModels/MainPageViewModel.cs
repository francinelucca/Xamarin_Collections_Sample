using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using FruitList.Models;
using Xamarin.Forms;

namespace FruitList.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Fruit> Fruits { get; set; }
        private Fruit _selectedFruit;
        public Fruit SelectedFruit
        {
            get
            {
                return _selectedFruit;
            }
            set
            {
                _selectedFruit = value;
                if (_selectedFruit != null)
                {
                    DisplaySelectedFruit();
                }
            }
        }
        public ICommand DeleteItemCommand { get; set; }
        public MainPageViewModel()
        {
           Fruits = new ObservableCollection<Fruit>()
            {
                new Fruit()
                {
                    Name = "Pear",
                    Photo="pear.jpeg"
                },
                new Fruit()
                {
                    Name = "Apple",
                    Photo="apple.png"
                },
                new Fruit()
                {
                    Name = "Banana",
                    Photo="banana.jpg"
                },
                new Fruit()
                {
                    Name = "Orange",
                    Photo="orange.png"
                },
                new Fruit()
                {
                    Name = "Grapes",
                    Photo="grapes.jpeg"
                }
            };
            DeleteItemCommand = new Command<Fruit>(
                execute: (Fruit fruit) =>
                {
                    this.Fruits.Remove(fruit);
                });
        }
        public async void DisplaySelectedFruit()
        {
            await App.Current.MainPage.DisplayAlert("Fruit Selection", String.Format("Selected Fruit: {0}", _selectedFruit.Name), "OK");
        }
    }
}
