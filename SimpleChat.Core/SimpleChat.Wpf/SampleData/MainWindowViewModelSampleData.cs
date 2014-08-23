using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Wpf.ViewModels.Interfaces;

namespace SimpleChat.Wpf.SampleData
{
    public class MainWindowViewModelSampleData:IMainWindowViewModel
    {
        public int Status { get; set; }

        public MainWindowViewModelSampleData()
        {
            Status = 1;
        }
    }
}
