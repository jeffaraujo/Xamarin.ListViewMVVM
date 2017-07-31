using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.ListViewMVVM.ViewModel;

namespace Xamarin.ListViewMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarroView : ContentPage
    {
        public CarroView()
        {
            InitializeComponent();
            this.BindingContext = new CarroViewModel();
        }
    }
}