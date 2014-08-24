using System;
using SimpleChat.Client.Wpf.ViewModels.Interfaces;

namespace SimpleChat.Client.Wpf.ViewModels
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        public int Status { get; set; }

        public MainWindowViewModel()
        {
            Status = new Random().Next(0, 5);
        }
    }
}
