﻿using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin_leanr.ViewModels.Base;
/// <summary>
/// Using to work with AboutView
/// </summary>
namespace Xamarin_leanr.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {

        public ICommand OpenWebCommand { get; }
        public ICommand OpenGitCommand { get; }
        public AboutViewModel()
        {
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
            OpenGitCommand = new Command(async () => await Browser.OpenAsync("https://github.com/SergoKysil"));
        }

       
    }
}
