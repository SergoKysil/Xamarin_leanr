using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_leanr.ViewModels.ToDoViewModels;

namespace Xamarin_leanr.Views.ToDoViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoListView : ContentPage
    {
        public ToDoListView()
        {
            InitializeComponent();
            this.BindingContext = new ToDoListVeiwModel(Navigation);
        }


    }
}