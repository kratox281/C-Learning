using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutsTemaLibre.Views
{
    public class MangaSearchHandler : SearchHandler
    {
        public Type SelectedItemNavigationTarget { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            await Task.Delay(1000);


            ShellNavigationState state = (App.Current.MainPage as Shell).CurrentState;
        }

        string GetNavigationTarget()
        {
            return "Resultado";
        }
    }
}
