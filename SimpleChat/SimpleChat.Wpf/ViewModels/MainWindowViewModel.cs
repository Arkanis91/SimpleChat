using System;
using System.Collections.Generic;
using SimpleChat.Client.Wpf.ViewModels.Interfaces;
using SimpleChat.Core.Objects.Client;

namespace SimpleChat.Client.Wpf.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public int Status { get; set; }
        public IList<ClientUser> AllUsers { get; set; }

        public MainWindowViewModel()
        {
            Status = new Random().Next(0, 5);
        }
    }
}
