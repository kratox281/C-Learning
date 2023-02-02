
using AppRestaurantes.Models;
using AppRestaurantes.ViewModels;
using MauiAppMVVMColec;

namespace AppRestaurantes;
public partial class MainPage : ContentPage
{


    public MainPage(MainPageViewModel mainPageViewModel)
    {
        InitializeComponent();
        this.BindingContext = mainPageViewModel;
    }


   
}

