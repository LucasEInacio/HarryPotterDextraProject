using Flunt.Notifications;
using Flunt.Validations;
using HarryPotterProject.Domain.Commom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotterProject.Domain.Commom
{
    public class ServiceBase : IService
    {
        public List<Notification> Notifications { get; protected set; } = new List<Notification>();

        public bool Valid => Notifications.Any();

        public bool Invalid => !Valid;

        protected bool ValidateRequest<T>(T request) where T : Notifiable, IValidatable 
        {
            request.Validate();

            if (!request.Valid)
                AddRequestNotifications(request.Notifications);

            return request.Valid;
        }

        private void AddRequestNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }
    }
}
