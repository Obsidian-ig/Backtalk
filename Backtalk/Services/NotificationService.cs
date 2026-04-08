using Backtalk.Classes;
using Backtalk.Classes.Data;
using Microsoft.AspNetCore.Components;


namespace Backtalk.Services
{
    public class NotificationService : INotificationService
    {
        [Inject]
        private protected AppDb? _db { get; set; }

        private List<Notification> _popupNotifications = new List<Notification>();

        public NotificationService()
        {
            Task.Run(PopupNotificationsExpirationCheckInterval);
        }

        private async Task PopupNotificationsExpirationCheckInterval()
        {
            while (true)
            {
                foreach (var n in _popupNotifications)
                {
                    if (DateTime.Compare(n.expire_at_utc, DateTime.UtcNow) <= 0)
                    {
                        _popupNotifications.Remove(n);
                    }
                }
                await Task.Delay(1000);
            }
        }

        public void CreatePopupNotification(Notification notification)
        {
            _popupNotifications.Add(notification);
        }

        public void DeletePopupNotification(Notification notification)
        {
            _popupNotifications.Remove(notification);
        }

        public async Task<IReadOnlyList<Notification>> GetPopupNotifications()
        {
            return _popupNotifications.AsReadOnly();
        }

        public async Task<bool> CreateInboxNotificationAsync(Notification notification)
        {
            try
            {
                if (_db == null) throw new Exception("AppDb db returned NULL - NotificationService.cs");
                await _db.Inbox.PutAsync<Notification>(notification);
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> DeleteInboxNotificationAsync(Notification notification)
        {
            try
            {
                if (_db == null) throw new Exception("AppDb db returned NULL - NotificationService.cs");
                await _db.Inbox.DeleteAsync<Notification>(notification);
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return false;
            }
        }

        public async Task<bool> MarkInboxNotificationReadAsync(Notification notification)
        {
            try
            {
                if (_db == null) throw new Exception("AppDb db returned NULL - NotificationService.cs");
                var result = await _db.Inbox.GetAsync<Notification, Notification>(notification);
                if (result == null)
                {
                    Console.Error.WriteLine("Failed to find notification in database!");
                    return false;
                }
                result.read = true;
                await _db.Inbox.PutAsync<Notification>(result);
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return false;
            }
        }

        public async Task<IReadOnlyList<Notification>?> GetInboxNotificationsAsync()
        {
            try
            {
                if (_db == null) throw new Exception("AppDb db returned NULL - NotificationService.cs");
                var result = await _db.Inbox.GetAllAsync<Notification>();
                return result.AsReadOnly();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return null;
            }
        }
    }
}