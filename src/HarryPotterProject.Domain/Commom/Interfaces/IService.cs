using Flunt.Notifications;
using System.Collections.Generic;

namespace HarryPotterProject.Domain.Commom.Interfaces
{
    public interface IService
    {
        bool Valid { get; }
        bool Invalid { get; }
        List<Notification> Notifications { get; }
    }
}
