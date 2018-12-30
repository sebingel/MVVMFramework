using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMFramework.Model
{
    public sealed class Vehicle : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _marke;
        private string _typ;
        private int _kilowatt;

        public Vehicle(string marke, string typ, int kilowatt)
        {
            this.Marke = marke;
            this.Typ = typ;
            this.Kilowatt = kilowatt;
        }

        public string Marke
        {
            get => _marke;
            set
            {
                if (_marke != value)
                {
                    _marke = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Typ
        {
            get => _typ;
            set
            {
                if (_typ != value)
                {
                    _typ = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int Kilowatt
        {
            get => _kilowatt;
            set
            {
                if (_kilowatt!=value)
                {
                    _kilowatt = value;
                    RaisePropertyChanged();
                }
            }
        }

        private void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
