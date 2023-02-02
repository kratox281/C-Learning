using FlyoutsTemaLibre.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FlyoutsTemaLibre
{
    class DeadManViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DeadMans currentDeadMan;
        public DeadMans CurrentDeadMan { get; private set; }
        public ICommand SelectionChanged { get; private set; }
        public ObservableCollection<DeadMans> DeadMansList { get;}
        public DeadMans DeadmanSelecionado { get; set; }
        public DeadManViewModel(Services.DeadMansService deadMansService)
        {
            DeadMansList = new ObservableCollection<DeadMans>(deadMansService.GetDeadMans());
           
        }
    }
}
