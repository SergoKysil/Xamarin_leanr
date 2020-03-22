using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_leanr.Model;
using Xamarin_leanr.ViewModels;
using Xamarin_leanr.Views.AboutView;

namespace Xamarin_leanr.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {

        public List<MenuPageItems> MenuPages { get; set; }
        public MainPage()
        {           
            InitializeComponent();

            MenuPages = new List<MenuPageItems>
            {
                new MenuPageItems() { Title = "Contacts", PageType = typeof(Views.ContactViews.ContactList) },
                new MenuPageItems() { Title = "About", PageType = typeof(AboutPage) }
                    
            };


            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AboutPage)));
            Menu.ItemsSource = MenuPages;
        }

        private void Menu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MenuPageItems)e.SelectedItem;
            Type page = item.PageType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
