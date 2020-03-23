using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_leanr.ViewModels.ContactViewModels;

namespace Xamarin_leanr.Views.ContactViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactList : ContentPage
    {
        public ContactList()
        {
            InitializeComponent();
            this.BindingContext = new ContactListViewModel(Navigation);
        }

    }
}