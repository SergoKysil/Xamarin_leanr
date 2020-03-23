using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_leanr.ViewModels.ToDoViewModels;

namespace Xamarin_leanr.Views.ToDoViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToDoView : ContentPage
    {
        public AddToDoView()
        {
            InitializeComponent();
            this.BindingContext = new AddToDoViewModel(Navigation);
        }
    }
}