﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TerminalMACS.Clients.App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "关于";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/dotnet9/TerminalMACS"));
        }

        public ICommand OpenWebCommand { get; }
    }
}