﻿using System.ComponentModel;
using testapp.ViewModels;
using Xamarin.Forms;

namespace testapp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}