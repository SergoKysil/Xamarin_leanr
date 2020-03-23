using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_leanr.ViewModels.ToDoViewModels;

namespace Xamarin_leanr.Views.ToDoViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailToDoView : ContentPage
    {
        public DetailToDoView(int id)
        {
            InitializeComponent();
            this.BindingContext = new DetailsToDoViewModel(Navigation, id);
        }
    }
}