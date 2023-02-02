using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyoutsTemaLibre.Services
{
    public class DeadMansService
    {
        List<DeadMans> deadMans;
        public List<DeadMans> GetDeadMans()
        {
            if (deadMans?.Count > 0)
            {
                return deadMans;
            }

            deadMans = new List<DeadMans>
            {
                new DeadMans { NumDeadMan = 1, NombreDeadMan = "Crow", ImagenDeadman = "" },
                new DeadMans { NumDeadMan = 2, NombreDeadMan = "Ganta", ImagenDeadman = "" },
                new DeadMans { NumDeadMan = 3, NombreDeadMan = "Shhiro", ImagenDeadman = "" }
            };
            deadMans.TrimExcess();
            App.Current.MainPage.DisplayAlert("Deadmans creados", "Listo", "Aceptar", "Cancelar");
            return deadMans;
        }
    }
}
