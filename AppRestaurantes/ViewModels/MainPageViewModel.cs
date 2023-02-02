using AppRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppRestaurantes.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Restaurante currentRestaurant;
        public Restaurante CurrentRestaurant { get; private set; }
        public ICommand SelectionChanged { get;private set; }
        public ObservableCollection<Restaurante> RestaurantesList { get; }
        public Restaurante RestauranteSeleccionado { get; set; }
        public MainPageViewModel(Services.RestauranteService restauranteService) {

            RestaurantesList = new ObservableCollection<Restaurante>(restauranteService.GetRestaurantes());
                SelectionChanged = new Command(
                async () =>
                {
                    if (CurrentRestaurant != null)
                    {
                        await Shell.Current.GoToAsync(
                            nameof(MauiAppMVVMColec.Detalle),
                            true,
                            new Dictionary<string, object> { { "Restaurante", CurrentRestaurant } });
                    }
                }
                );
        }
        
    }
}
