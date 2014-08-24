using SimpleChat.Client.Wpf.ViewModels.Interfaces;

namespace SimpleChat.Client.Wpf.SampleData
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
