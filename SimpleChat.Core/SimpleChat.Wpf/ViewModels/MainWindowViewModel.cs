using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Wpf.ViewModels.Interfaces;

namespace SimpleChat.Wpf.ViewModels
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
