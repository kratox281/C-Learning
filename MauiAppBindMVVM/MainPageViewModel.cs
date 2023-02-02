using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBindMVVM
{
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private DateTime _dateTime;
        private Timer _timer;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                if (_dateTime != value)
                {
                    _dateTime = value;
                    OnPropertyChanged(); // reports this property
                }
            }
        }

        public MainPageViewModel()
        {
            this.DateTime = DateTime.Now;

            // Update the DateTime property every second.
            _timer = new Timer(new TimerCallback((s) => this.DateTime = DateTime.Now),
                               null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        ~MainPageViewModel() =>
            _timer.Dispose();

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        #region HSL
        private float _hue, _saturation, _luminosity;
        private Color _color;

        public float Hue
        {
            get => _hue;
            set
            {
                if (_hue != value)
                    Color = Color.FromHsla(value, _saturation, _luminosity);
            }
        }

        public float Saturation
        {
            get => _saturation;
            set
            {
                if (_saturation != value)
                    Color = Color.FromHsla(_hue, value, _luminosity);
            }
        }

        public float Luminosity
        {
            get => _luminosity;
            set
            {
                if (_luminosity != value)
                    Color = Color.FromHsla(_hue, _saturation, value);
            }
        }

        public Color Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    _color = value;
                    _hue = _color.GetHue();
                    _saturation = _color.GetSaturation();
                    _luminosity = _color.GetLuminosity();

                    OnPropertyChanged("Hue");
                    OnPropertyChanged("Saturation");
                    OnPropertyChanged("Luminosity");
                    OnPropertyChanged(); // reports this property
                }
            }
        }
        #endregion

    }
}
