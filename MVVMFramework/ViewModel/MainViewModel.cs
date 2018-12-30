using MVVMFramework.DataAccess;
using MVVMFramework.Helpers;
using MVVMFramework.Model;
using System;
using System.Collections.ObjectModel;

namespace MVVMFramework.ViewModel
{
    public sealed class MainViewModel : ViewModelBase
    {
        private object _selectedFahrzeug;
        private string _textProperty1;

        public ObservableCollection<Vehicle> Fahrzeuge { get; set; }

        public RelayCommand AddVehicleCommand { get; set; }

        public object SelectedFahrzeug
        {
            get => _selectedFahrzeug;
            set
            {
                if (_selectedFahrzeug != value)
                {
                    _selectedFahrzeug = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string TextProperty1
        {
            get => _textProperty1;
            set
            {
                if (_textProperty1 != value)
                {
                    _textProperty1 = value;
                    RaisePropertyChanged();
                }
            }
        }

        public MainViewModel()
        {
            Fahrzeuge = DatabaseLayer.GetVehiclesFromDatabase();
            AddVehicleCommand = new RelayCommand(AddVehicle);
        }

        private void AddVehicle(object obj)
        {
            if (obj == null)
            {
                return;
            }

            Random kw = new Random();

            Fahrzeuge.Add(new Vehicle(obj.ToString(), obj.ToString(), kw.Next()));
        }
    }
}
