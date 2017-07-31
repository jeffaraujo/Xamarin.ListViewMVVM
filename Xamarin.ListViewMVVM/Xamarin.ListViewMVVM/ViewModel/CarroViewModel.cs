using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.ListViewMVVM.Annotations;
using Xamarin.ListViewMVVM.Model;

namespace Xamarin.ListViewMVVM.ViewModel
{
    public class CarroViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private ObservableCollection<Carro> items;

        public ObservableCollection<Carro> Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged(nameof(Items)); }
        }

        public CarroViewModel()
        {
            Items = new ObservableCollection<Carro>()
            {
                new Carro() {Id = 1, Ano = 2015, Marca = "Volkwagen"},
                new Carro() {Id = 2, Ano = 2014, Marca = "Tesla Model S"},
                new Carro() {Id = 3, Ano = 2016, Marca = "Fiat"},
                new Carro() {Id = 4, Ano = 2017, Marca = "Renault"},
                new Carro() {Id = 5, Ano = 2016, Marca = "Nissan"}
            };
        }



        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
             PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
