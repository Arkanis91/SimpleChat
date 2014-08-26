using System.Collections.Generic;
using SimpleChat.Core.Objects.Client;

namespace SimpleChat.Client.Wpf.ViewModels.Interfaces
{
    public interface IMainWindowViewModel
    {
        int Status { get; set; }

        IList<ClientUser> AllUsers { get; set; } 
    }
}