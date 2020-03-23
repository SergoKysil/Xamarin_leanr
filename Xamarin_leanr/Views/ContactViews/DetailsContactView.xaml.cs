using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_leanr.Views.ContactViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsContactView : ContentPage
    {
        public DetailsContactView( int ContactID)
        {
            InitializeComponent();
        }
    }
}