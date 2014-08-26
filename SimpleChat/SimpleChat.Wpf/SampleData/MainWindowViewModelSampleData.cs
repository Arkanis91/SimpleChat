using System.Collections.Generic;
using SimpleChat.Client.Wpf.ViewModels.Interfaces;
using SimpleChat.Core.Objects.Client;

namespace SimpleChat.Client.Wpf.SampleData
{
    public class MainWindowViewModelSampleData:IMainWindowViewModel
    {
        public int Status { get; set; }
        public IList<ClientUser> AllUsers { get; set; }

        public MainWindowViewModelSampleData()
        {
            Status = 1;

            AllUsers = new[]
            {
                new ClientUser{Id = 0, Username = "Hans"},
                new ClientUser{Id = 0, Username = "Sepp"}
            };
        }
    }
}
