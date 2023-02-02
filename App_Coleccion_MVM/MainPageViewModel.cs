using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App_Coleccion_MVM
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Pojo currentPojo;
        private int indice;
        public string Posicion { get => $"{indice+1}"; }
        public ICommand SiguienteCommand { get; private set; }
        public ICommand AnteriorCommand { get; private set; }
        public MainPageViewModel()
        {
            SociosService sociosService = new();
            indice = 0;
            currentPojo = Pojo
            SiguienteCommand = new Command(() =>
            CurrentPojo = Pojos.elementat(++indice),
            () =>
                    indice <10
                );
            AnteriorCommand = new Command(() =>
            CurrentPojo = Pojos.elementat(--indice),
            () =>
                    indice >0
                );
        }
        public Pojo CurrentPojo
        {
            get => currentPojo;
            private set
            {
                if(currentPojo != value)
                {
                    currentPojo = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Posicion));
                    ((Command)SiguienteCommand).ChangeCanExecute();
                    ((Command)AnteriorCommand).ChangeCanExecute();
                }
            }
        }
    public void OnPropertyChanged([CallerMemberName] string name = )
                PropertyChanged
    }
    
}
